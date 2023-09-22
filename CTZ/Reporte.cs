using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Data.SqlClient;
using System.Net;

namespace CTZ
{
    public partial class Reporte : MaterialForm
    {
        private string REPORTE, ident;
        private DateTime f1, f2;

        //CONTIENE TODOS LOS REPORTES, SE REDIRIGEN CON UN CASE PARA EL TIPO DE REPORTE

    // retorna el reporte indicado
        public string GetREPORTE1()
        {
            return REPORTE;
        }

        public void SetREPORTE1(string value)
        {
            REPORTE = value;
        }

        public DateTime GetF1()
        {
            return f1;
        }

        public void SetF1(DateTime value)
        {
            f1 = value;
        }

        public DateTime GetF2()
        {
            return f2;
        }

        public void SetF2(DateTime value)
        {
            f2 = value;
        }

        //obtiene el id del equipo mandado desde el formulario utilizado
        public string GetIdent()
        {
            return ident;
        }

        public void SetIdent(string value)
        {
            ident = value;
        }

        private Functions ft = new Functions();

        public Reporte()
        {
            /*Este Form contiene las rutinas para visualizar los formatos de impresión de los distintos
             * datagrids de la aplicación
             */
            InitializeComponent();
            //this.asignacionTableAdapter.Fill(this.asignacionDataSet.Asignacion);
            //this.modeloITableAdapter.Fill(this.datasetHistory.ModeloI);
        }

        public string CONNECTION = "http://INOLABSERVER01/Reportes_Inolab";

        //obtiene reporte de certificados, de asignacion y de inventario
        public void Ver(ReportViewer reportViewer1, string reporte, string ident)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");

            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            ReportParameter parameter1 = new ReportParameter();
            parameter1.Name = "ident";
            parameter1.Values.Add(ident);

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter1 });

            reportViewer1.RefreshReport();
        }

        public void Ver(ReportViewer reportViewer1, string reporte, DateTime f1, DateTime f2, string desc)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "f1";
            parameter.Values.Add(ft.DateToString(f1));
            ReportParameter parameter0 = new ReportParameter();
            parameter0.Name = "f2";
            parameter0.Values.Add(ft.DateToString(f2));
            ReportParameter parameter1 = new ReportParameter();
            parameter1.Name = "desc";
            parameter1.Values.Add(desc);

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter0 });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter1 });
            reportViewer1.RefreshReport();
        }

        public void Ver(ReportViewer reportViewer1, string reporte, DateTime f1, DateTime f2, string desc, string est)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "f1";
            parameter.Values.Add(ft.DateToString(f1));
            ReportParameter parameter0 = new ReportParameter();
            parameter0.Name = "f2";
            parameter0.Values.Add(ft.DateToString(f2));
            ReportParameter parameter1 = new ReportParameter();
            parameter1.Name = "desc";
            parameter1.Values.Add(desc);
            ReportParameter parameter2 = new ReportParameter();
            parameter2.Name = "est";
            parameter2.Values.Add(est);

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter0 });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter1 });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter2 });
            reportViewer1.RefreshReport();
        }


        //abre reporte de calendario calibracion general
        public void Ver(ReportViewer reportViewer1, string reporte, DateTime f1, DateTime f2, bool show)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            if (show)
            {
                reportViewer1.ShowParameterPrompts = true;
            }
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "f1";
            parameter.Values.Add(ft.DateToString(f1));
            ReportParameter parameter0 = new ReportParameter();
            parameter0.Name = "f2";
            parameter0.Values.Add(ft.DateToString(f2));

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter0 });
            reportViewer1.RefreshReport();
        }

        //abre el reporte para acuse de calibracion
        public void Ver(ReportViewer reportViewer1, string reporte, DateTime f1, bool show)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            if (show)
            {
                reportViewer1.ShowParameterPrompts = true;
            }
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "f1";
            parameter.Values.Add(ft.DateToString(f1));

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter });
            reportViewer1.RefreshReport();
        }

        //abre el calendario para el reporte de calibracion
        public void Ver(ReportViewer reportViewer1, string reporte, bool show)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;
            if (show)
            {
                reportViewer1.ShowParameterPrompts = true;
            }
            reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            Console.WriteLine("LOADEd");
        }

        //muestra el historial del equipo
        public void Ver(ReportViewer reportViewer1, string reporte, string ident, DateTime f1, DateTime f2)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            //reportViewer1.ShowParameterPrompts = false;
            ReportParameter parameter = new ReportParameter();
            parameter.Name = "f1";
            parameter.Values.Add(ft.DateToString(f1));
            ReportParameter parameter0 = new ReportParameter();
            parameter0.Name = "f2";
            parameter0.Values.Add(ft.DateToString(f2));
            ReportParameter parameter1 = new ReportParameter();
            parameter1.Name = "ident";
            parameter1.Values.Add(ident);

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter0 });
            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter1 });
            reportViewer1.RefreshReport();
        }

        private void Reporte_Deactivate(object sender, EventArgs e)
        {
            GC.Collect();
        }


        //muestra el historial del cliente y el historial del fsr
        public void Ver(ReportViewer reportViewer1, string reporte, string ident, string param)
        {
            Functions ft = new Functions();

            System.Net.NetworkCredential myCred = new NetworkCredential("cflores", "carlos_42");
            //MessageBox.Show("DatosReales");
            reportViewer1.ServerReport.ReportServerCredentials.NetworkCredentials = myCred;
            reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Remote;
            reportViewer1.ServerReport.ReportServerUrl = new Uri(CONNECTION);
            reportViewer1.ServerReport.ReportPath = "/Servicio/" + reporte;
            reportViewer1.ShowParameterPrompts = false;

            ReportParameter parameter1 = new ReportParameter();
            parameter1.Name = param;
            parameter1.Values.Add(ident);

            reportViewer1.ServerReport.SetParameters(new ReportParameter[] { parameter1 });

            reportViewer1.RefreshReport();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            /*Rutina de seleccion de funciones para visualización de reportes
             */
            switch (GetREPORTE1())
            {
                //Nombre de los reportes:
                //muestra acuse desde Form1
                case "AcuseCalibracion":
                    Text = "Acuse De Calibración";
                    Ver(reportViewer1, GetREPORTE1(), DateTime.Now, true);
                    break;

                case "CalendarioEstatus":
                    Text = "Calendario por estatus";

                    Ver(reportViewer1, GetREPORTE1(), true);
                    break;

                case "CalendarioCalibracionGeneral":
                    Text = "Calendario De Calibración General";
                    Ver(reportViewer1, GetREPORTE1(), DateTime.Now.AddYears(-1), DateTime.Now, true);
                    break;

                case "CalendarioCalibracion":
                    this.Text = "Calendario De Calibración";

                    Ver(reportViewer1, GetREPORTE1(), true);
                    break;

                case "HistoryEQ":
                    this.Text = "Historial del instrumento: " + GetIdent();

                    Ver(reportViewer1, GetREPORTE1(), GetIdent(), DateTime.Now.AddYears(-1), DateTime.Now);
                    break;

                case "HistoryCient":

                    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

                    SqlDataReader reader = ft.GetRead("Select empresa from Clientes where idcliente=" + ident + ";",
                        ft.connectionStringBrowser);
                    this.Text = "Historial del cliente: " + reader.GetValue(0);
                    Ver(reportViewer1, GetREPORTE1(), GetIdent(), "idc");
                    break;

                case "HistoryFSR":

                    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

                    this.Text = "Instrumentos usados en el folio: " + GetIdent();
                    Ver(reportViewer1, GetREPORTE1(), ident, "fsr");
                    break;

                case "UltimosCertificados":

                    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

                    this.Text = "Últimos Certificados";
                    Ver(reportViewer1, GetREPORTE1(), this.Text);
                    break;

                case "ResumenAsignacion":

                    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

                    this.Text = "Resumen de Asignación";
                    Ver(reportViewer1, GetREPORTE1(), this.Text);
                    break;

                case "Inventario":

                    this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;

                    this.Text = "Inventario INO-FI-030";
                    Ver(reportViewer1, GetREPORTE1(), this.Text);
                    break;

                default:
                    this.Close();
                    break;
            }
            //this.reportViewer1.RefreshReport();
        }
    }
}