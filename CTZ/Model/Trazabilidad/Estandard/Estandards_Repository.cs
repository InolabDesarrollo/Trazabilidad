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
        private readonly ConexionTrazability conexion;
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
                "\r\n Values('"+estandard.EstEstandard+"','"+estandard.EstandardDescription+"','"+estandard.Use+"','"+estandard.Brand+"','"+estandard.Presentation+"', " +
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

        public void updateEstandard(CTZ.View.Responsabilitis.Estandard estandard)
        {
            conexion.executeQuery("Update Estandares Set Estandar ='"+estandard.EstandardDescription+"', Uso ='"+estandard.Use+"', Marca ='"+estandard.Brand+"'," +
                " Presentacion ='"+estandard.Presentation+"', NoLote= '"+estandard.Number+"'," +
                " \r\n FechaDeFabricacion = '"+estandard.FabricationDate+"', FechaDeCaducidad='"+estandard.ExpirationDate+"', Cantidad='"+estandard.Quantity+"',\r\nUbicacion='"+estandard.Ubication+"', " +
                " Estatus ='"+estandard.Estatus+"', Inventario ='"+estandard.Inventory+"' WHERE Id_Estandares= '"+estandard.EstEstandard+"'; ");
        }

        public void updateEstatusLoanEstandard(string estatus, string Id_Estandares)
        {
            conexion.executeQuery("UPDATE Estandares SET Estatus_Prestamo = '"+estatus+ "' WHERE Id_Estandares = '" +Id_Estandares +"';");
        }
    }
}
