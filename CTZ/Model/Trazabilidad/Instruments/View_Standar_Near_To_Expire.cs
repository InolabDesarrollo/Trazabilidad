using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Instruments
{
    public class View_Standar_Near_To_Expire
    {
        ConexionTrazability connection;
        public View_Standar_Near_To_Expire() {
            connection = new ConexionTrazability();
        }
        
        public DataTable selectAllByStandar(string standar)
        {
            return connection.getDataTable("select * from Estandares_cerca_de_caducar WHERE Id_Estandares = '"+standar+ "';");
        }
    }
}
