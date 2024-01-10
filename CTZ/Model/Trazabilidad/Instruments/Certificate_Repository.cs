using CTZ.Modelo.Documentacion;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class Certificate_Repository
    {
        ConexionTrazability conexion;
        public Certificate_Repository() {
            conexion = new ConexionTrazability();
        }
        
        public void add(Certificate certificate)
        {
            string query = "INSERT INTO Certificados(Instrumento, Fecha_De_Calibracion,Proxima_Calibracion,Link,Numero,Uso,Laboratorio,Estatus)" +
                "\r\nVALUES('" + certificate.instrument + "', '" + certificate.dateCalibration + "','" + certificate.nextCalibration + "', '" + certificate.link + "'," +
                " '" + certificate.number + "','" + certificate.use + "','" + certificate.laboratory + "', '" + certificate.status + "')";
            conexion.executeQuery(query);
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
