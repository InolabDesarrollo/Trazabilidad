using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public class Email
    {
        SmtpClient smtpClient = new SmtpClient();
        public Email(string senderEmail, string emailPassword)
        {
            smtpClient.Host = "smtp.inolab.com";
            smtpClient.EnableSsl = false;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Port = 1025;
            smtpClient.Credentials = new NetworkCredential(senderEmail, emailPassword);
        }

        public void send(System.Net.Mail.MailMessage mensaje)
        {
            smtpClient.Send(mensaje);
            mensaje.Dispose();
            smtpClient.Dispose();
        }
    }
}
