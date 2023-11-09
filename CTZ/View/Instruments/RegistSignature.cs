using CTZ.Controlador;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class RegistSignature : Form
    {
        float pointX = 0;
        float pointY = 0;
        float lastX = 0;
        float lastY = 0;

        private readonly int idInstrument;
        private readonly string equinoInstrument;
        private readonly Dictionary<int, string> informationId_Equino;
        private readonly List<int> idInstruments;
        private readonly string typeOfSignature;
        private  string emailEngineer;
        Image imageSignature;
        Notification notification = new Notification();

        C_Instrument_Assignments controler;
        private DataTable instrumentAssignmentsInformation;
        public RegistSignature(int idInstrument, string equinoInstrument, string typeOfSignature,string emailEngineer)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;

            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(idInstrument);
        }

        public RegistSignature(Dictionary<int, string> informationId_Equino,string typeOfSignature, string emailEngineer)
        {
            InitializeComponent();
            this.informationId_Equino = informationId_Equino;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;
            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(informationId_Equino.Keys.First());
        }

        public RegistSignature(List<int> idInstruments, string typeOfSignature, string emailEngineer)
        {
            InitializeComponent();
            this.idInstruments = idInstruments;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;
            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(Convert.ToInt32(idInstruments[0].ToString()));
        }

        private void Pnl_Signature_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics= Pnl_Signature.CreateGraphics();
            graphics.DrawLine(Pens.Black, pointX, pointY, lastX, lastY);
            lastX = pointX;
            lastY = pointY;
        }
        private void Pnl_Signature_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
        }

        private void Pnl_Signature_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                Pnl_Signature_Paint(this,null);
            }
        }

        private void Btn_Save_Signature_Click(object sender, EventArgs e)
        {
            imageSignature = new Bitmap(Pnl_Signature.Width, Pnl_Signature.Height);
            var graphic = Graphics.FromImage(imageSignature);
            var rectangle = Pnl_Signature.RectangleToScreen(Pnl_Signature.ClientRectangle);

            graphic.CopyFromScreen(rectangle.Location, System.Drawing.Point.Empty, Pnl_Signature.Size);
            imageSignature.Save("Firma.jpg", ImageFormat.Jpeg);

            Signature signature = new Signature();
           
            if(typeOfSignature.Equals("Engineer"))
            {
                signature.registEngineerSignature(imageSignature, idInstrument);
                sendEngineerNotification();
            }
            else if (typeOfSignature.Equals("Quality"))
            {
                signature.registQualitySignature(imageSignature, idInstrument);
                sendQualityMailNotification();
            }
            else if (typeOfSignature.Equals("EngineerByGroup"))
            {
                signature.registEngineerSignatureByGroup(imageSignature, informationId_Equino);
                sendEngineerNotification();
            }
            else if (typeOfSignature.Equals("QualityByGroup"))
            {
                signature.registQualitySignatureByGroup(imageSignature, idInstruments);
                sendQualityMailNotification();
            }
            System.Windows.MessageBox.Show("Firma agregada correctamente");
            this.Close();
        }
        private void sendEngineerNotification()
        {
            string emailBody = emailBodyForEngineer();
            string emailSubject = "Notificacion entrega de Instrumento";
            notification.sendMailNotification(emailEngineer, emailBody, emailSubject);
        }

        private string emailBodyForEngineer()
        {
            string body = "";
            string nameEngineer = instrumentAssignmentsInformation.Rows[0]["Ingeniero"].ToString();
            string enterprise = instrumentAssignmentsInformation.Rows[0]["Nombre_Empresa"].ToString();
            string numberEnterprise = instrumentAssignmentsInformation.Rows[0]["Folio_Empresa"].ToString();
            string deliveryDate = instrumentAssignmentsInformation.Rows[0]["Fecha_Entrega"].ToString();
            string equinoInstrument = instrumentAssignmentsInformation.Rows[0]["Equino_Instrumento"].ToString();
            string aproximateDateOfReturn = instrumentAssignmentsInformation.Rows[0]["Fecha_Estimada_Devolucion"].ToString();
            string deliveryObservation = instrumentAssignmentsInformation.Rows[0]["Observaciones_Entrega"].ToString();

            if (typeOfSignature.Equals("Engineer"))
            {
                body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\\\"utf-8\"\\  />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\ >\r\n        <tr>\r\n            <td colspan= \\\"4\"\\ >\r\n                <p>\r\n                    <font COLOR= " + "'purple'" + "   >Buen día estimado Ingeniero                         " + nameEngineer + " \r\n                    Se le informa que se le ha   asignado el Instrumento con las siguientes caracteristicas:    </font>  <br />\r\n                    <font COLOR= " + "'blue'" + "  > Equino:</font>                                   <b>" + equinoInstrument + "  </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "  > Fecha De Entrega:</font></b>                          <b>" + deliveryDate.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Fecha registrada de devolucion:</font></b>            <b>" + aproximateDateOfReturn.Substring(0,10) + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + " > Observaciones de Entrega:</font></b>                  <b>" + deliveryObservation + " </b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            }
            if (typeOfSignature.Equals("EngineerByGroup"))
            {
                body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\\\"utf-8\"\\  />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\ >\r\n        <tr>\r\n            <td colspan= \\\"4\"\\ >\r\n                <p>\r\n                    <font COLOR= " + "'purple'" + " >Buen día estimado Ingeniero                         " + nameEngineer + "</font>  <br />\r\n                    Se le informa que se le ha   asignado el Instrumento con las siguientes caracteristicas:  <br />\r\n <b><font COLOR= " + "'blue'" + "> Fecha De Entrega:</font></b>                          <b>" + deliveryDate.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Fecha registrada de devolucion:</font></b>            <b>" + aproximateDateOfReturn.Substring(0,9) + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + " > Observaciones de Entrega:</font></b>                  <b>" + deliveryObservation + " </b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            }
            return body;
        }

        private void sendQualityMailNotification()
        {
            string[] qualityEmail = new string[3];
            qualityEmail[0] = emailEngineer;
            qualityEmail[1] = "omarflores@inolab.com";
            qualityEmail[2] = "calidad@inolab.com";

            string emailSubject = "Notificacion de devolucion de Instrumento";
            string emailBody = emailBodyForQuality();
            notification.sendMailNotification(qualityEmail, emailBody, emailSubject);
        }

        private string emailBodyForQuality()
        {
            string body = "";
            string equinoInstrument = instrumentAssignmentsInformation.Rows[0]["Equino_Instrumento"].ToString();
            string dateOfReturn = instrumentAssignmentsInformation.Rows[0]["Fecha_Devolucion"].ToString();
            string returnObservation = instrumentAssignmentsInformation.Rows[0]["Observaciones_Devolucion"].ToString();
            string enterprise = instrumentAssignmentsInformation.Rows[0]["Nombre_Empresa"].ToString();
            string numberEnterprise = instrumentAssignmentsInformation.Rows[0]["Folio_Empresa"].ToString();
            string nameEngineer = instrumentAssignmentsInformation.Rows[0]["Ingeniero"].ToString();

            if (typeOfSignature.Equals("Quality"))
            {
                body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\>\r\n        <tr>\r\n            <td colspan=\\\"4\"\\ >\r\n                <p  >\r\n                    <font COLOR=" + "'purple'" + "  >Buen día  Ingeniero " + nameEngineer + "  y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las siguientes caracteristicas</font><br /> \r\n                  \r\n                    <b><font COLOR=" + "'blue'" + " >Equino:</font></b>                                     <b>" + equinoInstrument + " </b> <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Fecha De Devolucion:</font></b>                        <b>" + dateOfReturn.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Observaciones de Devolucion:</font></b>                  <b>" + returnObservation + "</b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            }
            if (typeOfSignature.Equals("QualityByGroup"))
            {
                body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\>\r\n        <tr>\r\n            <td colspan=\\\"4\"\\ >\r\n                <p  >\r\n                    <font COLOR=" + "'purple'" + "  >Buen día  Ingeniero " + nameEngineer + "  y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las siguientes caracteristicas</font><br /> \r\n                  <b><font COLOR=" + "'blue'" + " >Fecha De Devolucion:</font></b>                        <b>" + dateOfReturn.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR=" + "'blue'" + " >Observaciones de Devolucion:</font></b>                  <b>" + returnObservation + "</b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            }
            
            return body;
        }
    }
}
