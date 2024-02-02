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
    public class Instrument_Repository
    {
        ConexionTrazability conexion;
        public Instrument_Repository() {
            conexion = new ConexionTrazability();
        }

        public DataTable consultarRegistrosActivos()
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE ESTATUS != 'FUERA DE USO';");
        }

        public DataTable consultarTodosLosRegistros()
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos");
        }

        public DataTable selectInstrumentsAndCertificates()
        {
            return conexion.getDataTable("SELECT  Ins.ID,Ins.ID_Instrumentos, Ins.INSTRUMENTO,Ins.MARCA,Ins.MODELO,Ins.N#S#,Ins.UBICACIÓN,Ins.OBSERVACIÓN,Ins.ESTATUS, " +
                "\r\n cer.Fecha_De_Calibracion,Cer.Proxima_Calibracion, Cer.Numero,cer.Laboratorio FROM Instrumentos Ins " +
                "\r\n LEFT JOIN  AsignacionesCertificado Asi \r\nON\r\nIns.ID = Asi.ID " +
                "\r\n LEFT JOIN Certificados  " +
                " Cer\r\nOn  " +
                " Asi.Id_Certificado = Cer.ID; \r\n");
        }

        public bool serchInstrument(string id)
        {
            return conexion.isThereSomeInformation("SELECT * FROM Instrumentos WHERE ID_Instrumentos = '"+id+"';");
        }

        public DataTable serchAllFromInstrument(string id)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE ID_Instrumentos = '" + id + "';");
        }

        public DataTable selectAllRegistAndCertificates()
        {
            return conexion.getDataTable("SELECT\r\n    ID,\r\n    ID_Instrumentos,\r\n    INSTRUMENTO,\r\n    MARCA,\r\n    MODELO,\r\n    \"N#S#\",\r\n    UBICACIÓN,\r\n    OBSERVACIÓN,\r\n    ESTATUS,\r\n    Fecha_De_Calibracion,\r\n    Proxima_Calibracion,\r\n    Numero,\r\n    Laboratorio,\r\n    Fecha_Registro\r\nFROM (\r\n    SELECT\r\n        Ins.ID,\r\n        Ins.ID_Instrumentos,\r\n        Ins.INSTRUMENTO,\r\n        Ins.MARCA,\r\n        Ins.MODELO,\r\n        Ins.\"N#S#\",\r\n        Ins.UBICACIÓN,\r\n        Ins.OBSERVACIÓN,\r\n        Ins.ESTATUS,\r\n        Cer.Fecha_De_Calibracion,\r\n        Cer.Proxima_Calibracion,\r\n        Cer.Numero,\r\n        Cer.Laboratorio,\r\n        cer.Fecha_De_Registro AS Fecha_Registro,\r\n        ROW_NUMBER() OVER (PARTITION BY Ins.ID ORDER BY cer.Fecha_De_Registro DESC) AS rn\r\n    FROM Instrumentos Ins\r\n    LEFT JOIN AsignacionesCertificado Asi ON Ins.ID = Asi.Id_Instrumento\r\n    LEFT JOIN Certificados Cer ON Asi.Id_Certificado = Cer.ID\r\n) AS Subquery\r\nWHERE rn = 1;");
        }

        public DataTable selectAllByInstrumentName(string nameInstrument)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE INSTRUMENTO LIKE '%"+ nameInstrument + "%';");
        }

        public DataTable selectAllByBrand(string brandName)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE MARCA LIKE '%" + brandName + "%';");
        }

        public void updateStatusInstrumentAssignment(string idInstrument, string status)
        {
            conexion.executeQuery("UPDATE Instrumentos SET ESTATUS_ASIGNACION = '" + status + "' WHERE ID_Instrumentos = '"+idInstrument+"';");
        }

    }
}
