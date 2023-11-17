﻿using CTZ.Model.Trazabilidad.Instruments;
using CTZ.Modelo;
using CTZ.View.Calibration;
using CTZ.View.Responsabilitis;
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
            beganDate = dates.convertToValidDate(beganDate);
            finalDate = dates.convertToValidDate(finalDate);

            return repository.getAllByDates(beganDate, finalDate);
        }
    }
}
