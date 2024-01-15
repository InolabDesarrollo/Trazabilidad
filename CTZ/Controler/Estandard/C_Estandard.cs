using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CTZ.Controler.Estandard
{
    public class C_Estandard
    {
        Estandards_Repository repository;
        public C_Estandard() {
            repository = new Estandards_Repository();   
        }

        public bool checkIfEstandarExist(string idEstandartEst)
        {
            return repository.checkEstandard(idEstandartEst);
        }

        public DataTable selectEstandardByEST(string idEstandard)
        {
            return repository.selectByEST(idEstandard);
        }

        public DataTable selectLotsAndParts(string standar)
        {
            return repository.selectLotsAndParts(standar);
        }

        public DataTable selectByEstandard(string estandard)
        {
            return repository.selectByEstandard(estandard);
        }

        public DataTable selectByBrand(string brand)
        {
            return repository.selectByBrand(brand);
        }

        public bool checkIfStandarWasBorrowed(string standard)
        {
            DataTable standarInformation = repository.selectByEST(standard);
            if (standarInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("PRESTADO") || standarInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("ASIGNADO"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getNumberOfLotsAvailable(string standar)
        {
            try
            {
                DataTable informationStandar = repository.selectByEST(standar);
                int numberOfLotsAvailable = Convert.ToInt32(informationStandar.Rows[0]["NoLotes_Disponibles"].ToString());
                return numberOfLotsAvailable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sin lotes disponibles "+ex.Message);
                return 0;
            }   
        }
    }
}
