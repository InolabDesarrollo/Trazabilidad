using CTZ.Controler.Estandard.Assignment;
using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using CTZ.TrazabilidadTestDataSet4TableAdapters;
using CTZ.View.Estandard;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_Return_Of_Estandard: C_Estandard_Assignment
    {

        public bool checkIfEstandardBelongsToEngineer(string nameEngineer, List<string> engineers)
        {
            bool belongToEnginner = true;
            if (engineers.Count >= 1)
            {
                if (engineers.Contains(nameEngineer))
                {
                    belongToEnginner = true;
                }
                else
                {
                    belongToEnginner = false;
                }
            }
            return belongToEnginner;
        }

        public void registerReturnOfEstandard(Estandard_Assignment assignment, List<string> estandards)
        {
            DateForReport date = new DateForReport();
            assignment.DateOfReturn = date.convertToValidDateDatePicker(assignment.DateOfReturn);

            foreach (string estandar in estandards)
            {
                assignmentRepository.registerReturnOfEstandard(assignment, estandar);
            }
            string emailBody = emailBodyForQuality(assignment, estandards);
            this.updateEstatusLoanEstandard("DISPONIBLE", estandards);
            sendNotification(assignment.EngineerEmail, emailBody);
        }

        private string emailBodyForQuality(Estandard_Assignment assignment, List<string> estEstandards)
        {
            DateForReport dates = new DateForReport();
            string body;
            body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Notificacion devolucion de Estándar</title>\r\n    <style>\r\n        a {\r\n            color: black;\r\n        }\r\n    \r\n        body {\r\n            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\r\n            background: rgb(255,255,250);\r\n            margin: 10px;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Estándar </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"black\"  >Buen día  Ingeniero <a class=\"a\">{engineer}</a>  y responsable del area de  calidad se notifica que se ha devuelto el estándar con las siguientes caracteristicas: </font><br />                   \r\n                    <b><font COLOR=\"blue\" >Estándar:</font></b>                                     <b><a class=\"a\">{estandard}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Fecha De Devolucion:</font></b>                        <b><a class=\"a\">{DateOfReturn}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de Devolucion:</font></b>                  <b><a class=\"a\">{observations}</a></b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            string estandards = String.Join(", ", estEstandards);
            body = body.Replace("{estandard}", estandards);
            body = body.Replace("{DateOfReturn}", assignment.DateOfReturn);
            body = body.Replace("{observations}", assignment.ReturnObservations);
            body = body.Replace("{engineer}", assignment.Engineer);

            return body;
        }

        private void sendNotification(string email, string emailBody)
        {
            string[] qualityEmail = new string[5];
            qualityEmail[0] = email;
            qualityEmail[1] = "omarflores@inolab.com";
            qualityEmail[2] = "calidad@inolab.com";
            qualityEmail[3] = "carlosflores@inolab.com";
            qualityEmail[4] = "azaliarosas@inolab.com";

            string emailSubject = "Notificacion de devolucion de Estándar";
            
            Notification notification = new Notification();
            notification.sendMailNotification(qualityEmail, emailBody, emailSubject);
        }

    }
}
