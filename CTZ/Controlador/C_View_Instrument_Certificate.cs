using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public  class C_View_Instrument_Certificate
    {
        View_Instrument_Certificate_Repository repository;
        public C_View_Instrument_Certificate() {

            repository = new View_Instrument_Certificate_Repository();
        }

        public DataTable getAllInstrumentCertificate(string equino)
        {
            return repository.getAllInstrumentCertificate(equino);
        }

        public string getDateForNextCalibration(string equino)
        {
            DataTable informationInstrumentCertificate = repository.getAllInstrumentCertificate(equino);
            string dateOfNextCalibration = informationInstrumentCertificate.Rows[0]["Proxima_Calibracion"].ToString();
            if (dateOfNextCalibration.Equals(""))
            {
                dateOfNextCalibration = "Sin fecha";
                return dateOfNextCalibration;
            }
            return dateOfNextCalibration.Substring(0,11);
        }
    }
}
