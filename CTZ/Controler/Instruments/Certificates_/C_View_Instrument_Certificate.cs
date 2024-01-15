using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
            string dateOfNextCalibration = "";
            try
            {
                DataTable informationInstrumentCertificate = repository.getAllInstrumentCertificate(equino);
                dateOfNextCalibration = informationInstrumentCertificate.Rows[0]["Proxima_Calibracion"].ToString();
                return dateOfNextCalibration.Substring(0, 11);

            }catch (Exception ex)
            {
                MessageBox.Show("Sin fecha de calibración registrada " + ex.Message);
                return "Sin Fecha";
            }
            
        }

        public DataTable getAllInstrumentCertificateByInstrument(string instrument)
        {
            return repository.getAllInstrumentCertificateByInstrument(instrument);
        }

        public DataTable getAllInstrumentCertificateByBrand(string brand)
        {
            return repository.getAllInstrumentCertificateByBrand(brand);
        }

    }
}
