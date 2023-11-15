using CTZ.View.Responsabilitis;
using CTZ.Vista.Traceability;
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

namespace CTZ.View.Calibration
{
    public partial class CalibrationRequestReport : MaterialForm
    {
        string serverUrl = "http://INOLABSERVER03/Reportes_Inolab";
        private readonly CalibrationRequest calibrationRequest;
        private readonly int idLaboratory;
        private readonly string idCalibrationRequest;

        public CalibrationRequestReport(int idLaboratory, string idCalibrationRequest)
        {
            InitializeComponent();
            System.Net.NetworkCredential credentials = new NetworkCredential("administrador", "Inolab_2023*");
            Report_CalibrationRequest.ServerReport.ReportServerCredentials.NetworkCredentials = credentials;
            Report_CalibrationRequest.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            Report_CalibrationRequest.ServerReport.ReportServerUrl = new Uri(serverUrl);
            this.idLaboratory = idLaboratory;
            this.idCalibrationRequest = idCalibrationRequest;
        }

        private void CalibrationRequestReport_Load(object sender, EventArgs e)
        {
            this.Report_CalibrationRequest.RefreshReport();
            initReportCalibrationRequest();
        }

        private void initReportCalibrationRequest()
        {
            Report_CalibrationRequest.ServerReport.ReportPath = "/Trazabilidad/" + "Acuse_De_Calibracion";
            Report_CalibrationRequest.ShowParameterPrompts = false;

            addParameter("IdLaboratorio", Convert.ToString(this.idLaboratory));
            addParameter("ID_Socitud_Calibracion", this.idCalibrationRequest);
            Report_CalibrationRequest.RefreshReport();
        }

        private void addParameter(string name, string value)
        {
            ReportParameter parameter = new ReportParameter();
            parameter.Name = name;
            parameter.Values.Add(value);
            Report_CalibrationRequest.ServerReport.SetParameters(new ReportParameter[] { parameter });
        }



    }
}
