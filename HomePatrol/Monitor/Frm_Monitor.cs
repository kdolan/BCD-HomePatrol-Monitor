using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomePatrol.Controller;

namespace Monitor
{
    public partial class Frm_Monitor : Form
    {
        private HomePatrolController Scanner;

        public Frm_Monitor()
        {
            InitializeComponent();
            Scanner = new HomePatrolController();
        }

        private void Frm_Monitor_Load(object sender, EventArgs e)
        {
            Scanner.ScannerUpdated += ScannerUpdated;
            TopMost = true;
        }

        private void ScannerUpdated()
        {
            if (InvokeRequired)
                BeginInvoke(new Action(UpdateForm));
            else
                UpdateForm();

        }

        private void UpdateForm()
        {
            try
            {
                lbl_SystemName.Text = Scanner.ScannerInfo.System.Name;
                lbl_DepartmentName.Text = Scanner.ScannerInfo.Department.Name;
                lbl_ConvFreq.Text = Scanner.ScannerInfo.ConvFrequency.Name;
                lbl_viewDescrip.Text = Scanner.ScannerInfo.ViewDescription.Overwrite != null ? Scanner.ScannerInfo.ViewDescription.Overwrite.Text : "Busy (Listening)";
            }
            catch (Exception ex)
            {
                Console.WriteLine("Warning an error has occured... Continuing");
            }

        }
    }
}
