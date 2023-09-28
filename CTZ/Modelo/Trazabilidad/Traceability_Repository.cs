using CTZ.Vista.Traceability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace CTZ.Modelo.Trazabilidad
{
    public class Traceability_Repository
    {
        Conexion conexion;
        public Traceability_Repository() {
            conexion = new Conexion();
        } 
        
        public void add(Traceability_Letter traceability)
        {
            conexion.executeQuery(" INSERT INTO CartasTrazabilidad(Numero_Certificado,Titulo,Empresa,Empresa_Interna,Equipo, Marca,Modelo,Serie,Incertidumbre)\r\n" +
                " VALUES("+traceability.numberCertificate+",'"+traceability.title+"','"+traceability.enterprise+"','"+traceability.internEnterprise+"','"+traceability.equipment+"','"+traceability.brand+"','"+traceability.model+"','"+traceability.numberOfSerie+"','"+traceability.uncertainty+"' )");
        }

        public string selectColumn(string campo, string numberCertificate)
        {
            return conexion.getText("SELECT "+ campo+ " from CartasTrazabilidad WHERE Numero_Certificado = "+ numberCertificate + ";");
        }

    }
}
