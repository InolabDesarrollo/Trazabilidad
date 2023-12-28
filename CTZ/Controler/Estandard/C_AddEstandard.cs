using CTZ.Model.Trazabilidad.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;

namespace CTZ.Controler.Estandard
{
    public class C_AddEstandard
    {
        private readonly View.Responsabilitis.Estandard estandard;
        private readonly Estandards_Repository repository;

        public C_AddEstandard(CTZ.View.Responsabilitis.Estandard estandard) { 
            repository = new Estandards_Repository();
            this.estandard = estandard;
        }

        public void add()
        {
            DateForReport date = new DateForReport();
            estandard.FabricationDate = date.convertToValidDateDatePicker(estandard.FabricationDate);
            estandard.ExpirationDate =date.convertToValidDateDatePicker(estandard.ExpirationDate);

            repository.add(estandard);
        }

    }
}
