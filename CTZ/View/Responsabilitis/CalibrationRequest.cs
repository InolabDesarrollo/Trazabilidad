using CTZ.Controler.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.View.Responsabilitis
{
    public class CalibrationRequest
    {
        public  int idLaboratory;
        public  string dateOfRequest;
        public int idCalibrationRequest;
        public readonly List<string> idInstruments;
        C_CalibrationRequest controler;

        public CalibrationRequest(int idLaboratory, string dateOfRequest,List<string> idInstruments) {
            controler = new C_CalibrationRequest();
            this.idLaboratory = idLaboratory;
            this.dateOfRequest = dateOfRequest;
            this.idInstruments = idInstruments;
        }

        public void create()
        {
            CalibrationRequest calibrationRequest = new CalibrationRequest(this.idLaboratory,this.dateOfRequest,this.idInstruments);
            controler.create(calibrationRequest);
            this.idCalibrationRequest = controler.getId();
            controler.addInstrumentsToRequest(idCalibrationRequest,this.idInstruments);
        }

        
    }
}
