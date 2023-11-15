using CTZ.Model.Trazabilidad.Instruments;
using CTZ.Modelo;
using CTZ.View.Calibration;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_CalibrationRequest
    {
        CalibrationRequest_Repository repository;
        
        public C_CalibrationRequest() {
            repository = new CalibrationRequest_Repository();
        }
        public void create(CalibrationRequest calibrationRequest)
        {
            repository.create(calibrationRequest);
        }

        public int getId()
        {
            return repository.getId();
        }

        public void addInstrumentsToRequest(int idCalibrationRequest, List<string> idInstruments)
        {
           repository.addInstrumentsToRequest(idCalibrationRequest, idInstruments);
        }
    }
}
