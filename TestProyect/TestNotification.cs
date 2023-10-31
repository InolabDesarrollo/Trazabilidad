using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProyect
{
    
    public  class TestNotification
    {
        [Test]
        public void sendMailNotificationTest()
        {
            //Arrange 
            Notification notification = new Notification();
            string[] emails = new string[3];
            emails[0] = "omar.andreas.sotomayor@gmail.com";
            emails[1] = "omarsotomayordevelop@gmail.com";
            emails[2] = "omarflores@inolab.com";
            string subject = "Test Notificacion calidad";
            string body = "Body mail";

            //Acction
            notification.sendMailNotification(emails, subject, body);

            //Assert
            Assert.AreEqual(body, "Body mail");
            
        }
    }
}
