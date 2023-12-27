using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProyect
{
    public class TestNotificationQuality
    {

        [Test]
        public void sendMailNotificationQualityTest()
        {
            //Arrange
            string[] qualityEmail = new string[2];
            qualityEmail[0] = "omar.andreas.sotomayor@gmail.com";
            qualityEmail[1] = "omarflores@inolab.com";
            string emailSubject = "Notificacion de devolucion de Instrumento";
            string emailBody = emailBodyForQuality();
            //Action
            Notification notification = new Notification();
            notification.sendMailNotification(qualityEmail,  emailBody, emailSubject);
            //Assert
            Assert.AreEqual(emailSubject, "Notificacion de devolucion de Instrumento");

        }

        private string emailBodyForQuality()
        {
            DateForReport dates = new DateForReport();
            string body;
            body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Notificacion devolucion de Instrumento</title>\r\n    <style>\r\n        a {\r\n            color: black;\r\n        }\r\n    \r\n        body {\r\n            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\r\n            background: rgb(255,255,250);\r\n            margin: 10px;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Instrumento </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"black\"  >Buen día  Ingeniero: <a class=\"a\">{engineer}</a>  y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las siguientes caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Equino:</font></b>                                     <b><a class=\"a\">{equino}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Fecha De Devolucion:</font></b>                        <b><a class=\"a\">{dateOfReturn}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b><a class=\"a\">{enterprise}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b><a class=\"a\">{numberEnterprise}</a> </b>   <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de Devolucion:</font></b>                  <b><a class=\"a\">{observations}</a></b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            string equinos = equinosOfInstruments();
            body = body.Replace("{equino}", equinos);
            body = body.Replace("{dateOfReturn}", "2023/12/28");
            body = body.Replace("{enterprise}", "KAVAK 4");
            body = body.Replace("{numberEnterprise}", "1");
            body = body.Replace("{observations}", "Test");
            body = body.Replace("{engineer}", "Omar Sotomayor");

            return body;
        }

        private string equinosOfInstruments()
        {
            List<string> equinos = new List<string>();
            equinos.Add("EQ-INO-019");
            equinos.Add("EQ-INO-20");

            string equinoInstruments = "";
            equinoInstruments = String.Join(", ", equinos);

            return equinoInstruments;
        }


    }
}
