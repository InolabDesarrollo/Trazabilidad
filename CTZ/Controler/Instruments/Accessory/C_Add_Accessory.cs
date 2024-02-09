using Model;
using Model.Trazabilidad.Instruments;
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
    public class C_Add_Accessory
    {
        Instrument_Accessories_Repository repository;
        public C_Add_Accessory()
        {
            repository = new Instrument_Accessories_Repository();
        }

        public void controll(Accesorios_Instrumento accessories)
        {
            repository.create(accessories); 
        }
    }
}