using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_Estandard
    {
        Estandards_Repository repository;
        public C_Estandard() {
            repository = new Estandards_Repository();   
        }

        public bool check(string idEstandartEst)
        {
            return repository.checkEstandard(idEstandartEst);
        }

        public DataTable selectEstandardByEST(string idEstandard)
        {
            return repository.selectByEST(idEstandard);
        }

        public DataTable selectByEstandard(string estandard)
        {
            return repository.selectByEstandard(estandard);
        }

        public DataTable selectByBrand(string brand)
        {
            return repository.selectByBrand(brand);
        }
    }
}
