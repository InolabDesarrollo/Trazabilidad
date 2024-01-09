using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void addNewInstrument(Instruments instrument)
        {
            repository.addNewInstrument(instrument);
        }

        public void deleteInstrument(string id)
        {
            repository.deleteInstrument(id);
        }
        public void updateInstrument(Instruments instrument)
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

            if (statusAssignments.Equals("DISPONIBLE"))
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
