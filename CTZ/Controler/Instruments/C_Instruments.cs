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

        public DataTable consultarRegistrosActivos()
        {
            return repository.consultarRegistrosActivos();
        }

        public DataTable consultarTodosLosRegistros()
        {
            return repository.consultarTodosLosRegistros();
        }

        public void addNewInstrument(Instrumentos instrument)
        {                   
            repository_EFC.create(instrument);
        }

        public string deleteInstrument(string id)
        {
            bool instrumentExist = repository.serchInstrument(id);
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

        public bool serchInstrumen(string id)
        {
            return repository.serchInstrument(id);
        }

        public DataTable selectAllFromInstrument(string id)
        {
            return repository.serchAllFromInstrument(id);
        }

        public DataTable selectAllRegistAndCertificates()
        {
            return repository.selectAllRegistAndCertificates();
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
