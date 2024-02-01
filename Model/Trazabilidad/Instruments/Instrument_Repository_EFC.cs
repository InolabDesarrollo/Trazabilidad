using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instrument_Repository_EFC
    {
        Entities database;
        public List<Instrumentos> select()
        {
            try
            {
                using (database = new Entities())
                {
                    return database.Instrumentos.ToList();
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null;
            }
        }

        public void create(Instrumentos instrument)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Instrumentos.Add(instrument);
                    database.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        public void update(Instrumentos instrument)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Entry(instrument).State = EntityState.Modified;
                    database.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        public void delete(string id)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Instrumentos.Remove(database.Instrumentos.
                        Single(ins => ins.ID_Instrumentos == id));
                    database.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }
    }
}
