using CTZ.Modelo.Trazabilidad;
using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_Certificate
    {
        CTZ.Model.Trazabilidad.Estandard.Certificate_Repository repository;
        public C_Certificate() {
            repository = new Model.Trazabilidad.Estandard.Certificate_Repository(); 
        }

        public string selectCurrentCertificate(int idEstandard)
        {
            return repository.selectCurrentCertificate(idEstandard);
        }

        public void createCertificate(CertificateEstandard certificate)
        {
            DateForReport dates = new DateForReport();
            certificate.ExpirationDate =  dates.convertToValidDate(certificate.ExpirationDate);
            certificate.RegisterDate= dates.convertToValidDate(certificate.RegisterDate);

            repository.createCertificate(certificate);
        }

        public void updateStatusCertificates(int idEstandard)
        {
            repository.updateStatusCertificates(idEstandard);
        }


    }
}
