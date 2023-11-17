using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ADGV;
using CTZ.Controler.Instruments;
using CTZ.Controler.Trazabilidad;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;

namespace CTZ.View.Calibration
{

    public partial class SeeCalibrationRequest : Form
    {
        Instruments instrument;
        C_CalibrationRequest controller;
        C_Laboratories controllerlaboratories;
        private DataTable laboratories;
        private string laboratory;
        public SeeCalibrationRequest()
        {
            InitializeComponent();
            controller = new C_CalibrationRequest();
            Dgv_CalibrationRequestByInstrument.DataSource = controller.getAll();
            fillMaterialComboBoxLaboratories();
        }

        private void fillMaterialComboBoxLaboratories()
        {
            controllerlaboratories = new C_Laboratories();
            laboratories = controllerlaboratories.selectLaboratories();

            for (int i = 0; i < laboratories.Rows.Count; i++)
            {
                ComboBox_Laboratory.Items.Add(laboratories.Rows[i]["Nombre_Abreviado"].ToString());
            }
        }

        private void Dgv_CalibrationRequestByInstrument_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lookCalibrationReport(e, Dgv_CalibrationRequestByInstrument);
        }

        private void lookCalibrationReport(DataGridViewCellEventArgs e, AdvancedDataGridView dataGridView)
        {
            if (e.ColumnIndex == 0)
            {
                int idLaboratory = Convert.ToInt32(dataGridView[8, e.RowIndex].Value.ToString());
                string idCalibrationRequest = dataGridView[5, e.RowIndex].Value.ToString();
                CalibrationRequestReport calibrationRequestReport = new CalibrationRequestReport(idLaboratory, idCalibrationRequest);
                calibrationRequestReport.Show();
            }
        }

        private void Btn_Serch_Instrument_Click(object sender, EventArgs e)
        {
            instrument = new Instruments();
            if (instrument.serchInstrument(TxtBox_Instrument.Text))
            {
                Dgv_CalibrationRequestByInstrument.DataSource = controller.getAllByEquinoInstrument(TxtBox_Instrument.Text);
            }
            else
            {
                MessageBox.Show("El Instrumento no existe ");
            }
        }

        private void Btn_DeleteFilter_Click(object sender, EventArgs e)
        {
            Dgv_CalibrationRequestByInstrument.DataSource = controller.getAll();
        }

        private void Btn_CreateCalibrationRequest_Click(object sender, EventArgs e)
        {
            AddCalibration_Request addCalibrationRequest = new AddCalibration_Request();
            addCalibrationRequest.Show();
        }

        private void Btn_SelectLaboratory_Click(object sender, EventArgs e)
        {
            try
            {
                laboratory = ComboBox_Laboratory.SelectedItem.ToString();
                Dgv_CalibrationRequestByLaboratory.DataSource = controller.getAllByLaboratory(laboratory);

            }catch (Exception ex)
            {
                MessageBox.Show("Selecciona un laboratorio "+ex.Message);
            }
        }

        private void Dgv_CalibrationRequestByLaboratory_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lookCalibrationReport(e, Dgv_CalibrationRequestByLaboratory);
        }

        private void Btn_SelectByDates_Click(object sender, EventArgs e)
        {
           Dgv_CalibrationRequestByDates.DataSource= controller.getAllByDates(TimePicker_Began.Text,TimePicker_Final.Text);
        }

        private void Btn_DeleteFilterDates_Click(object sender, EventArgs e)
        {
            Dgv_CalibrationRequestByDates.DataSource = controller.getAll();
        }

        private void Dgv_CalibrationRequestByDates_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           lookCalibrationReport(e,Dgv_CalibrationRequestByDates);
        }


    }
}
