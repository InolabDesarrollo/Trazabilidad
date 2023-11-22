using CTZ.Model.Trazabilidad.Instruments;
using CTZ.View.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Calibration
{
    public class C_CreateCalibrationRequest
    {
        private readonly int idLaboratory;
        private readonly string date;
        private readonly List<string> idInstruments;
        private readonly string numberOfReport;
        CalibrationRequest_Repository repository;
        public C_CreateCalibrationRequest(int idLaboratory, string date, List<string> idInstruments, string numberOfReport) {
            repository = new CalibrationRequest_Repository();
            this.idLaboratory = idLaboratory;
            this.date = date;
            this.idInstruments = idInstruments;
            this.numberOfReport = numberOfReport;   
        }

        public void create()
        {
            repository.create(this.idLaboratory,this.date,this.numberOfReport );
            int idCalibrationRequest = repository.getId();
            repository.addInstrumentsToRequest(idCalibrationRequest, this.idInstruments);
        }

        public int getId()
        {
            return repository.getId();
        }

    }
}
