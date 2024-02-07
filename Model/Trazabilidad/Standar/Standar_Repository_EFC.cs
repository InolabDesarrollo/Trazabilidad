using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Trazabilidad.Standar
{
    public class Standar_Repository_EFC
    {
        private Entities database;

        public void create(Estandares standar)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Estandares.Add(standar);
                    database.SaveChanges();
                }

            }catch (Exception ex)
            {
                Trace.WriteLine(ex);
            }
        }

        public void update(Estandares standar)
        {
            try
            {
                using (database = new Entities())
                {
                    database.Entry(standar).State = EntityState.Modified; 
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
                    database.Estandares.Remove(database.Estandares.
                        Single(est => est.Id_Estandares == id));
                    database.SaveChanges(); 

                }
            }catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

    }
}
