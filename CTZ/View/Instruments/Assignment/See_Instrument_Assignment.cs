using CTZ.Controlador;
using CTZ.Controler.Instruments.Assignments_;
using CTZ.View;
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

namespace CTZ.Vista.Instruments
{
    public partial class See_Instrument_Assignment : Form
    {
        private C_ConsultInstrument_Assignment controler;
        private const int engineerSignature = 6;
        private const int qualitySignature = 10;
        private const int returnEngineerSignature = 13;
        private const int updateAssignment = 0;
        private string kindOfSerch;
        DataTable instrumentAssignment;
        
        public See_Instrument_Assignment(string equinoInstrument)
        {
            initComponents();
            instrumentAssignment = controler.selectAllInformationInstrumentAssignment(equinoInstrument);
            Dgv_Instrument_Assignment.DataSource = instrumentAssignment;
            Lbl_Title.Text = equinoInstrument;
            kindOfSerch = "Instrument";
        }

        public See_Instrument_Assignment(string numberEnterprise,string nameEnterprise)
        {
            initComponents();
            instrumentAssignment = controler.selectAllByNumberEnterprise(numberEnterprise);
            Dgv_Instrument_Assignment.DataSource = instrumentAssignment;
            Lbl_Title.Text = nameEnterprise;
            kindOfSerch = "Enterprise";
        }

        public See_Instrument_Assignment(DataTable instrumenAssignmentByEngineer)
        {
            initComponents();
            instrumentAssignment = instrumenAssignmentByEngineer;
            Dgv_Instrument_Assignment.DataSource = instrumentAssignment;
            Lbl_Title.Text = "Ingeniero "+ instrumentAssignment.Rows[0]["Ingeniero"].ToString();
            kindOfSerch = "Engineer";
        }

        private void initComponents()
        {
            InitializeComponent();
            controler = new C_ConsultInstrument_Assignment();
        }

        private void Dgv_Instrument_Assignment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == engineerSignature  || e.ColumnIndex==updateAssignment)
            {
                showSignature(e);
            }
            if (e.ColumnIndex == qualitySignature)
            {
                showSignature(e);
            }
            if (e.ColumnIndex == returnEngineerSignature)
            {
                showSignature(e);
            }
            if (e.ColumnIndex==updateAssignment)
            {
                updateInstrumentAssignment(e);
            }
        }

        private void showSignature(DataGridViewCellEventArgs e)
        {
            string signature = Dgv_Instrument_Assignment[e.ColumnIndex, e.RowIndex].Value.ToString();
            Show_Signature show = new Show_Signature(signature) ;
            show.Show();
        }

        private void updateInstrumentAssignment(DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(Dgv_Instrument_Assignment[0, e.RowIndex].Value.ToString());
            string idEquino = Dgv_Instrument_Assignment[12, e.RowIndex].Value.ToString();

            Update_Instrument_Assignment update = new Update_Instrument_Assignment(id, idEquino);
            update.Show();
        }

        private void See_Instrument_Assignment_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter.Fill(this.trazabilidadTestDataSet4.Instrumentos);
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            DateForReport dates = new DateForReport(TimePicker_DateBegan.Text, TimePicker_DateFinal.Text);        
            switch (kindOfSerch)
            {
                case "Instrument":
                    Dgv_Instrument_Assignment.DataSource = controler.selectAllByEquinoAndDates(instrumentAssignment.Rows[0]["Equino_Instrumento"].ToString(),
                        dates);
                    break;
                case "Enterprise":
                    string numberEnterprise = instrumentAssignment.Rows[0]["Folio_Empresa"].ToString();
                    Dgv_Instrument_Assignment.DataSource = controler.selectAllByNumberEnterpriseAndDates(numberEnterprise, dates);
                    break;
                case "Engineer":
                    string engineer = instrumentAssignment.Rows[0]["Ingeniero"].ToString();
                    Dgv_Instrument_Assignment.DataSource = controler.selectAllByEngineer(engineer, dates);
                    break;
            }
        }

        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            Dgv_Instrument_Assignment.DataSource = instrumentAssignment;
        }

    }
}
