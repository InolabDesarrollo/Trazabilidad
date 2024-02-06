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
            string equinoInstrument = String.Join(", ", instrumentList);
            string certificateLink = serchCertificates(instrumentsThatNeedCertificate);

            string body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Prestamo de Instrumento </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero: {engineer}   y responsable del area de  calidad se notifica que se ha prestado el Instrumento con las caracteristicas: </font><br /><br>                  \r\n                    <b><font COLOR=\"blue\" >Instrumentos: </font></b>                                     <b>{equinos} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                                 <b>{deliveryDate} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                          <b>{enterprise} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Numero de Empresa:</font></b>                                <b>{numberEnterprise} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                         <b>{deliveryObservation}</b>  <br />  \r\n                    <b><font COLOR=\"blue\" >Links de certificados:</font></b>                            <b>{certificateLink}</b>  <br />     \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            
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
                try
                {
                    DataTable instrumentInformation = controler.getAllInstrumentCertificate(instrument);
                    certificates = string.Join(",", instrumentInformation.Rows[0]["Link"].ToString());
                }catch 
                {
                    certificates = string.Join(",", "Instrumento "+instrument + " Sin certificado");
                }              
            }
            return certificates;
        }

        public bool checkIfInstrumentCertificateIsCloseToExpiring(string equino)
        {
            int daysForNextCertificateCalibration = calculateDaysForNextCalibration(equino);
            if (daysForNextCertificateCalibration < 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private int calculateDaysForNextCalibration(string equino)
        {
            int daysInCaseOfNotHavingAnAvailableDate = 20;
            View_Instrument_Certificate_Repository repository = new View_Instrument_Certificate_Repository();
            bool thereIsDateForNextCalibrationInCertificate = repository.checkIfThereIsDateForNextCalibrationInCertificate(equino);
            if (thereIsDateForNextCalibrationInCertificate)
            {
                DataTable instrumentCertificate = repository.getAllInstrumentCertificateActives(equino);
                DateTime todayDate = DateTime.Today;
                DateTime nextCalibrationDate = Convert.ToDateTime(instrumentCertificate.Rows[0]["Proxima_Calibracion"].ToString());

                int dayDiference = getDayDiference(nextCalibrationDate, todayDate);
                return dayDiference;
            }
            else
            {
                return daysInCaseOfNotHavingAnAvailableDate;
            }
        }

        private int getDayDiference(DateTime beganDate, DateTime finalDate)
        {
            int dayDiference = (finalDate - beganDate).Days;
            return dayDiference;
        }

    }
}
