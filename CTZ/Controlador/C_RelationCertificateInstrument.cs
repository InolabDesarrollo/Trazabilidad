using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_RelationCertificateInstrument
    {
        RelationCertificateInstrument_Repository repository;
        public C_RelationCertificateInstrument() { 
            repository = new RelationCertificateInstrument_Repository();
        }

        public bool create(int idInstrument, int idCertificate)
        {
            return repository.create(idInstrument,idCertificate);
        }

    }
}
