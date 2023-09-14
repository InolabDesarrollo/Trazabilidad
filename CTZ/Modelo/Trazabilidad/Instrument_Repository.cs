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
        ConexionTrazabilidad conexion;
        public Instrument_Repository() {
            conexion = new ConexionTrazabilidad();
        }

        public DataTable consultarRegistrosActivos()
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE ESTATUS != 'FUERA DE USO';");
        }

        public DataTable consultarTodosLosRegistros()
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos");
        }

        public void addNewInstrument(Instruments instrument)
        {
            conexion.executeQuery("INSERT Instrumentos(ID_Instrumentos,INSTRUMENTO,MARCA,MODELO,N#S#,UBICACIÓN,OBSERVACIÓN,ESTATUS) \r\n" +
                "values('"+instrument.id+"','"+instrument.instrument+"','"+instrument.brand+"','"+instrument.model+"','"
                +instrument.numberOfSerie+"','"+instrument.ubication+"','"+instrument.observation+"','"+instrument.status+"');");
        }

        public void deleteInstrument(string id )
        {
            conexion.executeQuery("DELETE Instrumentos WHERE ID_Instrumentos = '"+id+"';");
        }

        public bool updateInstrument(Instruments instrument)
        {
            return conexion.executeQuery("UPDATE Instrumentos SET ID_Instrumentos = '"+instrument.id+"', " +
                " INSTRUMENTO = '"+instrument.instrument +"', MARCA = '"+instrument.brand+"', MODELO='"+instrument.model+"',N#S# = '"+instrument.numberOfSerie+"', \r\n" +
                " UBICACIÓN='"+instrument.ubication+"',OBSERVACIÓN='"+instrument.observation+"', ESTATUS='"+instrument.status+"' WHERE ID_Instrumentos = '"+instrument.id+"';");
        }

        public bool serchInstrument(string id)
        {
            return conexion.isThereSomeInformation("SELECT * FROM Instrumentos WHERE ID_Instrumentos = '"+id+"';");
        }

        public DataTable serchAllFromInstrument(string id)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos WHERE ID_Instrumentos = '" + id + "';");
        }

    }
}
