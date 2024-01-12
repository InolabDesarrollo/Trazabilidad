using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
namespace TestProyect
{
    
    public class TestEmail
    {
        [Test]
        public void send_Email_Test()
        {
            //Arrange 

            string emailSubject = "x test";
            MailMessage message = new MailMessage();
            message.From = new MailAddress("notificaciones@inolab.com");
            message.To.Add("omar.andreas.sotomayor@gmail.com");

            message.Bcc.Add("omarflores@inolab.com");
            message.Subject = emailSubject;
            message.Body = boydg();
            message.IsBodyHtml = true;
            //Acction 
            Email email = new Email("notificaciones@inolab.com", "Notificaciones2021*");
            email.send(message);

            //Assert
            Assert.IsTrue(message.IsBodyHtml);
        }

        private string boydg()
        {
            Estandard_Assignment assignment = new Estandard_Assignment();   

            string idStandar = "EST-TEST";
            assignment.Engineer = "Omar";
            assignment.DateDelivery = "01/12/2023";
            string enginner = assignment.Engineer;

            string body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Prestamo de Estándar </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero "+assignment.Engineer+"   y responsable del area de  calidad se notifica que se ha prestado el Estándar con las caracteristicas: " +
                " </font><br /><br>\r\n\r\n                    <b><font COLOR=\"blue\" >Est:</font></b>                                       <b> "+ idStandar + " </b> <br />\r\n                    " +
                " <b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                          <b> "+ assignment.DateDelivery+" </b> <br />\r\n                    " +
                " <b><font COLOR=\"blue\" >Fecha aproximada de devolucion:</font></b>            <b> "+ assignment.EstimateDateReturn+" </b> <br />\r\n                    " +
                " <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b> "+ assignment.NameEnterprise + " </b> <br />\r\n                    " +
                " <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b> "+ assignment.NumberEnterprise + " </b>  <br />\r\n                    " +
                " <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b> "+ assignment.DeliveryObservations + " </b>  <br />\r\n\r\n                    " +
                " <b><font COLOR=\"blue\" >Link de certificados:</font></b>                  <b> "+ assignment.linkOfCertificates + " </b>  <br />              \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            return body;
        }
    }
}
