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

namespace CTZ.Controlador
{
    public class C_Instruments
    {
        Instrument_Repository repository;
        Instrument_Repository_EFC repository_EFC;
         
        public C_Instruments() { 
            repository = new Instrument_Repository();
            repository_EFC = new Instrument_Repository_EFC();
        }

        public bool addNewInstrument(Instrumentos instrument)
        {
            bool instrumentExist = repository_EFC.checkIfInstrumentExist(instrument.ID_Instrumentos);
            if (instrumentExist)
            {
                return false;
            }
            else
            {
                repository_EFC.create(instrument);
                return true;
            }        
        }

        public string deleteInstrument(string id)
        {
            bool instrumentExist = repository_EFC.checkIfInstrumentExist(id);
            if (instrumentExist)
            {
                repository_EFC.delete(id);
                return "El instrumento se elimino";
            }
            else
            {
                return "El instrumento no existe";
            } 
        }

        public void updateInstrument(Instrumentos instrument)
        {
            repository_EFC.update(instrument);
        }

        public bool serchInstrument(string id)
        {
            return repository_EFC.checkIfInstrumentExist(id);
        }

        public DataTable selectAllFromInstrument(string id)
        {
            return repository.serchAllFromInstrument(id);
        }

        public bool checkIfInstrumentIsAvailable(string idInstrument)
        {
            DataTable instrumentInformation = repository.serchAllFromInstrument(idInstrument);
            string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();

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
