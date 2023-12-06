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
            string certificateLink = "https://inolabespecialistasdeservicio.box.com/s/ht1qz2b9hi963wcu5zkjrtpcienuft0d";
            string numberEnterprise = "1";
            string enterprise = "Bitso";
            string deliveryDate = "07/12/1996";
            string aproximateDateOfReturn = "09/12/1996";
            string deliveryObservation = "test";
            string equinoInstrument = "EQ-INO-020";
            string nameEngineer = "Omar Flores";
            string bodyMailEngineer = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\\\"utf-8\"\\  />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\ >\r\n        <tr>\r\n            <td colspan= \\\"4\"\\ >\r\n                <p>\r\n                    <font COLOR= " + "'purple'" + "   >Buen día estimado Ingeniero                         " + nameEngineer + " \r\n                    Se le informa que se le ha   asignado el Instrumento con las siguientes caracteristicas:    </font>  <br />\r\n                    <font COLOR= " + "'blue'" + "  > Equino:</font>                                   <b>" + equinoInstrument + "  </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "  > Fecha De Entrega:</font></b>                          <b>" + deliveryDate.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Fecha registrada de devolucion:</font></b>            <b>" + aproximateDateOfReturn.Substring(0, 10) + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + " > Observaciones de Entrega:</font></b>                  <b>" + deliveryObservation + " </b>  <br /> \r\n                </p><br /><b><font COLOR=\"blue\" >Link del certificado:</font></b>                  <b> " + certificateLink + "</b>  <br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            
            //Acction
            notification.sendMailNotification(emails,bodyMailEngineer,subject);

            //Assert
            Assert.AreEqual(subject, "Test Notificacion calidad");
        }

    }
}
