using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using Model;
using Model.Trazabilidad.Instruments;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Markup;

namespace CTZ.Controlador
{
    public class C_Instruments
    {
        Instrument_Repository repository;  
        public C_Instruments() { 
            repository = new Instrument_Repository();
        }

        public DataTable consultarRegistrosActivos()
        {
            return repository.consultarRegistrosActivos();
        }

        public DataTable consultarTodosLosRegistros()
        {
            return repository.consultarTodosLosRegistros();
        }

        public DataTable selectInstrumentsAndCertificates()
        {
            return repository.selectInstrumentsAndCertificates();
        }

        public void addNewInstrument(Instrument instrument)
        {
            //repository.addNewInstrument(instrument);
            
            Instrumentos instrument_efc = new Instrumentos();
            
            instrument_efc.ID_Instrumentos = instrument.id;
            instrument_efc.INSTRUMENTO = instrument.instrument;
            instrument_efc.MARCA = instrument.brand;
            instrument_efc.MODELO = instrument.model;
            instrument_efc.N_S_ = instrument.numberOfSerie;
            instrument_efc.UBICACIÓN = instrument.ubication;
            instrument_efc.OBSERVACIÓN = instrument.observation;
            instrument_efc.ESTATUS = instrument.status;
            instrument_efc.MAGNITUD = instrument.magnitude;
            instrument_efc.USO = instrument.use;
            instrument_efc.INTERVALO_DE_MEDIA = instrument.meanInterval;

            Instrument_Repository_EFC repository_EFC = new Instrument_Repository_EFC();
            repository_EFC.create(instrument_efc);
        }

        public string deleteInstrument(string id)
        {
            bool instrumentExist = repository.serchInstrument(id);
            if (instrumentExist)
            {
                repository.deleteInstrument(id);
                return "El instrumento se elimino";
            }
            else
            {
                return "El instrumento no existe";
            } 
        }

        public void updateInstrument(Instrument instrument)
        {
            repository.updateInstrument(instrument);
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
