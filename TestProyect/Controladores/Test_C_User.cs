using CTZ.Controlador;
using CTZ.Model.Browser.Interfaces;
using CTZ.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProyect.Controladores
{
    
    public class Test_C_User
    {
        [Test]
        public void serchEmailEngineer_String()
        {
            //Arrange
            TestRepository repository = new TestRepository();
            C_User userControler = new C_User(repository);
            string emailEngineer;
            string valueExpected = "ivanbarrientos@inolab.com";
            //Action
            emailEngineer = userControler.serchEmailEngineer("Gustavo Iván Barrientos Gutiérrez");

            //Assert
            Assert.AreEqual(valueExpected, emailEngineer);
        }
    }

    public class TestRepository : IUserRepository
    {
        public bool checkIfExistEngineer(string engineerName)
        {
            throw new NotImplementedException();
        }

        public DataTable getEngineers()
        {
            DataTable dataTable = new DataTable("Engineers");

            // Agregar columnas al DataTable
            dataTable.Columns.Add("Id", typeof(int));
            dataTable.Columns.Add("Nombre", typeof(string));
            dataTable.Columns.Add("Apellidos", typeof(string));
            dataTable.Columns.Add("Mail", typeof(string));

            AddDataRow(dataTable, 1, "Omar", "Sotomayor", "omar.andreas.sotomayor@gmail.com");
            AddDataRow(dataTable, 2, "Gustavo Iván", "Barrientos Gutiérrez", "ivanbarrientos@inolab.com");
            return dataTable;
        }

        private void AddDataRow(DataTable dataTable, int id, string nombre, string apellidos, string mail)
        {
            DataRow row = dataTable.NewRow();
            row["Id"] = id;
            row["Nombre"] = nombre;
            row["Apellidos"] = apellidos;
            row["Mail"] = mail;
            dataTable.Rows.Add(row);
        }

        public DataTable loginUser(string user, string password)
        {
            throw new NotImplementedException();
        }

        public bool validateUser(string user, string password)
        {
            throw new NotImplementedException();
        }
    }
}
