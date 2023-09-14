using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class RelationCertificateInstrument_Repository
    {
        ConexionTrazabilidad conexion;
        public RelationCertificateInstrument_Repository() {
            conexion = new ConexionTrazabilidad();
        }

        public bool create(int idInstrument, int idCertificate)
        {
            return conexion.executeQuery("INSERT AsignacionesCertificado(ID_Instrumento,Id_Certificado) " +
                " \r\n values("+idInstrument+","+ idCertificate +");");
        }

    }
}
