using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTZ.Model;
using CTZ.Model.Trazabilidad;

namespace CTZ.Controler.Trazabilidad
{
    public class C_Laboratories
    {
        Laboratory_Repository repository;
        public C_Laboratories() {
            repository = new Laboratory_Repository();
        }

        public DataTable selectLaboratories()
        {
            return repository.selectLaboratories();
        }
    }
}
