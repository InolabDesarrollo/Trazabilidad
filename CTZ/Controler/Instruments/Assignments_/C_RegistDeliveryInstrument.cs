using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_RegistDeliveryInstrument
    {
        Instrument_Assignment_Repository _repository;
        DateForReport _dateForReport;
        public C_RegistDeliveryInstrument() {
            _repository = new Instrument_Assignment_Repository();
            _dateForReport = new DateForReport();
        }

        public bool registerDeliveryInstrument(Instrument_Assignments instrumentAssignments)
        {
            instrumentAssignments.dateDelivery = _dateForReport.convertToValidDate(instrumentAssignments.dateDelivery);
            instrumentAssignments.approximateDateOfReturn = _dateForReport.convertToValidDate(instrumentAssignments.approximateDateOfReturn);

            return _repository.registerDeliveryInstrument(instrumentAssignments);
        }

        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments, Dictionary<int, string> informationId_Equino)
        {
            instrumentAssignments.dateDelivery = _dateForReport.convertToValidDate(instrumentAssignments.dateDelivery);
            instrumentAssignments.approximateDateOfReturn = _dateForReport.convertToValidDate(instrumentAssignments.approximateDateOfReturn);

            foreach (KeyValuePair<int, string> id_Equino in informationId_Equino)
            {
                _repository.registerDeliveryInstrument(instrumentAssignments, id_Equino.Key, id_Equino.Value);
            }
        }

        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
            _repository.updateStatusInstrumentAssignment(idInstrument, status);
        }

    }
}
