using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Estandard
{
    
    public class Estandards_Repository
    {
        ConexionTrazability conexion;
        public Estandards_Repository() {
            conexion = new ConexionTrazability();
        }

        public DataTable selectAllEstandards()
        {
            return conexion.getDataTable("Select * from Estandares;");
        }
        
    }
}
