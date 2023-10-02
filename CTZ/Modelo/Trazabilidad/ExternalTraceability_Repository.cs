using CTZ.Modelo.Documentacion;
using CTZ.Vista.Traceability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CTZ.Modelo.Trazabilidad
{
    public class ExternalTraceability_Repository
    {
        ConexionTrazabilidad conexion;
        public ExternalTraceability_Repository() {
            conexion = new ConexionTrazabilidad();         
        }

        public void add(ExternalTraceability_Letter traceability_Letter)
        {
            conexion.executeQuery("INSERT INTO CartasTrazabilidadExternas(ID_CartaTrazabilidad,Empresa,Marca,Modelo,Serie,CalibradoPor,Incertidumbre)" +
                "\r\nVALUES("+traceability_Letter.idTraceabilityLetter+",'"+traceability_Letter.enterprise+"','"+traceability_Letter.brand+"','"+traceability_Letter.model+"','"+traceability_Letter.numberOfSerie+"','"+traceability_Letter.calibrateBy+"','"+traceability_Letter.uncertainty+"')");
        }
    }
}
