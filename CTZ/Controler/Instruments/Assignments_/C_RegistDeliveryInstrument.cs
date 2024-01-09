using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public class C_RegistDeliveryInstrument: C_Instrument_Assignments
    {
        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments, Dictionary<int, string> informationId_Equino)
        {
            instrumentAssignments.DateDelivery = dateForReport.convertToValidDate(instrumentAssignments.DateDelivery);
            instrumentAssignments.EstimateDateReturn = dateForReport.convertToValidDate(instrumentAssignments.EstimateDateReturn);

            foreach (KeyValuePair<int, string> id_Equino in informationId_Equino)
            {
                repository.registerDeliveryInstrument(instrumentAssignments, id_Equino.Key, id_Equino.Value);
            }
        }

    }
}
