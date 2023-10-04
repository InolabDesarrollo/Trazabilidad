using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public partial class Report : MaterialForm
    {
        string serverUrl = "http://INOLABSERVER03/Reportes_Inolab";
        private string nameOfReport;

        public Report(string nameOfReport)
        {
            InitializeComponent();
            this.nameOfReport = nameOfReport;
            System.Net.NetworkCredential credentials = new NetworkCredential("administrador", "Inolab_2023*");
            ReportViewer.ServerReport.ReportServerCredentials.NetworkCredentials = credentials;
            ReportViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            ReportViewer.ServerReport.ReportServerUrl = new Uri(serverUrl);
        }

        private void Report_Load(object sender, EventArgs e)
        {
            initReport();
            this.ReportViewer.RefreshReport();
        }

        private void initReport()
        {
            switch (nameOfReport) {
                case "Calendario_Instrumentos_General":
                    initReportCalendarInstrument();
                    break;
            }
        }

        private void initReportCalendarInstrument()
        {    
            ReportViewer.ServerReport.ReportPath = "/Trazabilidad/" + nameOfReport;
            ReportViewer.ShowParameterPrompts = false;
        }

       
    }
}
