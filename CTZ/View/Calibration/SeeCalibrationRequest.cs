using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CTZ.Controler.Instruments;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;

namespace CTZ.View.Calibration
{

    public partial class SeeCalibrationRequest : Form
    {
        Instruments instrument;
        C_CalibrationRequest controller;
        public SeeCalibrationRequest()
        {
            InitializeComponent();
            controller = new C_CalibrationRequest();
            GridView_CalibrationRequestInstrument.DataSource = controller.getAll();
        }

        private void Btn_Serch_Instrument_Click(object sender, EventArgs e)
        {
            instrument = new Instruments();
            if (instrument.serchInstrument(TxtBox_Instrument.Text))
            {
                GridView_CalibrationRequestInstrument.DataSource = controller.getAllByEquinoInstrument(TxtBox_Instrument.Text);
            }
            else
            {
                MessageBox.Show("El Instrumento no existe ");
            }
        }

        private void Btn_DeleteFilter_Click(object sender, EventArgs e)
        {
            GridView_CalibrationRequestInstrument.DataSource = controller.getAll();
        }

        private void GridView_CalibrationRequestInstrument_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        { 
            if (e.ColumnIndex == 0)
            {
                int idLaboratory = Convert.ToInt32(GridView_CalibrationRequestInstrument[8, e.RowIndex].Value.ToString());
                string idCalibrationRequest = GridView_CalibrationRequestInstrument[5, e.RowIndex].Value.ToString();
                CalibrationRequestReport calibrationRequestReport = new CalibrationRequestReport(idLaboratory,idCalibrationRequest);
                calibrationRequestReport.Show();
            }
        }
    }
}
