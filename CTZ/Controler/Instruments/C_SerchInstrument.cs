using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_SerchInstrument
    {
        Instrument_Repository repository;  
        public C_SerchInstrument() {
            repository = new Instrument_Repository();
        }
        public bool serchInstrumenByEquino(string id)
        {
            return repository.serchInstrument(id);
        }

        public DataTable selectAllFromInstrumentByEquino(string id)
        {
            return repository.serchAllFromInstrument(id);
        }

        public DataTable selectAllByInstrumentName(string nameInstrument)
        {
            return repository.selectAllByInstrumentName(nameInstrument);         
        }

        public DataTable selectAllByBrand(string brandName)
        {
            return repository.selectAllByBrand(brandName);
        }


    }
}
