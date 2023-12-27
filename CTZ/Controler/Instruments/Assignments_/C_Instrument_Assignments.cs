using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.Controlador
{
    public abstract class  C_Instrument_Assignments
    {
        public Instrument_Assignment_Repository repository;
        public DateForReport dateForReport;

        public C_Instrument_Assignments() {
            repository = new Instrument_Assignment_Repository();
            dateForReport = new DateForReport();
        }

        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
            repository.updateStatusInstrumentAssignment(idInstrument, status);
        }

    }
}
