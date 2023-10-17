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
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
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
        private readonly string typeOfSignature;
        private  string emailEngineer;

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
            Image signature = new Bitmap(Pnl_Signature.Width, Pnl_Signature.Height);
            var graphic = Graphics.FromImage(signature);
            var rectangle = Pnl_Signature.RectangleToScreen(Pnl_Signature.ClientRectangle);

            graphic.CopyFromScreen(rectangle.Location, Point.Empty, Pnl_Signature.Size);
            signature.Save("Firma.jpg", ImageFormat.Jpeg);

            if(typeOfSignature.Equals("Engineer"))
            {
                registEngineerSignature(signature);

            }else if (typeOfSignature.Equals("Quality"))
            {
                registQualitySignature(signature);
            }                      
        }
        
        private void registEngineerSignature(Image engineerSignature)
        {
            controler.updateSignatureEngineer(idInstrument, engineerSignature);
            MessageBox.Show("Firma de ingeniero agregada correctamente");
            sendEngineerEmailNotification(emailEngineer);
            this.Close();
        }

        private void sendEngineerEmailNotification(string emailRecipient)
        {
            string emailSubject = "Notificacion entrega de Instrumento";
            MailAddress emailSender = new MailAddress("notificaciones@inolab.com");
            MailAddress mailRecipient = new MailAddress(emailRecipient);
            MailMessage message = new MailMessage(emailSender,mailRecipient);

            message.Bcc.Add("omarflores@inolab.com");
            message.Subject = emailSubject;
            message.IsBodyHtml = false;
            message.Body = emailBodyForEngineer();

            Email email = new Email("notificaciones@inolab.com", "Notificaciones2021*");
            email.send(message);
        }

        private string emailBodyForEngineer()
        {
            string body = "Se le notifica la entrega de Instrumento con Equino: " + equinoInstrument + ", \n" +
                " La fecha estimada de devolucion es " + instrumentAssignmentsInformation.Rows[0]["Fecha_Estimada_Devolucion"].ToString() + " " +
                "\nLa Empresa receptora de servicio es '" + instrumentAssignmentsInformation.Rows[0]["Nombre_Empresa"].ToString() + "' " +
                "\n Las observaciones de la entrega son '" + instrumentAssignmentsInformation.Rows[0]["Observaciones_Entrega"].ToString()+"' " +
                "\nSaludos. ";
            return body;
        }

        private void registQualitySignature(Image qualitySignature)
        {
            controler.updateSignatureQuality(idInstrument, qualitySignature);
            MessageBox.Show("Firma de calidad agregada correctamente");
            sendQualityMailNotification("omar.andreas.sotomayor@gmail.com");
            this.Close();
        }

        private void sendQualityMailNotification(string emailRecipient)
        {
            string emailSubject = "Notificacion de devolucion de Instrumento";
            MailAddress emailSender = new MailAddress("notificaciones@inolab.com");
            MailAddress mailRecipient = new MailAddress(emailRecipient);
            MailMessage message = new MailMessage(emailSender, mailRecipient);

            message.Bcc.Add(emailEngineer);
            message.Subject = emailSubject;
            message.IsBodyHtml = false;
            message.Body = emailBodyForQuality();

            Email email = new Email("notificaciones@inolab.com", "Notificaciones2021*");
            email.send(message);
        }

        private string emailBodyForQuality()
        {
            string body = "Se notifica la devolucion de instrumento con Equino: " + equinoInstrument + ". " +
                "\n Registrado para servicio a la Empresa " + instrumentAssignmentsInformation.Rows[0]["Nombre_Empresa"].ToString() + ". " +
                "\n Devuelto a la fecha  " + DateTime.Today + ". " +
                "\n Las observaciones de calidad son: '" + instrumentAssignmentsInformation.Rows[0]["Observaciones_Devolucion"].ToString() + "'.";
            return body;
        }
    }
}
