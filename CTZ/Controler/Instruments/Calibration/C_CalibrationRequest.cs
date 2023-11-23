using CTZ.Model.Trazabilidad.Instruments;
using CTZ.Modelo;
using CTZ.View.Calibration;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments
{
    public class C_CalibrationRequest
    {
        CalibrationRequest_Repository repository;
        DateForReport dates;
        
        public C_CalibrationRequest() {
            repository = new CalibrationRequest_Repository();
            dates = new DateForReport();    
        }


        public int getId()
        {
            return repository.getId();
        }

        public DataTable getAllById(string id)
        {
            return repository.getAllById(id);
        }

        public void addInstrumentsToRequest(int idCalibrationRequest, List<string> idInstruments)
        {
           repository.addInstrumentsToRequest(idCalibrationRequest, idInstruments);
        }

        public DataTable getAll()
        {
            return repository.getAll();
        }
        public DataTable getAllByEquinoInstrument(string equinoInstrument)
        {
            return repository.getAllByEquinoInstrument(equinoInstrument);
        }

        public DataTable getAllByLaboratory(string laboratory)
        {
            return repository.getAllByLaboratory(laboratory);
        }

        public DataTable getAllByDates(string beganDate, string finalDate)
        {
            beganDate = dates.convertToValidDateDatePicker(beganDate);
            finalDate = dates.convertToValidDateDatePicker(finalDate);

            return repository.getAllByDates(beganDate, finalDate);
        }
    }
}
