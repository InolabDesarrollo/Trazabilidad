using ADGV;
using CTZ.Controlador;
using CTZ.Controler.Instruments;
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
        private C_SerchInstrument controler;
        private static DataTable instrumentTable;
        private const int columnNextCalibration = 9;
        private const int columnStatusForDvgInstruments = 10; 
        private const int columnStatusForDgvInstrumentsCertificates= 7;
        public Instruments_SubMenu()
        {
            InitializeComponent();
            controler = new C_SerchInstrument();
        }

        private void Instruments_SubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet31.Instrumentos_Certificado' Puede moverla o quitarla según sea necesario.
            this.instrumentos_CertificadoTableAdapter.Fill(this.trazabilidadTestDataSet31.Instrumentos_Certificado);
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTest_Instrumentos.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter.Fill(this.trazabilidadTest_Instrumentos.Instrumentos);
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Instrumentos_Certificado' Puede moverla o quitarla según sea necesario.
            this.instrumentos_CertificadoTableAdapter.Fill(this.trazabilidadTestDataSet3.Instrumentos_Certificado);
            colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
        }

        private void colorCellsStatus(int columnThatNeedColor, DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Rows.Count; i++)
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
                colorDatesOfCalibration(columnNextCalibration, Dgv_Instruments_Certificates);
                colorCellsStatus(columnStatusForDgvInstrumentsCertificates, Dgv_Instruments_Certificates);
            }
        }

        private void colorDatesOfCalibration(int columnThatNeedColor, DataGridView dataGridView)
        {
            try
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
            }catch (Exception ex)
            {
                MessageBox.Show("Error  " + ex.Message);
            }
        }

        private void Btn_SerchInstrument_Click(object sender, EventArgs e)
        {
            if (controler.serchInstrumenByEquino(TxtBox_Equino.Text))
            {
                Dgv_Instruments.DataSource = controler.selectAllFromInstrumentByEquino(TxtBox_Equino.Text);
                colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
            }
            else
            {
                MessageBox.Show("El instrumento no existe, o dejaste el campo vacio");
            }

        }

        private void Btn_SerchByInstrumentName_Click(object sender, EventArgs e)
        {
            
            Dgv_Instruments.DataSource = controler.selectAllByInstrumentName(TxtBox_InstrumentName.Text);
            colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
        }

        private void Btn_SerchByBrand_Click(object sender, EventArgs e)
        {
            Dgv_Instruments.DataSource = controler.selectAllByBrand(TxtBox_Brand.Text);
            colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
        }

        private void Dgv_Instruments_FilterStringChanged(object sender, EventArgs e)
        {
            this.instrumentosBindingSource1.Filter =this.Dgv_Instruments.FilterString;
            colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
        }

        private void Btn_ClearFilterInstruments_Click(object sender, EventArgs e)
        {
            Dgv_Instruments.DataSource = instrumentosBindingSource1;
            colorCellsStatus(columnStatusForDvgInstruments, Dgv_Instruments);
            TxtBox_Brand.Clear();
            TxtBox_Equino.Clear();
            TxtBox_InstrumentName.Clear();
        }

        private void Btn_Equino_InstrumentsCertificates_Click(object sender, EventArgs e)
        {
            if (controler.serchInstrumenByEquino(TxtBox_InstrumentsCertificatesEquino.Text))
            {
                C_View_Instrument_Certificate cotrolerInstrumentCertificate = new C_View_Instrument_Certificate();
                Dgv_Instruments_Certificates.DataSource = cotrolerInstrumentCertificate.getAllInstrumentCertificate(TxtBox_InstrumentsCertificatesEquino.Text);
                colorCellsStatus(columnStatusForDgvInstrumentsCertificates, Dgv_Instruments_Certificates);
                colorDatesOfCalibration(columnNextCalibration, Dgv_Instruments_Certificates);
            }
            else
            {
                MessageBox.Show("El instrumento no existe, o dejaste el campo vacio");
            }
        }

        private void Btn_Instruments_Certificates_Click(object sender, EventArgs e)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            Dgv_Instruments_Certificates.DataSource=controler.getAllInstrumentCertificateByInstrument(TxtBox_InstrumentNameCertificates.Text);
            colorCellsStatus(columnStatusForDgvInstrumentsCertificates, Dgv_Instruments_Certificates);
            colorDatesOfCalibration(columnNextCalibration, Dgv_Instruments_Certificates);
        }

        private void Btn_Serch_Instrument_CertificatesBrand_Click(object sender, EventArgs e)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            Dgv_Instruments_Certificates.DataSource = controler.getAllInstrumentCertificateByBrand(TxtBox_InstrumentsCertificatesBrand.Text);
            colorCellsStatus(columnStatusForDgvInstrumentsCertificates, Dgv_Instruments_Certificates);
            colorDatesOfCalibration(columnNextCalibration, Dgv_Instruments_Certificates);
        }

        private void Btn_ClearFilterInstrumentCertificate_Click(object sender, EventArgs e)
        {
            Dgv_Instruments_Certificates.DataSource = instrumentosCertificadoBindingSource2;
            colorCellsStatus(columnStatusForDgvInstrumentsCertificates, Dgv_Instruments_Certificates);
            colorDatesOfCalibration(columnNextCalibration, Dgv_Instruments_Certificates);
            TxtBox_InstrumentNameCertificates.Clear();
            TxtBox_InstrumentsCertificatesBrand.Clear();
            TxtBox_InstrumentsCertificatesEquino.Clear();
        }

        private void Dgv_Instruments_Certificates_FilterStringChanged(object sender, EventArgs e)
        {
            this.instrumentosCertificadoBindingSource4.Filter = this.Dgv_Instruments_Certificates.FilterString;

        }
    }
}
