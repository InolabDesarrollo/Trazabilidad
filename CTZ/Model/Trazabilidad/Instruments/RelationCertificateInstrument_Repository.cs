using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class RelationCertificateInstrument_Repository
    {
        ConexionTrazability conexion;
        public RelationCertificateInstrument_Repository() {
            conexion = new ConexionTrazability();
        }

        public bool create(int idInstrument, int idCertificate)
        {
            return conexion.executeQuery("INSERT AsignacionesCertificado(ID_Instrumento,Id_Certificado) " +
                " \r\n values("+idInstrument+","+ idCertificate +");");
        }

        public DataTable getAllCertificatesForInstrument(int idSqlInstrument)
        {
             return conexion.getDataTable("SELECT * FROM AsignacionesCertificado WHERE Id_Instrumento = " + idSqlInstrument + ";");
        }

        public void deleteRelation(int idSqlInstrument, int idCertificate)
        {
            conexion.executeQuery("DELETE FROM AsignacionesCertificado WHERE " +
                " Id_Instrumento = "+ idSqlInstrument + " AND Id_Certificado = "+ idCertificate + ";");
        }

    }
}
