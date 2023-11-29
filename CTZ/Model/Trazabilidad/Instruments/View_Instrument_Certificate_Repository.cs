using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class View_Instrument_Certificate_Repository
    {
        ConexionTrazability conexion;
        public View_Instrument_Certificate_Repository() {
            conexion = new ConexionTrazability();  
        }

        public DataTable getAllInstrumentCertificate(string equino)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos_Certificado WHERE ID_Instrumentos = '"+ equino + "';");
        }

        public DataTable getAllInstrumentCertificateByInstrument(string instrument)
        {
            return conexion.getDataTable("SELECT * from Instrumentos_Certificado WHERE INSTRUMENTO like '%"+ instrument + "%';");
        }

        public DataTable getAllInstrumentCertificateByBrand(string brand)
        {
            return conexion.getDataTable("SELECT * from Instrumentos_Certificado WHERE MARCA like '%"+brand+ "%';;");
        }


    }
}
