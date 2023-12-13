using CTZ.Modelo.Documentacion;
using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Estandard
{
    public class Certificate_Repository
    {
        ConexionTrazability connection;
        public Certificate_Repository() {
            connection = new ConexionTrazability();
        } 

        public string selectCurrentCertificate(int idEstandard)
        {
            return connection.getText("Select * from Certificados_Estandares WHERE " +
                " Id_Estandard = "+ idEstandard + ";");
        }

        public void createCertificate(CertificateEstandard certificate)
        {
            connection.executeQuery("Insert into Certificados_Estandares(Fecha_De_Caducidad,Lote,Numero_De_Parte,Fecha_De_Registro,Link,Id_Estandard,Estatus) " +
                "\r\nVALUES('"+certificate.ExpirationDate+"','"+certificate.Lot+"', '"+certificate.NumberOfPart+"', '"+certificate.RegisterDate+"','"+certificate.Link+"',\r\n"+certificate.idEstandard+",'"+certificate.Status+"')");
        }

        public void updateStatusCertificates(int idEstandard)
        {
            connection.executeQuery("Update Certificados_Estandares set Estatus ='Caduco' " +
                " where Id_Estandard ="+ idEstandard + " AND Fecha_De_Caducidad < GETDATE();");
        }
    }
}
