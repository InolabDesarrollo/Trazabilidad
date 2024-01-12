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
            body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Prestamo de Estándar </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero {engineer}   y responsable del area de  calidad se notifica que se ha devuelto el Estándar con las caracteristicas: </font><br /><br>\r\n\r\n                    <b><font COLOR=\"blue\" >Estándar:</font></b>                                     <b>{estandard} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de devolución:</font></b>                          <b>{DateOfReturn} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones</font></b>                                 <b>{observations}</b>  <br />\r\n           \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

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
