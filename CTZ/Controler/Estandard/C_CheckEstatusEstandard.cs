using CTZ.Model.Trazabilidad.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_CheckEstatusEstandard
    {
        Estandards_Repository repository;
        public C_CheckEstatusEstandard() { 
            repository = new Estandards_Repository();
        }

        public bool check(string idEstandartEst)
        {
            return repository.checkEstandard(idEstandartEst); 
        }
    }
}
