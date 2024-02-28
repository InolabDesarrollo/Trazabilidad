using Model;
using Model.Trazabilidad.Instruments;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Accessory
{
    public class C_Manage_Accessories
    {
        private Instrument_Accessories_Repository repository;
        public C_Manage_Accessories() { 
            repository = new Instrument_Accessories_Repository();
        }

        public List<Accesorios_Instrumento> selectAll(string idInstrument)
        {
            return repository.selectAll(idInstrument);
        }
    }
}
