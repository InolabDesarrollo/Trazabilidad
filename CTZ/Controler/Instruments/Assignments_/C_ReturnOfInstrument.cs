using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_ReturnOfInstrument : C_Instrument_Assignments
    {
        public void registerReturnInstrument(Instrument_Assignments instrumentAssignments, List<int> idInstruments)
        {
            instrumentAssignments.DateOfReturn = dateForReport.convertToValidDate(instrumentAssignments.DateOfReturn);
            foreach (int element in idInstruments)
            {
                repository.registerReturnInstrument(instrumentAssignments, element);
            }
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(int idInstrument)
        {
            return repository.selectMoreRecentInformationInstrumenAssignment(idInstrument);
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(string equinoInstrument)
        {
            return repository.selectMoreRecentInformationInstrumenAssignment(equinoInstrument);
        }

    }

    
}
