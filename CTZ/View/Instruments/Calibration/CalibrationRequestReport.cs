using CTZ.Controler.Instruments;
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

        private readonly string idLaboratory;
        private readonly string idCalibrationRequest;
        private readonly string numberOfReport;
        private readonly string dateOfRequest;
        DataTable calibrationRequestInformation;

        public CalibrationRequestReport(string idCalibrationRequest)
        {
            InitializeComponent();
            System.Net.NetworkCredential credentials = new NetworkCredential("administrador", "Inolab_2023*");
            Report_CalibrationRequest.ServerReport.ReportServerCredentials.NetworkCredentials = credentials;
            Report_CalibrationRequest.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            Report_CalibrationRequest.ServerReport.ReportServerUrl = new Uri(serverUrl);
            C_CalibrationRequest controler = new C_CalibrationRequest();
            calibrationRequestInformation =controler.getAllById(idCalibrationRequest);


            this.idLaboratory = calibrationRequestInformation.Rows[0]["Id_Laboratorio"].ToString();
            this.idCalibrationRequest = idCalibrationRequest;
            this.numberOfReport = calibrationRequestInformation.Rows[0]["Numero_De_Folio"].ToString();
            this.dateOfRequest = calibrationRequestInformation.Rows[0]["Fecha"].ToString();
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
            addParameter("Fecha", this.dateOfRequest);
            addParameter("Folio",this.numberOfReport);
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
