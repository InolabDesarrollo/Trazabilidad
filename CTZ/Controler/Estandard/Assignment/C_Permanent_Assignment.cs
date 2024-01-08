using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard.Assignment
{
    public class C_Permanent_Assignment: C_Estandard_Assignment
    {

        public void registerPermanentlyDeliveryEstandard(Estandard_Assignment assignment, string estandard)
        {
            DateForReport dates = new DateForReport();
            assignment.DateDelivery = dates.convertToValidDateDatePicker(assignment.DateDelivery);
            assignmentRepository.registerPermanentlyDeliveryEstandard(assignment, estandard);

            string emailBody = bodyEmailEngineer(assignment, estandard);
            Notification notification = new Notification();
            notification.sendMailNotification(assignment.EngineerEmail, emailBody, "Asignacion permanente de estándar");
        }

        private string bodyEmailEngineer(Estandard_Assignment assignment, string estandard)
        {
            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Asignación de Estándar </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"center\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero: {engineer}   y responsable del area de  calidad se notifica que se ha entregado el Estándar con las caracteristicas: </font><br /><br>                  \r\n                    <b><font COLOR=\"blue\" >Estándar:</font></b>                                     <b>{estEstandard} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                        <b>{dateOfDelivery} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>{deliveryObservation}</b>  <br />               \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            body = body.Replace("{engineer}", assignment.Engineer);
            body = body.Replace("{estEstandard}", estandard);
            body = body.Replace("{dateOfDelivery}", assignment.DateDelivery);
            body = body.Replace("{deliveryObservation}", assignment.DeliveryObservations);

            return body;
        }
    }
}
