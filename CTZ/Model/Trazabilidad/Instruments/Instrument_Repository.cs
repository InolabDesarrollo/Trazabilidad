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

        public DataTable serchAllFromInstrument(string id)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE ID_Instrumentos = '" + id + "';");
        }

        public void updateStatusInstrumentAssignment(string idInstrument, string status)
        {
            conexion.executeQuery("UPDATE Instrumentos SET ESTATUS_ASIGNACION = '" + status + "' WHERE ID_Instrumentos = '"+idInstrument+"';");
        }
    }
}
