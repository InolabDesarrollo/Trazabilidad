using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using Model;
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
        public Instrument_Repository repository_EFC;

        public C_Instrument_Assignments() {
            repository = new Instrument_Assignment_Repository();
            repository_EFC = new Instrument_Repository();

            dateForReport = new DateForReport();
        }

        public void updateStatusInstrumentAssignment(string equinoInstrument, string status)
        {
            repository_EFC.updateStatusInstrumentAssignment(equinoInstrument, status);
        }

    }
}
