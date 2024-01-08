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

            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Notificacion devolucion de Instrumento</title>\r\n    <style>\r\n        a {\r\n            color: black;\r\n        }\r\n    \r\n        body {\r\n            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\r\n            background: rgb(255,255,250);\r\n            margin: 10px;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Instrumento </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"black\"  >Buen día  Ingeniero: <a class=\"a\">{engineer}</a>  y responsable del area de  calidad se notifica que se ha devuelto el Instrumento con las siguientes caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Equino:</font></b>                                     <b><a class=\"a\">{equino}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Fecha De Devolucion:</font></b>                        <b><a class=\"a\">{DateOfReturn}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b><a class=\"a\">{enterprise}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b><a class=\"a\">{numberEnterprise}</a> </b>   <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de Devolucion:</font></b>                  <b><a class=\"a\">{observations}</a></b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            string equinosOfInstruments = String.Join(", ", equinoInstruments);

            body = body.Replace("{equino}", equinosOfInstruments);
            body = body.Replace("{DateOfReturn}", instrumentAssignments.DateOfReturn);
            body = body.Replace("{enterprise}", instrumentAssignments.NameEnterprise);
            body = body.Replace("{numberEnterprise}", instrumentAssignments.NumberEnterprise);
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
