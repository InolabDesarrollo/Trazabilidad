using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Documentacion
{
    public class ConexionTrazabilidad :Conexion
    {
        public ConexionTrazabilidad()
        {
            if (databaseTest)
            {
                source = "INOLABSERVER03";
                catalog = "Trazabilidad";
                user = "ventas";
                password = "V3ntas_17";
            }
            else
            {
                source = "INOLABSERVER03";
                catalog = "TrazabilidadTest";
                user = "ventas";
                password = "V3ntas_17";
            }
            string conexionString = @"Data Source=" + source + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + user + ";Password= " + password + "";
            conexion = new SqlConnection(conexionString);
        }

    }
}
