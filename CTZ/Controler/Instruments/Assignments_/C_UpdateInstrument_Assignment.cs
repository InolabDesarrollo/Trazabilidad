using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_UpdateInstrument_Assignment
    {
        Instrument_Assignment_Repository _repository;
        DateForReport _dateForReport;
        public C_UpdateInstrument_Assignment()
        {
            _repository = new Instrument_Assignment_Repository();
            _dateForReport = new DateForReport();
        }

        public void updateInstrumentAssignment(Instrument_Assignments instrument_Assignments)
        {
            _repository.updateInstrumentAssignment(instrument_Assignments);
        }

    }
}
