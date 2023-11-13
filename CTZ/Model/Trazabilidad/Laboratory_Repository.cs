using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad
{
    public class Laboratory_Repository
    {
        ConexionTrazabilidad conexion;
        public Laboratory_Repository() {
            conexion= new ConexionTrazabilidad();
        }

        public DataTable selectLaboratories()
        {
            return conexion.getDataTable("SELECT * FROM Laboratorios;");
        }
    }
}
