using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_RegistDeliveryInstrument: C_Instrument_Assignments
    {
        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments, List<string> instrumentList, List<string> instrumentsThatNeedCertificate)
        {
            instrumentAssignments.DateDelivery = dateForReport.convertToValidDate(instrumentAssignments.DateDelivery);
            instrumentAssignments.EstimateDateReturn = dateForReport.convertToValidDate(instrumentAssignments.EstimateDateReturn);

            foreach (string instrument  in instrumentList)
            {
                repository.registerDeliveryInstrument(instrumentAssignments, instrument);
                this.updateStatusInstrumentAssignment(instrument, "OCUPADO");
            }

            string body = emailBodyForEngineer(instrumentAssignments, instrumentList, instrumentsThatNeedCertificate);
            Notification notification = new Notification();
            notification.sendMailNotification(instrumentAssignments.EngineerEmail, body, "Notificacion entrega de Instrumento");
        }

        private string emailBodyForEngineer(Instrument_Assignments assignment, List<string> instrumentList, List<string> instrumentsThatNeedCertificate)
        {
            string nameEngineer = assignment.Engineer;
            string enterprise = assignment.NameEnterprise;
            string numberEnterprise = assignment.NumberEnterprise;
            string deliveryDate = assignment.DateDelivery;
            string equinoInstrument = String.Join(", ", instrumentList);
            string aproximateDateOfReturn = assignment.EstimateDateReturn;
            string deliveryObservation = assignment.DeliveryObservations;

            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            string certificateLink = serchCertificates(instrumentsThatNeedCertificate);

            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\\\"utf-8\"\\  />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\ >\r\n        <tr>\r\n            <td colspan= \\\"4\"\\ >\r\n                <p>\r\n                    <font COLOR= " + "'purple'" + " >Buen día estimado Ingeniero                         " + nameEngineer + "</font>  <br />\r\n                    Se le informa que se le han   asignado los Instrumentos  con las siguientes caracteristicas:  <br />\r\n <b><font COLOR= " + "'blue'" + "> Fecha De Entrega:</font></b>                          <b>" + deliveryDate.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Fecha registrada de devolucion:</font></b>            <b>" + aproximateDateOfReturn.Substring(0, 9) + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + " > Observaciones de Entrega:</font></b>                  <b>" + deliveryObservation + " </b>  <br />   <b> <font COLOR=\"blue\" >Link de certificados:</font></b>                  <b>" + certificateLink + "</b>  <br />                \r\n</p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            body = body.Replace("{engineer}", nameEngineer);
            body = body.Replace("{equinos}", equinoInstrument);
            body = body.Replace("{deliveryDate}", assignment.DateDelivery);
            body = body.Replace("{enterprise}", assignment.NameEnterprise);
            body = body.Replace("{numberEnterprise}", assignment.NumberEnterprise);
            body = body.Replace("{deliveryObservation}", assignment.DeliveryObservations);
            body = body.Replace("{certificateLink}", certificateLink);

            return body;
        }

        private string serchCertificates(List<string> instrumentsThatNeedCertificate)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            string certificates = "";
            foreach (string instrument in instrumentsThatNeedCertificate)
            {
                DataTable instrumentInformation = controler.getAllInstrumentCertificate(instrument);
                certificates = string.Join(",", instrumentInformation.Rows[0]["Link"].ToString());
            }
            return certificates;
        }

    }
}
