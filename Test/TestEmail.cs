using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CTZ.Vista.Responsabilitis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestEmail
    {
        [TestMethod]
        public void send_Email_Test()
        {
            //Arrange 
           
           string emailSubject = "Notificacion entrega de Instrumento";
           MailMessage message = new MailMessage();
           message.From = new MailAddress("notificaciones@inolab.com");
           message.To.Add("omar.andreas.sotomayor@gmail.com");

           message.Bcc.Add("omarflores@inolab.com");
           message.Subject = emailSubject;
           message.Body = "Test body";
           message.IsBodyHtml = true;
            //Acction 
            Email email = new Email("notificaciones@inolab.com", "Notificaciones2021*");
            email.send(message);

            //Assert
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.IsTrue(message.IsBodyHtml);
        }
    }
}
