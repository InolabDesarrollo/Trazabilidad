using ADGV;
using CTZ.Modelo.Documentacion;
using CTZ.View.Calibration;
using CTZ.Vista.Certificates;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using CTZ.Vista.Traceability;
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
        const int columnStatus = 8;
        const int columnInstrumenAssigmments = 14;
        public MenuInstrumentos()
        {
            InitializeComponent();
            colorCells(columnStatus, Dgv_Instruments_Certificates);
        }
        private void MenuInstrumentos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter1.Fill(this.trazabilidadTestDataSet4.Instrumentos);
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Instrumentos_Certificado' Puede moverla o quitarla según sea necesario.
            this.instrumentos_CertificadoTableAdapter2.Fill(this.trazabilidadTestDataSet3.Instrumentos_Certificado);
            this.instrumentosTableAdapter.Fill(this.trazabilidadTest_Instrumentos.Instrumentos);
            this.instrumentos_CertificadoTableAdapter1.Fill(this.trazabilidadTestDataSet2.Instrumentos_Certificado);

            Pnl_Head.BackColor = Color.FromArgb(54, 95, 145);

            colorCells(columnStatus, Dgv_Instruments_Certificates);
            colorCells(columnInstrumenAssigmments, Dgv_Instruments_Certificates);
            colorDatesOfCalibration(10, Dgv_Instruments_Certificates);
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
        private void Dgv_Instruments_Certificates_FilterStringChanged(object sender, EventArgs e)
        {         
            this.instrumentosCertificadoBindingSource1.Filter = Dgv_Instruments_Certificates.FilterString;
            colorCells(columnStatus, Dgv_Instruments_Certificates);
        }

        private void Dgv_Instruments_Certificates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==1)
            {
                updateInstrument(Dgv_Instruments_Certificates, e);
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
            colorCells(7, Dgv_Instrumentos);
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
                if (valor.Equals("DISPONIBLE"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor = Color.LightGreen;
                }
                if (valor.Equals("OCUPADO"))
                {
                    dataGridView.Rows[i].Cells[columnThatNeedColor].Style.BackColor= Color.Orange;
                }
            }
        }

        private void Dgv_Instrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                updateInstrument(Dgv_Instrumentos, e);
            }
        }

        private void updateInstrument(DataGridView dataGridView, DataGridViewCellEventArgs e)
        {
            string idSql = dataGridView[0, e.RowIndex].Value.ToString(); 
            string idInstrument = dataGridView[1, e.RowIndex].Value.ToString();
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

        private void Btn_Traceability_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Traceability);
        }
        private void Btn_Assignments_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Assignments);
        }


        private void Btn_Calibration_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Calibration);
        }

        private void Btn_Add_Calibration_Click(object sender, EventArgs e)
        {
            AddCalibration_Request calibrationRequest = new AddCalibration_Request();
            calibrationRequest.Show();
        }

        private void Btn_AddTraceability_Click(object sender, EventArgs e)
        {
            SerchCertificate serchCertificate = new SerchCertificate();
            serchCertificate.Show();
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

        private void Btn_Serch_Traceability_Click(object sender, EventArgs e)
        {
            SerchTraceabilityLetter traceabilityLetter = new SerchTraceabilityLetter();
            traceabilityLetter.Show();
        }

        private void Btn_Serch_Assignments_Click(object sender, EventArgs e)
        {
            Serch_Instruments_Assignments assignments_Instruments = new Serch_Instruments_Assignments();
            assignments_Instruments.Show();
        }

        private void Btn_Add_Assignments_Click(object sender, EventArgs e)
        {
            Add_Instrument_Assignment assignment = new Add_Instrument_Assignment();
            assignment.Show();
        }

        private void Btn_Regist_Return_Instrument_Click(object sender, EventArgs e)
        {
            Add_Instrument_Assignment assignment = new Add_Instrument_Assignment();
            assignment.Show();

        }

        private void Btn_Add_Assignments_ByGroup_Click(object sender, EventArgs e)
        {
            Add_Delivery_Instrument_ByGroup deliveryInstrument= new Add_Delivery_Instrument_ByGroup();
            deliveryInstrument.Show();
        }

        private void Btn_Regist_Return_Instrument_ByGroup_Click(object sender, EventArgs e)
        {
            Add_Return_Instrument_ByGroup returnOfInstrumentByGroup = new Add_Return_Instrument_ByGroup();
            returnOfInstrumentByGroup.Show();   
        }

        private void Btn_SerchCalibration_Click(object sender, EventArgs e)
        {
            SeeCalibrationRequest seeCalibrationRequest = new SeeCalibrationRequest();
            seeCalibrationRequest.Show();   
        }
    }
}
