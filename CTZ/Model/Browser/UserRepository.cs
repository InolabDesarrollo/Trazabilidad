using CTZ.Model.Browser.Interfaces;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Browser
{
    public class UserRepository :IUserRepository
    {
        ConexionBrowser conexion = new ConexionBrowser();
        public DataTable loginUser(string user, string password)
        {
            string query = "select IdUsuario,IdRol,IdArea,Mail from Usuarios where Usuario='" + user + "' and Password_='"
              + password + "' and Activo='1'";
            return conexion.getDataTable(query);
        }

        public bool validateUser(string user, string password)
        {
            string query = "Select Usuario, Password_ FROM Usuarios WHERE Usuario = '" + user + "' AND Password_ = '" + password + "';";
            return conexion.isThereSomeInformation(query);
        }

        public DataTable getEngineers()
        {
            return conexion.getDataTable("SELECT * FROM Usuarios where IdArea = 6;");
        }

        public bool checkIfExistEngineer(string engineerName)
        {
            return conexion.isThereSomeInformation("Select  Nombre,Apellidos  FROM Usuarios " +
                " WHERE Nombre LIKE '%"+ engineerName + "%' OR Apellidos LIKE '%"+ engineerName + "%' ;");
        }

    }
}
