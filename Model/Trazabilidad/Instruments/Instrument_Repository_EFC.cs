using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instrument_Repository_EFC
    {
        Entities database;

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

        public bool checkIfInstrumentExist(string id)
        {
            try
            {
                using (database = new Entities())
                {
                    return database.Instrumentos.Any(ins => ins.ID_Instrumentos == id);
                }
            }
            catch(Exception ex) 
            {
                Trace.WriteLine(ex.Message);
                return false;
            }
        }

        public List<Instrumentos> serchAllFromInstrument(string id)
        {
            try
            {
                using (database = new Entities())
                {
                    return database.Instrumentos.Where(ins => ins.ID_Instrumentos == id).ToList();
                }
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null;    
            }
        }

        public List<Instrumentos> serchAllByDescription(string instrumentDescription)
        {
            try
            {
                using (database = new Entities())
                {
                    return database.Instrumentos.
                        Where(ins => ins.INSTRUMENTO == instrumentDescription).ToList();
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null; 
            }
        }

        public List<Instrumentos> serchAllByBrand(string brand)
        {
            try
            {
                using (database = new Entities())
                {
                    return database.Instrumentos.Where(ins => ins.MARCA == brand).ToList();
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null;
            }
        }

    }
}
