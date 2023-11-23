using CTZ.Vista;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Instruments
{
    public partial class Instruments_SubMenu : MaterialForm
    {
        public Instruments_SubMenu()
        {
            InitializeComponent();
        }

        private void Instruments_SubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTest_Instrumentos.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter.Fill(this.trazabilidadTest_Instrumentos.Instrumentos);
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Instrumentos_Certificado' Puede moverla o quitarla según sea necesario.
            this.instrumentos_CertificadoTableAdapter.Fill(this.trazabilidadTestDataSet3.Instrumentos_Certificado);
            colorCellsStatus(8, Dgv_Instruments);
        }

        private void colorCellsStatus(int columnThatNeedColor, DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string valor = dataGridView.Rows[i].Cells[columnThatNeedColor].Value.ToString();
                if (valor.Equals("FUERA DE USO"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Red;
                }
                if (valor.Equals("ACTIVO"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.LightGreen;
                }
                if (valor.Equals("CALIBRANDO"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Orange;
                }
                if (valor.Equals("PENDIENTE"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Blue;
                }
                if (valor.Equals("DISPONIBLE"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.LightGreen;
                }
                if (valor.Equals("OCUPADO"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Orange;
                }
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddInstrument instrument = new AddInstrument();
            instrument.Show();
        }

        private void BtnDelete_Instruments_Click(object sender, EventArgs e)
        {
            DeleteInstrument deleteInstrument = new DeleteInstrument();
            deleteInstrument.Show();
        }

        private void BtnUpdate_Instrument_Click(object sender, EventArgs e)
        {
            SerchInstrument serchInstrument = new SerchInstrument();
            serchInstrument.Show();
        }

        private void TabControl_Instruments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControl_Instruments.SelectedIndex == 1)
            {
                colorDatesOfCalibration(10, Dgv_Instruments_Certificates);
                colorCellsStatus(8,Dgv_Instruments_Certificates);
            }
        }

        private void colorDatesOfCalibration(int columnThatNeedColor, DataGridView dataGridView)
        {
            DateTime todayDate = DateTime.Now;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string date = dataGridView.Rows[i].Cells[columnThatNeedColor].Value.ToString();
                if (!date.Equals(""))
                {
                    DateTime dateOfNextCalibration = Convert.ToDateTime(date);
                    int daysOfDiference = (dateOfNextCalibration - todayDate).Days;

                    if (daysOfDiference >= 0 && daysOfDiference <= 10)
                    {
                        dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Red;
                    }
                    else if (daysOfDiference > 10 && daysOfDiference <= 30)
                    {
                        dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.Orange;
                    }
                    else if (daysOfDiference > 30)
                    {
                        dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.LightGreen;
                    }
                    else
                    {
                        dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.LightGray;
                    }
                }
            }
        }

    }
}
