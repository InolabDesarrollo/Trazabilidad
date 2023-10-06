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
using System.Xml.Linq;

namespace CTZ.Vista.Traceability
{
    public partial class ReportTraceabilityLetter : MaterialForm
    {
        string serverUrl = "http://INOLABSERVER03/Reportes_Inolab";
        private string nameOfReport;
        private  string _idTrazabilityLetter;
        private string _certificateNumber;

        public ReportTraceabilityLetter(string idTrazabilityLetter,string certificateNumber)
        {
            InitializeComponent();
            System.Net.NetworkCredential credentials = new NetworkCredential("administrador", "Inolab_2023*");
            Report_TraceabilityLetter.ServerReport.ReportServerCredentials.NetworkCredentials = credentials;
            Report_TraceabilityLetter.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            Report_TraceabilityLetter.ServerReport.ReportServerUrl = new Uri(serverUrl);
            this.nameOfReport = "Carta_Trazabilidad";

            this._idTrazabilityLetter = idTrazabilityLetter;
            this._certificateNumber = certificateNumber;
        }
        private void Report_TraceabilityLetter_Load(object sender, EventArgs e)
        {
            this.Report_TraceabilityLetter.RefreshReport();
            initReporteTrazabilityLetter();
        }

        private void initReporteTrazabilityLetter()
        {
            Report_TraceabilityLetter.ServerReport.ReportPath = "/Trazabilidad/" + nameOfReport;
            Report_TraceabilityLetter.ShowParameterPrompts = false;

            addParameter("ID_CartaTrazabilidad", _idTrazabilityLetter);
            addParameter( "Numero_Certificado", _certificateNumber);
            Report_TraceabilityLetter.RefreshReport();
        }

        private void addParameter(string name,string value)
        {
            ReportParameter parameter = new ReportParameter();
            parameter.Name = name;
            parameter.Values.Add(value);
            Report_TraceabilityLetter.ServerReport.SetParameters(new ReportParameter[] { parameter });
        }
       
    }
}
