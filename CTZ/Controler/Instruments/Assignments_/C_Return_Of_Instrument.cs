using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_Return_Of_Instrument : C_Instrument_Assignments
    {
        public void registerReturnInstrument(Instrument_Assignments instrumentAssignments, List<string> equinoInstruments)
        {
            instrumentAssignments.DateOfReturn = dateForReport.convertToValidDate(instrumentAssignments.DateOfReturn);
            foreach (string equino in equinoInstruments)
            {
                repository.registerReturnInstrument(instrumentAssignments, equino);
            }
            updateStatusInstruments(equinoInstruments);
            string emailBody = emailBodyForQuality(instrumentAssignments, equinoInstruments);
            sendQualityMailNotification(instrumentAssignments.EngineerEmail, emailBody);
        }

        private void updateStatusInstruments(List<string> equinoInstruments)
        {
            foreach (string equino in equinoInstruments)
            {
                this.updateStatusInstrumentAssignment(equino, "DISPONIBLE");
            }
        }

        private string emailBodyForQuality(Instrument_Assignments instrumentAssignments, List<string> equinoInstruments)
        {

            string body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Devolución de Instrumento </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero: {engineer}   y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las caracteristicas: </font><br /><br>                  \r\n                    <b><font COLOR=\"blue\" >Instrumento: </font></b>                                     <b>{equino} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de devolución</font></b>                               <b>{DateOfReturn} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones:</font></b>                                    <b>{observations}</b>  <br />             \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            string equinosOfInstruments = String.Join(", ", equinoInstruments);

            body = body.Replace("{equino}", equinosOfInstruments);
            body = body.Replace("{DateOfReturn}", instrumentAssignments.DateOfReturn);
            body = body.Replace("{observations}", instrumentAssignments.ReturnObservations);
            body = body.Replace("{engineer}", instrumentAssignments.Engineer);

            return body;
        }

        private void sendQualityMailNotification(string emailEngineer, string emailBody)
        {
            string[] qualityEmail = new string[5];
            qualityEmail[0] = emailEngineer;
            qualityEmail[1] = "omarflores@inolab.com";
            qualityEmail[2] = "calidad@inolab.com";
            qualityEmail[3] = "carlosflores@inolab.com";
            qualityEmail[4] = "azaliarosas@inolab.com";

            string emailSubject = "Notificacion de devolucion de Instrumento";
            Vista.Responsabilitis.Notification notification = new Vista.Responsabilitis.Notification();
            notification.sendMailNotification(qualityEmail, emailBody, emailSubject);
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(int idInstrument)
        {
            return repository.selectMoreRecentInformationInstrumenAssignment(idInstrument);
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(string equinoInstrument)
        {
            return repository.selectMoreRecentInformationInstrumenAssignment(equinoInstrument);
        }
    }

}
