using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;
using System.Xml;
using HomePatrol.Object;
using Newtonsoft.Json;
using System.Diagnostics;
using Newtonsoft.Json.Linq;


namespace HomePatrol.Controller
{
    public class HomePatrolController
    {
        public delegate void ScannerUpdatedHandler();
        public event ScannerUpdatedHandler ScannerUpdated;

        private SerialPort _port;
        public ScannerInfo ScannerInfo { get; private set; }

        public bool HardwareConnected { get; private set; }

        private System.Timers.Timer _timer;

        private string inBuffer;

        public HomePatrolController()
        {
            _port = new SerialPort("COM4", 9600, Parity.None, 8, StopBits.One);
            _port.WriteTimeout = 100;
            _port.ReadTimeout = 100;
            _port.DataReceived += port_DataReceived;

            try
            {
                _port.Open();
                HardwareConnected = true;
            }
            catch (Exception ex)
            {

            }

            _timer = new System.Timers.Timer(300);
            _timer.Elapsed += timerElapsed;
            _timer.Start();
            _port.Write("GSI\r");
        }

        private void ProcessData()
        {
            var rawData = _port.ReadExisting();
            inBuffer = inBuffer + rawData;

            if (inBuffer.Contains("VOL,OK\r"))
                inBuffer = inBuffer.Replace("VOL,OK\r", "");

            if (inBuffer.Contains("</ScannerInfo>"))
            {
                //Contains complete dataset
                var dataIndex = inBuffer.IndexOf("</ScannerInfo>") + "/ScannerInfo>".Length;
                var dataString = inBuffer.Substring(0, dataIndex + 1);
                inBuffer = inBuffer.Substring(dataIndex + 1);
                if (inBuffer == "\r")
                    inBuffer = "";

                //Process dataString
                var xml = dataString.Replace("GSI,<XML>,\r", "").Trim();
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xml);
                var json = JsonConvert.SerializeXmlNode(doc).Replace("@", ""); //Removes @ From property names
                var jObject = JsonConvert.DeserializeObject<JObject>(json);
                var jObjectString = jObject.ToString();
                ScannerInfo = jObject["ScannerInfo"].ToObject<ScannerInfo>();
                ScannerUpdated?.Invoke();
            }


        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            ProcessData();
        }

        private void timerElapsed(object sender, ElapsedEventArgs e)
        {
            //Ask for data
            _port.Write("GSI\r");
        }

        public void MuteToggle()
        {
            _port.Write(int.Parse(ScannerInfo.Property.Vol) == 0 ? "VOL,10\r" : "VOL,0\r");
        }
    }
}
