using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_ReturnOfInstrument
    {
        Instrument_Assignment_Repository repository;
        DateForReport dateForReport;
        public C_ReturnOfInstrument()
        {
            dateForReport = new DateForReport();
            repository = new Instrument_Assignment_Repository();
        }

        public bool registerReturnInstrument(Instrument_Assignments instrumentAssignments)
        {
            instrumentAssignments.dateOfReturn = dateForReport.convertToValidDate(instrumentAssignments.dateOfReturn);
            return repository.registerReturnInstrument(instrumentAssignments);
        }
        public void registerReturnInstrument(Instrument_Assignments instrumentAssignments, List<int> idInstruments)
        {
            instrumentAssignments.dateOfReturn = dateForReport.convertToValidDate(instrumentAssignments.dateOfReturn);
            foreach (int element in idInstruments)
            {
                repository.registerReturnInstrument(instrumentAssignments, element);
            }
        }
    }

    
}
