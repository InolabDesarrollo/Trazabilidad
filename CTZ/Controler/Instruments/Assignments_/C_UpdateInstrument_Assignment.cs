using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_UpdateInstrument_Assignment: C_Instrument_Assignments
    {
        public void updateInstrumentAssignment(Instrument_Assignments instrument_Assignments)
        {
            repository.updateInstrumentAssignment(instrument_Assignments);
        }

    }
}
