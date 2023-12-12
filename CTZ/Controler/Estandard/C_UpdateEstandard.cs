using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_UpdateEstandard
    {
        Estandards_Repository _repository;
        public C_UpdateEstandard() {
            _repository = new Estandards_Repository();
        }


        public void update(CTZ.View.Responsabilitis.Estandard estandard)
        {
            DateForReport date = new DateForReport();
            estandard.FabricationDate = date.convertToValidDate(estandard.FabricationDate);
            estandard.ExpirationDate = date.convertToValidDate(estandard.ExpirationDate);
            
            _repository.updateEstandard(estandard);
        }
    }
}
