using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_Instrument_Assignments
    {
        Instrument_Assignment_Repository _repository;
        public C_Instrument_Assignments() {
            _repository = new Instrument_Assignment_Repository();
        }

        public bool registerDeliveryInstrument(Instrument_Assignments instrumentAssignments)
        {
            return _repository.registerDeliveryInstrument(instrumentAssignments);
        }

        public void updateSignatureEngineer(int idInstrument, string engineerSignature)
        {
            _repository.updateSignatureEngineer(idInstrument, engineerSignature);
        }
    }
}
