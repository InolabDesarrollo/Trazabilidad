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

        private string bodyEmail(Estandard_Assignment assignment, List<string> estEstandards)
        {
            string idOfEstandards = string.Join(", ", estEstandards);

            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Estándar </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        " +
                "<tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero  " + assignment.Engineer.ToString() + " y responsable del area de  calidad se notifica que se ha entregado el Estándar con las caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Est:</font></b>                                     <b>" + idOfEstandards + " </b> <br />\r\n                    " +
                "<b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                        <b>" + assignment.DateDelivery + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha aproximada de devolucion:</font></b>            <b>" + assignment.EstimateDateReturn + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b>" + assignment.NameEnterprise + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b>" + assignment.NumberEnterprise + " </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>" + assignment.DeliveryObservations + "</b>  <br />\r\n\r\n                    <b>" +
                "<font COLOR=\"blue\" >Link del certificado:</font></b>                  <b>" + assignment.linkOfCertificates + "</b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            return body;
        }

    }
}
