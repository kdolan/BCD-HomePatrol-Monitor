using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomePatrol.Object
{
    public class ScannerInfo
    {
        public string Mode { get; set; }
        public string V_Screen { get; set; }

        public MonitorList MonitorList { get; set; }
        public System System { get; set; }
        public Department Department { get; set; }
        public ConvFrequency ConvFrequency { get; set; }
        public Agc Agc { get; set; }
        public DualWatch DualWatch { get; set; }
        public Property Property { get; set; }
        public ViewDescription ViewDescription { get; set; }
    }
}
