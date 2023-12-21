using CTZ.Controler.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CTZ.View.Estandard.Assignment
{
    public partial class RegistSignature : Form
    {
        private float pointX = 0;
        private float pointY = 0;
        private float lastX = 0;
        private float lastY = 0;
        Image imageSignature;
        public string signatureBase64;
        private readonly Estandard_Assignment assignment;
        private readonly Dictionary<int, string> estandardInformation;

        public RegistSignature(Estandard_Assignment assignment,Dictionary<int,string> estandardInformation)
        {
            InitializeComponent();
            this.assignment = assignment;
            this.estandardInformation = estandardInformation;
        }

        private void Pnl_Signature_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Pnl_Signature.CreateGraphics();
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
                Pnl_Signature_Paint(this, null);
            }
        }

        private void Btn_Save_Signature_Click(object sender, EventArgs e)
        {
            CTZ.View.Responsabilitis.Signature signature = new Responsabilitis.Signature();         
            assignment.EngineerSignature= signature.createStringOfSignature(Pnl_Signature);

            C_DeliveryOfEstandard controler = new C_DeliveryOfEstandard();
            controler.registerDeliveryEstandard(assignment, estandardInformation);
            sendNotification();
            MessageBox.Show("Se creo la asignacion para los estandares ");
            this.Close();
        }

        private void sendNotification()
        {
            Notification notification = new Notification();
            string bodyMail = bodyEmailEngineer();
            notification.sendMailNotification("calidad@inolab.com", bodyMail, "Test Estandares");
        }

        private string bodyEmailEngineer()
        {
            string idOfEstandards = string.Join(", ", estandardInformation.Values);

            string linkCertificate = getCertificates(estandardInformation);
            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Estandard </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        " +
                "<tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero:   y responsable del area de  calidad se notifica que se ha entregado el Estandard con las caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Est:</font></b>                                     <b>"+idOfEstandards+" </b> <br />\r\n                    " +
                "<b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                        <b>"+assignment.DateDelivery+" </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha aproximada de devolucion:</font></b>            <b>"+assignment.EstimateDateReturn+" </b> <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b>"+assignment.NameEnterprise+" </b> <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b>"+assignment.NumberEnterprise+" </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>"+assignment.DeliveryObservations+"</b>  <br />\r\n\r\n                    <b>" +
                "<font COLOR=\"blue\" >Link del certificado:</font></b>                  <b>"+ linkCertificate + "</b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            return body;

        }

        private string getCertificates(Dictionary<int, string> estandardInformation)
        {
            C_Certificate controler = new C_Certificate();
            string certificate;
            string linksCertificates = "";
            foreach (int idEstandard in estandardInformation.Keys)
            {
                certificate= controler.selectCurrentCertificate(idEstandard);
                linksCertificates= string.Join(", ", certificate);
            }

            return linksCertificates;
        }
 
    }
}
