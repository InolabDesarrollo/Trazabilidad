using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
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

        public List<Accesorios_Instrumento> selectAll (string idInstrument)
        {
            try {
                using (database = new Entities())
                {
                    var accessories = database.Accesorios_Instrumento.
                        Where(ins => ins.Id_Instrumento == idInstrument
                        ).ToList(); ;

                    return accessories;
                }
            }catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
                return null;
            }          
        }

        public void updateStatusAssignment(string idAccessory, string statusAssignment)
        {
            try
            {
               database = new Entities();              
               var accessory = database.Accesorios_Instrumento.
                    FirstOrDefault(acce => acce.Id_Accesorio == idAccessory);

               if (accessory != null)
               {
                    accessory.Estatus_Asignacion = statusAssignment;
                    database.SaveChanges();
               }
            }catch (Exception ex)
            {
                Trace.WriteLine(ex.Message);
            }
        }

        public List<string> selectAccessoriesOfInstrument(string idInstrument)        
        {
            try
            {
                database = new Entities();
                var accessories = database.Accesorios_Instrumento.
                    Where(acce => acce.Id_Instrumento == idInstrument).
                    Select(acce => acce.Id_Accesorio).ToList();

                return accessories;
            }
            catch (Exception ex)
            {
                Trace.WriteLine (ex.Message);
                return null;
            }
        }

        private DataTable createAccessoriesTable(List<Accesorios_Instrumento> accessories)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Id_Instrumento", typeof(string));
            table.Columns.Add("Id_Accesorio", typeof(string));
            table.Columns.Add("Estatus_Asignacion", typeof(string));

            if (accessories != null)
            {
                foreach (var accessory in accessories)
                {
                    table.Rows.Add(accessory.Id_Instrumento);
                    table.Rows.Add(accessory.Id_Accesorio);
                    table.Rows.Add(accessory.Estatus_Asignacion);
                }              
            }
            return table;
        }

    }
}
