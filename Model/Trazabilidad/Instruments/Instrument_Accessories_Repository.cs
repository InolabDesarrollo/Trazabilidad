using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model.Trazabilidad.Instruments
{
    public class Instrument_Accessories_Repository
    {
        private Entities database;

        public void create(Accesorios_Instrumento accessories)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Accesorios_Instrumento.Add(accessories);
                    database.SaveChanges();
                }

            }catch(Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

    }
}
