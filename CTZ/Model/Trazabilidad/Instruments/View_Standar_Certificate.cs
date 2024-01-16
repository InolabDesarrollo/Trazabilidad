using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace CTZ.Model.Trazabilidad
{
    public class View_Standar_Certificate
    {
        ConexionTrazability connection;
        public View_Standar_Certificate() { 
            connection = new ConexionTrazability();
        }

        public DataTable selectAllByStandar(string standar)
        {
            return connection.getDataTable("Select * from Estandares_Certificados WHERE Id_Estandares = '"+standar+ "';");
        }

    }
}
