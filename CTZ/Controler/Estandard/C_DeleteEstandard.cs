using CTZ.Model.Trazabilidad.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_DeleteEstandard
    {
        private readonly string idEstandardEst;
        Estandards_Repository repository;
        public C_DeleteEstandard(string idEstandardEst) {
            repository = new Estandards_Repository();
            this.idEstandardEst = idEstandardEst;
        }

        public void Delete()
        {
            repository.delete(idEstandardEst);
        }

    }
}
