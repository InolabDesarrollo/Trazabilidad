using CTZ.Vista.Traceability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CTZ.Modelo.Trazabilidad
{
    public class TraceabilityLetter_Repository
    {
        Conexion conexion;
        public TraceabilityLetter_Repository() {
            conexion = new Conexion();
        } 
        
        public void add(InternTraceability_Letter traceability)
        {
            conexion.executeQuery(" INSERT INTO CartasTrazabilidad(Numero_Certificado,Titulo,Empresa,Empresa_Interna,Equipo, Marca,Modelo,Serie,Incertidumbre)\r\n" +
                " VALUES("+traceability.numberCertificate+",'"+traceability.title+"','"+"Inolab Especialistas de Servicio S.A de C.V."+"','"+traceability.internEnterprise+"','"+traceability.equipment+"','"+traceability.brand+"','"+traceability.model+"','"+traceability.numberOfSerie+"','"+traceability.uncertainty+"' )");
        }

        public string selectColumn(string campo, string numberCertificate)
        {
            return conexion.getText("SELECT "+ campo+ " from CartasTrazabilidad WHERE Numero_Certificado = "+ numberCertificate + ";");
        }

        public bool verifiTraceability(string numberCertificate)
        {
            return conexion.isThereSomeInformation("SELECT Numero_Certificado FROM " +
                " CartasTrazabilidad where Numero_Certificado = "+ numberCertificate + ";");
        }

    }
}
