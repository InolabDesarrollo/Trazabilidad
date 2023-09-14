using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable getAllCertificatesForInstrument(int idSqlInstrument)
        {
            return repository.getAllCertificatesForInstrument(idSqlInstrument);
        }

        public void deleteRelation(int idSqlInstrument, int idCertificate)
        {
            repository.deleteRelation(idSqlInstrument,idCertificate);
        }


    }
}
