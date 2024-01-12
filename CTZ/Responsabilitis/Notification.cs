using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public class Notification
    {  
        Email email;
        public Notification() {
            email = new Email("notificaciones@inolab.com", "Notificaciones2021*");
        }

        public void sendMailNotification(string emailRecipient, string emailBody, string emailSubject)
        {
            MailAddress emailSender = new MailAddress("notificaciones@inolab.com");
            MailAddress mailRecipient = new MailAddress(emailRecipient);
            MailMessage message = new MailMessage(emailSender, mailRecipient);

            message.To.Add(mailRecipient);
            message.Bcc.Add("omarflores@inolab.com, azaliarosas@inolab.com");

            message.Subject = emailSubject;
            message.IsBodyHtml = true;
            message.Body = emailBody;

            email.send(message);
        }

        public void sendMailNotification(string[] emailRecipient, string emailBody, string emailSubject)
        {
            MailAddress emailSender = new MailAddress("notificaciones@inolab.com");
            List<string> emailList = new List<string>();
            var emailsToCopy ="";
            for (int i =1; i<emailRecipient.Length; i++)
            {
                emailList.Add(emailRecipient[i].ToString());
            }
            emailsToCopy = String.Join(", ", emailList);
            MailAddress mailRecipient = new MailAddress(emailRecipient[0].ToString());
            MailMessage message = new MailMessage(emailSender, mailRecipient);

            message.To.Add(mailRecipient);
            message.Bcc.Add(emailsToCopy);
            message.Subject = emailSubject;
            message.IsBodyHtml = true;
            message.Body = emailBody;
            email.send(message);
        }

    }
}
