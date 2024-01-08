using CTZ.Modelo.Documentacion;
using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Data;
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
            connection.executeQuery("Insert into Certificados_Estandares(Fecha_De_Caducidad,Lote,Numero_De_Parte,Fecha_De_Registro,Link,Estandar,Estatus) " +
                "\r\nVALUES('"+certificate.ExpirationDate+"','"+certificate.Lot+"', '"+certificate.NumberOfPart+"', '"+certificate.RegisterDate+"','"+certificate.Link+"'," +
                " \r\n '"+certificate.Estandard+"','"+certificate.Status+"')");
        }

        public void updateStatusCertificates(string Estandard)
        {
            connection.executeQuery("Update Certificados_Estandares set Estatus = 'Caduco' " +
                " where Estandar = '"+Estandard+"' AND Fecha_De_Caducidad < GETDATE();");
        }

        public string getLinkCertificate(int idEstandard)
        {
            return connection.getText("Select Link From Certificados_Estandares WHERE Id_Estandard = "+ idEstandard + " and Estatus ='Vigente';");
        }


    }
}
