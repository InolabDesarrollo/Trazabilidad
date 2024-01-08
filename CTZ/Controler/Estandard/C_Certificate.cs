using CTZ.Modelo.Trazabilidad;
using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.Data;
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
            certificate.ExpirationDate =  dates.convertToValidDateDatePicker(certificate.ExpirationDate);
            certificate.RegisterDate= dates.convertToValidDateDatePicker(certificate.RegisterDate);

            repository.createCertificate(certificate);
        }

        public void updateStatusCertificates(string Estandard)
        {
            repository.updateStatusCertificates(Estandard);
        }

        public string getLinkCertificate(string Estandard)
        {
            return repository.getLinkCertificate(Estandard);
        }

    }
}
