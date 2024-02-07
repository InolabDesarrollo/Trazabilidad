using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;
using Model;
using System.Data.Entity;
using System.Diagnostics;

namespace CTZ.Controlador
{
    public class C_Instruments
    {
        Instrument_Repository instrument_repository;        
        public C_Instruments() { 
            instrument_repository = new Instrument_Repository();
        }

        public bool addNewInstrument(Instrumentos instrument)
        {
            bool instrumentExist = instrument_repository.checkIfInstrumentExist(instrument.ID_Instrumentos);
            if (instrumentExist)
            {
                return false;
            }
            else
            {
                instrument_repository.create(instrument);
                return true;
            }        
        }

        public string deleteInstrument(string id)
        {
            bool instrumentExist = instrument_repository.checkIfInstrumentExist(id);
            if (instrumentExist)
            {
                instrument_repository.delete(id);
                return "El instrumento se elimino";
            }
            else
            {
                return "El instrumento no existe";
            } 
        }

        public void updateInstrument(Instrumentos instrument)
        {
            instrument_repository.update(instrument);
        }

        public bool serchInstrument(string id)
        {
            return instrument_repository.checkIfInstrumentExist(id);
        }

        public DataTable selectAllFromInstrument(string id)
        {
            return instrument_repository.selectAllInformationOfInstrument(id);
        }

        public string serchStatusAssignment(string idInstrument)
        {
            return instrument_repository.serchStatusAssignment(idInstrument);
        }

        public bool checkIfInstrumentIsAvailable(string idInstrument)
        {
            string statusAssignments = instrument_repository.serchStatusAssignment(idInstrument);
            if (statusAssignments.Equals("DISPONIBLE") || statusAssignments.Equals(""))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
