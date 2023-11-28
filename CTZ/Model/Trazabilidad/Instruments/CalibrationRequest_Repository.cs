using CTZ.Modelo.Documentacion;
using CTZ.View.Calibration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Instruments
{
    public class CalibrationRequest_Repository
    {
        ConexionTrazability conexion;
        public CalibrationRequest_Repository() {
            conexion = new ConexionTrazability();
        }

        public void create(int idLaboratory,string date,string numberOfReport)
        {
            conexion.executeQuery("INSERT INTO Solicitud_Calibracion " +
                "(ID_Laboratorio,Fecha,Numero_De_Folio) " +
                "\r\n values('2','17/12/2023','1A')");
        }

        public int getId()
        {
            return conexion.getScalar("SELECT TOP 1 ID FROM Solicitud_Calibracion ORDER BY ID DESC;");
        }
        
        public void addInstrumentsToRequest(int idCalibrationRequest, List<string>idInstruments)
        {
            foreach (string idInstrument in idInstruments)
            {
                conexion.executeQuery("INSERT INTO Instrumentos_Calibracion(ID_Instrumento,ID_Socitud_Calibracion)" +
                "\r\nvalues('"+ idInstrument + "',"+ idCalibrationRequest + ")");
            }
        }

        public DataTable getAll()
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion");
        }
        public DataTable getAllById(string id)
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion " +
                " WHERE ID_Socitud_Calibracion = '"+id+"';");
        }
        public DataTable getAllByEquinoInstrument(string equinoInstrument)
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion " +
                "WHERE ID_Instrumentos = '"+ equinoInstrument + "';");
        }

        public DataTable getAllByLaboratory(string laboratory)
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion " +
                " WHERE Nombre_Abreviado = '"+ laboratory + "';");
        }

        public DataTable getAllByDates(string beganDate, string finalDate)
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion where Fecha " +
                " Between '"+beganDate+"' AND   '"+ finalDate + "';");
        }

    }
}
