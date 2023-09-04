using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo
{
    public class ConexionBrowser:Conexion
    {
        public ConexionBrowser()
        {
            if (databaseProduction)
            {
                source = "INOLABSERVER03";
                catalog = "Browser";
                user = "ventas";
                password = "V3ntas_17";
            }
            else
            {
                source = "INOLABSERVER03";
                catalog = "BrowserPruebas";
                user = "ventas";
                password = "V3ntas_17";
            }
            string conexionString = @"Data Source=" + source + ";Initial Catalog=" + catalog + ";Persist Security Info=True;User ID=" + user + ";Password= " + password + "";
            conexion = new SqlConnection(conexionString);
        }


    }
}
