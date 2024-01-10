using CTZ.Controlador;
using CTZ.Modelo;
using CTZ.Modelo.Browser;
using CTZ.Modelo.Trazabilidad;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_Permanent_Assignment_Instrument: C_Instrument_Assignments
    {
        public void registerPermantlyAssingmentInstrument(Instrument_Assignments assignments)
        {
            DateForReport dates = new DateForReport();
            assignments.DateDelivery = dates.convertToValidDateDatePicker(assignments.DateDelivery);

            this.repository.registerPermantlyAssingmentInstrument(assignments);
            this.updateStatusInstrumentAssignment(assignments.equinoInstrument, "ASIGNADO");

            string body = emailBody(assignments);
            Notification notification = new Notification();
            notification.sendMailNotification(assignments.EngineerEmail, body, "Asignación permanente de Instrumento ");
        }

        private string emailBody(Instrument_Assignments assignment)
        {
            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Asignación de Instrumento </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero: {engineer}   y responsable del area de  calidad se notifica que se ha asignado el Instrumento con las caracteristicas: </font><br /><br>                  \r\n                    <b><font COLOR=\"blue\" >Instrumento: </font></b>                                     <b>{instrument} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                        <b>{dateOfDelivery} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>{deliveryObservation}</b>  <br />               \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            body = body.Replace("{engineer}", assignment.Engineer);
            body = body.Replace("{instrument}", assignment.equinoInstrument);
            body = body.Replace("{dateOfDelivery}", assignment.DateDelivery);
            body = body.Replace("{deliveryObservation}", assignment.DeliveryObservations);
            
            return body;
        }

    }
}
