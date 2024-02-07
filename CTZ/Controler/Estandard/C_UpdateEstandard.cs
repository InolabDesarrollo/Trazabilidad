using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Vista.Responsabilitis;
using Model;
using Model.Trazabilidad.Standar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_UpdateEstandard
    {
        Standar_Repository_EFC repository_EFC;
        public C_UpdateEstandard() {
            repository_EFC = new Standar_Repository_EFC();
        }

        public void update(Estandares standar)
        {
            DateForReport date = new DateForReport();
            standar.FechaDeFabricacion = date.convertToValidDate(standar.FechaDeFabricacion);
            standar.FechaDeCaducidad = date.convertToValidDate(standar.FechaDeCaducidad);

            repository_EFC.update(standar);
        }
    }
}
