using CTZ.Modelo.Documentacion;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class Certificate_Repository
    {
        ConexionTrazabilidad conexion;
        public Certificate_Repository() {
            conexion = new ConexionTrazabilidad();
        }
        
        public void add(Certificate certificate)
        {
            conexion.executeQuery("INSERT INTO Certificados(Fecha_De_Calibracion,Proxima_Calibracion,Link,Numero,Uso,Laboratorio)" +
                "\r\nVALUES('"+certificate.dateCalibration+"','"+certificate.nextCalibration+"', '"+certificate.link+"'," +
                " '"+certificate.number+"','"+certificate.use+"','"+certificate.laboratory+"' )");
        }

        public string getColumn(string column,string number)
        {
            return conexion.getText("Select "+column+ " FROM Certificados WHERE Numero ='" + number + "' )");
        }

        public int lastCertificateRegistered()
        {
            return conexion.getScalar(" SELECT TOP 1 ID FROM Certificados \r\n ORDER BY ID DESC; ");
        }

        public void delete(string numberCertificate)
        {
            conexion.executeQuery("DELETE  FROM Certificados WHERE Numero = '"+ numberCertificate + "';");
        }

        public string getValueCell(int idSqlCertificate, string cell)
        {
            return conexion.getText("SELECT "+cell+ " FROM Certificados WHERE ID = " + idSqlCertificate + "; ");
        }

        public bool checkIfNumberExist(string number)
        {
            return conexion.isThereSomeInformation("SELECT Numero FROM Certificados where Numero = '"+ number + "';");
        }

    }
}
