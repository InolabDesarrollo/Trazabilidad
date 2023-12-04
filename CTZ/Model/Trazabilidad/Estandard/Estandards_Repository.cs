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

        public void add(CTZ.View.Responsabilitis.Estandard estandard)
        {
            conexion.executeQuery("Insert Estandares(Id_Estandares,Estandar,Uso,Marca,Presentacion,NoLote,FechaDeFabricacion," +
                "\r\n FechaDeCaducidad,Cantidad,Ubicacion,Estatus, Inventario)" +
                "\r\n Values('"+estandard.IdEstandard+"','"+estandard.EstandardDescription+"','"+estandard.Use+"','"+estandard.Brand+"','"+estandard.Presentation+"', " +
                "\r\n '"+estandard.Number+"','"+estandard.FabricationDate+"','"+estandard.ExpirationDate+"','"+estandard.Quantity+"','"+estandard.Ubication+"','"+estandard.Estatus+"','"+estandard.Inventory+"'); ");
        }

        public bool checkEstandard(string idEstandardEst)
        {
            return conexion.isThereSomeInformation("Select * from Estandares where Id_Estandares = '"+ idEstandardEst + "';");
        }

        public void delete(string idEstandardEst)
        {
            conexion.executeQuery("DELETE  FROM Estandares WHERE Id_Estandares = '"+idEstandardEst+"';");
        }

        public DataTable selectByEST(string idEstandard)
        {
            return conexion.getDataTable("Select * from " +
                " Estandares where Id_Estandares = '"+ idEstandard + "';");
        }

        public DataTable selectByEstandard(string estandard)
        {
            return conexion.getDataTable("SELECT * FROM Estandares WHERE Estandar LIKE  '%"+ estandard + "%';");
        }

        public DataTable selectByBrand(string brand)
        {
            return conexion.getDataTable("SELECT * FROM Estandares WHERE Marca LIKE  '%"+brand+"%';");
        }
    }
}
