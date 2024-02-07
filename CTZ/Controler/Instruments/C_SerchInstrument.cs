using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_SerchInstrument
    {
        Instrument_Repository repository_EFC;
        public C_SerchInstrument() {
            repository_EFC = new Instrument_Repository();
        }
        public bool checkIfInstrumentExist(string id)
        {
            return repository_EFC.checkIfInstrumentExist(id);         
        }

        public List<Instrumentos> serchAllFromInstrument(string id)
        {
            return repository_EFC.serchAllFromInstrument(id);
        }

        public List<Instrumentos> serchAllByDescription(string instrumentDescription)
        {
            return repository_EFC.serchAllByDescription(instrumentDescription);
        }

        public List<Instrumentos> serchAllByBrand(string brand)
        {
            return repository_EFC.serchAllByBrand(brand);
        }

    }
}
