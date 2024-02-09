using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Instrument_Repository
    {
        private Entities database;

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

        public string serchStatusAssignment(string idInstrument)
        {
            try
            {
                string statusAssignment = "";
                using (database = new Entities())
                {
                    statusAssignment = database.Instrumentos.
                        Where(ins => ins.ID_Instrumentos == idInstrument).
                        Select(ins => ins.ESTATUS_ASIGNACION).FirstOrDefault() ?? "";

                    return statusAssignment;
                }     
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return "";
            }
        }

        public void updateStatusInstrumentAssignment(string idInstrument, string status)
        {
            try
            {
                using (database = new Entities())
                {
                    var instrument = database.Instrumentos.FirstOrDefault(ins=> ins.ID_Instrumentos == idInstrument);

                    if (idInstrument != null)
                    {
                        instrument.ESTATUS_ASIGNACION = status;
                        database.SaveChanges();
                    }
                }
                
            }catch(Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        public DataTable selectAllInformationOfInstrument(string id)
        {
            DataTable table = new DataTable();
            try
            {
                using (database = new Entities())
                {
                    var instrument = database.Instrumentos.
                        Where(ins => ins.ID_Instrumentos == id).FirstOrDefault();

                    table = this.createTableInstrument();

                    table.Rows.Add(instrument.ID, instrument.ID_Instrumentos, instrument.INSTRUMENTO,
                        instrument.MARCA, instrument.MODELO, instrument.N_S_,
                        instrument.UBICACIÓN, instrument.OBSERVACIÓN, instrument.INTERVALO_DE_MEDIA,
                        instrument.USO, instrument.MAGNITUD, instrument.ESTATUS);
                }
                return table;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null;
            } 
        }

        private DataTable createTableInstrument()
        {
            DataTable instruments = new DataTable();
            instruments.Columns.Add("ID", typeof(int));
            instruments.Columns.Add("ID_Instrumentos", typeof(string));
            instruments.Columns.Add("INSTRUMENTO", typeof(string));
            instruments.Columns.Add("MARCA", typeof(string));
            instruments.Columns.Add("MODELO", typeof(string));
            instruments.Columns.Add("N#S#", typeof(string));
            instruments.Columns.Add("UBICACIÓN", typeof(string));
            instruments.Columns.Add("OBSERVACIÓN", typeof(string));
            instruments.Columns.Add("INTERVALO_DE_MEDIA", typeof(string));
            instruments.Columns.Add("USO", typeof(string));
            instruments.Columns.Add("MAGNITUD", typeof(string));
            instruments.Columns.Add("ESTATUS", typeof(string));
            
            return instruments;
        }
    }
}
