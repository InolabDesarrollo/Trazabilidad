using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Interfaces
{
    public interface IRelationCertificateInstrument_Repository
    {
        bool create(int idInstrument, int idCertificate);

        DataTable getAllCertificatesForInstrument(int idSqlInstrument);

        void deleteRelation(int idSqlInstrument, int idCertificate);
    }
}
