using ADGV;
using CTZ.Modelo.Documentacion;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CTZ.Vista
{
    public partial class MenuInstrumentos : Form
    {
        Responsabilitis.Instruments instrument = new Responsabilitis.Instruments();
        const int columnStatus = 8;
        public MenuInstrumentos()
        {
            InitializeComponent();
            colorCells(columnStatus, Dgv_Instruments_Certificates);
        }
        private void MenuInstrumentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTest_Instrumentos.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter.Fill(this.trazabilidadTest_Instrumentos.Instrumentos);
            this.instrumentos_CertificadoTableAdapter1.Fill(this.trazabilidadTestDataSet2.Instrumentos_Certificado);
            colorCells(columnStatus, Dgv_Instruments_Certificates);
            colorDatesOfCalibration(10, Dgv_Instruments_Certificates);
        }

        private void colorDatesOfCalibration(int columnThatNeedColor, DataGridView dataGridView)
        {
            DateTime dateOfToday = DateTime.Now;
            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                string valor = dataGridView.Rows[i].Cells[columnThatNeedColor].Value.ToString();
                if (!valor.Equals(""))
                {
                    DateTime dateOfNextCalibration = Convert.ToDateTime(valor);
                    int daysOfDiference = (dateOfNextCalibration - dateOfToday).Days;

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

        private void Dgv_Instruments_Certificates_FilterStringChanged(object sender, EventArgs e)
        {
            this.instrumentosCertificadoBindingSource1.Filter = Dgv_Instruments_Certificates.FilterString;
            colorCells(columnStatus, Dgv_Instruments_Certificates);
        }

        private void Dgv_Instruments_Certificates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    updateInstrument(Dgv_Instruments_Certificates, e);
                    break;
            }
        }
        private void Btn_Instruments_Certificates_Click(object sender, EventArgs e)
        {
            Dgv_Instruments_Certificates.Visible = true;
            colorCells(columnStatus, Dgv_Instruments_Certificates);
        }
        private void Dgv_Instrumentos_FilterStringChanged(object sender, EventArgs e)
        {
            this.instrumentosBindingSource.Filter = Dgv_Instrumentos.FilterString;
            colorCells(columnStatus, Dgv_Instrumentos);
        }

        private void Btn_All_Instruments_Click(object sender, EventArgs e)
        {
            colorCells(columnStatus, Dgv_Instrumentos);
            Dgv_Instruments_Certificates.Visible = false;
        }

        private void colorCells(int columnThatNeedColor, DataGridView dataGridView)
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
            }
        }

        private void Dgv_Instrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    updateInstrument(Dgv_Instrumentos, e);
                    break;
            }
        }

        private void updateInstrument(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            string idSql = Dgv_Instrumentos[0, e.RowIndex].Value.ToString();
            string idInstrument = Dgv_Instrumentos[1, e.RowIndex].Value.ToString();
            UpdateInstrument instrument = new UpdateInstrument(idInstrument, idSql);
            instrument.Show();
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

        private void Btn_See_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_See);
        }

        private void Btn_Regist_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Regist);
        }

        private void Btn_Calendars_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Calendar);
        }

        private void Btn_General_Calendar_Click(object sender, EventArgs e)
        {
            Report report = new Report("Calendario_Instrumentos_General");
            report.Show();
        }

        private void showMenu(System.Windows.Forms.Panel panel)
        {
            if (!panel.Visible)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

       
    }
}
