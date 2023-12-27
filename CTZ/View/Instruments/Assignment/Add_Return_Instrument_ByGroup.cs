using CTZ.Controlador;
using CTZ.Controler;
using CTZ.Controler.Instruments;
using CTZ.Vista.Responsabilitis;
using Grpc.Core;
using MaterialSkin.Controls;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class Add_Return_Instrument_ByGroup : MaterialForm
    {
        private C_Instruments instrumentsControler;
        public Instrument_Assignments instrumentAssignments;
        private DataTable instrumenAssignmentInformation;
        private C_ReturnOfInstrument controlerReturnOfInstrument;

        public static List<int> idInstruments;
        public static List<string> equinos;
        public DataTable instrumentInformation;

        public Add_Return_Instrument_ByGroup()
        {
            InitializeComponent();
            idInstruments = new List<int>();
            equinos = new List<string>();
            instrumentAssignments = new Instrument_Assignments();
            instrumenAssignmentInformation = new DataTable();
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrumen(TxtBox_Instrumenst.Text))
            {
                instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();

                if (statusAssignments.Equals("DISPONIBLE"))
                {
                    MessageBox.Show("Este Instrumento No ha sido asignado");
                }
                else
                {
                    string equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                    idInstruments.Add(Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString()));
                    equinos.Add(equinoInstrument);

                    ComboBox_Instruments.Items.Add(equinoInstrument);
                    MessageBox.Show("Se agrego Equino " + equinoInstrument);
                    TxtBox_Instrumenst.Clear();
                }
            }
            else
            {
                MessageBox.Show("Instrumento No Existe");
            }
        }

        private void Btn_RegistQualitySignatur_Click(object sender, EventArgs e)
        {
            RegistSignature signatureQualityAgent = new RegistSignature(instrumentAssignments, "Quality");
            signatureQualityAgent.Show();
        }

        private void Btn_Regist_ReturnOfInstruments_Click(object sender, EventArgs e)
        {
            controlerReturnOfInstrument = new C_ReturnOfInstrument();
            instrumenAssignmentInformation = controlerReturnOfInstrument.selectMoreRecentInformationInstrumenAssignment(idInstruments[0]);

            string engineerMail = instrumenAssignmentInformation.Rows[0]["Correo_Ingeniero"].ToString();
            instrumentAssignments.dateOfReturn = DatePicker_DateOfReturn.Text;
            instrumentAssignments.observationsReturn = TxtBox_ObservationReturn.Text;
            controlerReturnOfInstrument.registerReturnInstrument(instrumentAssignments, idInstruments);

            updateStatusInstruments();
            sendQualityMailNotification(engineerMail);
            this.Hide();
        }

        private void updateStatusInstruments()
        {
            foreach (int id in idInstruments)
            {
                controlerReturnOfInstrument.updateStatusInstrumentAssignment(id,"DISPONIBLE");
            }
        }

        private void sendQualityMailNotification(string emailEngineer)
        {
            string[] qualityEmail = new string[3];
            qualityEmail[0] = emailEngineer;
            qualityEmail[1] = "omarflores@inolab.com";
            qualityEmail[2] = "calidad@inolab.com";

            string emailSubject = "Notificacion de devolucion de Instrumento";
            string emailBody = emailBodyForQuality();
            Responsabilitis.Notification notification = new Responsabilitis.Notification();
            notification.sendMailNotification(qualityEmail, emailBody, emailSubject);
        }

        private string emailBodyForQuality()
        {
            DateForReport dates = new DateForReport();
            string body;            
            body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Notificacion devolucion de Instrumento</title>\r\n    <style>\r\n        a {\r\n            color: black;\r\n        }\r\n    \r\n        body {\r\n            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\r\n            background: rgb(255,255,250);\r\n            margin: 10px;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Instrumento </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"black\"  >Buen día  Ingeniero: <a class=\"a\">{engineer}</a>  y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las siguientes caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Equino:</font></b>                                     <b><a class=\"a\">{equino}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Fecha De Devolucion:</font></b>                        <b><a class=\"a\">{dateOfReturn}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b><a class=\"a\">{enterprise}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b><a class=\"a\">{numberEnterprise}</a> </b>   <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de Devolucion:</font></b>                  <b><a class=\"a\">{observations}</a></b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            string equinosOfInstruments = String.Join(", ", equinos);
            
            body = body.Replace("{equino}", equinosOfInstruments);
            body = body.Replace("{dateOfReturn}", dates.convertToValidDate(DatePicker_DateOfReturn.Text));
            body = body.Replace("{enterprise}", instrumenAssignmentInformation.Rows[0]["Nombre_Empresa"].ToString());
            body = body.Replace("{numberEnterprise}", instrumenAssignmentInformation.Rows[0]["Folio_Empresa"].ToString());
            body = body.Replace("{observations}", TxtBox_ObservationReturn.Text);
            body = body.Replace("{engineer}", instrumenAssignmentInformation.Rows[0]["Ingeniero"].ToString());

            return body;
        }   

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            try
            {
                string equino = ComboBox_Instruments.SelectedItem.ToString();
                int index = ComboBox_Instruments.FindString(equino);
                ComboBox_Instruments.Items.RemoveAt(index);
                MessageBox.Show("Equino " + equino + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Equino");
            }
        }

       
    }
}
