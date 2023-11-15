using CTZ.Modelo.Documentacion;
using CTZ.View.Calibration;
using CTZ.View.Responsabilitis;
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
        ConexionTrazabilidad conexion;
        public CalibrationRequest_Repository() {
            conexion = new ConexionTrazabilidad();
        }

        public void create(CalibrationRequest calibrationRequest)
        {
            conexion.executeQuery("INSERT INTO Solicitud_Calibracion (ID_Laboratorio,Fecha) " +
                "\r\n values("+ calibrationRequest.idLaboratory+ ",'"+calibrationRequest.dateOfRequest+"') ");
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
        public DataTable getAllByEquinoInstrument(string equinoInstrument)
        {
            return conexion.getDataTable("Select * from Solicitudes_de_calibracion " +
                "WHERE ID_Instrumentos = '"+ equinoInstrument + "';");
        }

    }
}
