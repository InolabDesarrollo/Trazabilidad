using CTZ.Controler.Estandard.Assignment;
using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_Loan_Estandard : C_Estandard_Assignment
    {

        public void registerDeliveryEstandard(Estandard_Assignment assignment,List<string> estEstandards)
        {
            DateForReport dates = new DateForReport();
            assignment.DateDelivery = dates.convertToValidDateDatePicker(assignment.DateDelivery);
            assignment.EstimateDateReturn = dates.convertToValidDateDatePicker(assignment.EstimateDateReturn);
            assignment.type = "Prestamo";

            foreach (string estandar in estEstandards)
            {
                assignmentRepository.registerDeliveryEstandard(assignment, estandar);
            }
            this.updateEstatusLoanEstandard("PRESTADO", estEstandards);
            assignment.linkOfCertificates = getLinkOfCertificates(estEstandards);

            string emailBody = bodyEmail(assignment, estEstandards);
            Notification notification = new Notification();
            notification.sendMailNotification(assignment.EngineerEmail, emailBody, "Prestamo de estándar");
        }

        private string getLinkOfCertificates(List<string> standards)
        {
            CertificateEstandard certificate = new CertificateEstandard();
            string linkCertificate = certificate.getCertificates(standards);
            return linkCertificate;
        }

        private string bodyEmail(Estandard_Assignment assignment, List<string> standarList)
        {
            string idStandar = string.Join(", ", standarList);

            string body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <th valign=\"top\" align=\"left\" colspan=\"3\">\r\n            <img src=\"http://www.inolab.com/images/logoInolab.jpg\"><br><br>\r\n        </th>\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <h2>Prestamo de Estándar </h2>\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero {engineer}   y responsable del area de  calidad se notifica que se ha prestado el Estándar con las caracteristicas: </font><br /><br>\r\n\r\n                    <b><font COLOR=\"blue\" >Est:</font></b>                                       <b>{estEstandard} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                          <b>{dateOfDelivery} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha aproximada de devolucion:</font></b>            <b>{aproximateDateOfReturn}</b> <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b>{enterprise} </b> <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b>{numberEnterprise} </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>{deliveryObservation}</b>  <br />\r\n\r\n                    <b><font COLOR=\"blue\" >Link de certificados:</font></b>                  <b>{link}</b>  <br />              \r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            body.Replace("{engineer}", assignment.Engineer);
            body.Replace("{estEstandard}", idStandar);
            body.Replace("{dateOfDelivery}", assignment.DateDelivery);
            body.Replace("{aproximateDateOfReturn}", assignment.EstimateDateReturn);
            body.Replace("{enterprise}", assignment.NameEnterprise);
            body.Replace("{numberEnterprise}", assignment.NumberEnterprise);
            body.Replace("{deliveryObservation}", assignment.DeliveryObservations);
            body.Replace("{link}", assignment.linkOfCertificates);

            return body;
        }

    }
}
