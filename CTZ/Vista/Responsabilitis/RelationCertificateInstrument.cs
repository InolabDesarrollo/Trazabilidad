using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public class RelationCertificateInstrument
    {
        private  int idInstrument;
        private  int idCertificate;
        C_RelationCertificateInstrument controler;
        
        public RelationCertificateInstrument(int idInstrument, int idCertificate) {

            controler = new C_RelationCertificateInstrument();

            this.idInstrument = idInstrument;
            this.idCertificate = idCertificate;
        }

        public RelationCertificateInstrument(int idInstrument)
        {
            controler = new C_RelationCertificateInstrument();
            this.idInstrument = idInstrument;
        }

        public RelationCertificateInstrument()
        {

        }
        public void create()
        {
            controler.create(idInstrument, idCertificate);
        }

        public DataTable getAllCertificatesForInstrument()
        {
            return controler.getAllCertificatesForInstrument(idInstrument);
        }

        public void deleteRelation()
        {
            controler.deleteRelation(idInstrument, idCertificate);
        }

        public int calculateDaysForNextCalibration(string equino)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            DataTable instrumentCertificate = controler.getAllInstrumentCertificate(equino);
            DateTime todayDate = DateTime.Today;
            DateTime nextCalibrationDate = Convert.ToDateTime(instrumentCertificate.Rows[0]["Proxima_Calibracion"].ToString());

            int dayDiference = (nextCalibrationDate - todayDate).Days;
            return dayDiference;
        }

        public string getDateForNextCalibration(string equino)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            return controler.getDateForNextCalibration(equino);
        }

    }
}
