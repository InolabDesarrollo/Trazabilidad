using CTZ.Controlador;
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
        C_Instrument_Assignments controler;
        private const int engineerSignature = 7;
        private const int qualitySignature = 11;
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
            controler = new C_Instrument_Assignments();
        }

        private void Dgv_Instrument_Assignment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == engineerSignature)
            {
                showSignature(e);
            }
            if (e.ColumnIndex == qualitySignature)
            {
                showSignature(e);
            }
        }

        private void showSignature(DataGridViewCellEventArgs e)
        {
            int id = Convert.ToInt32(Dgv_Instrument_Assignment[0, e.RowIndex].Value.ToString());
            Signature signature = new Signature(id,e.ColumnIndex);
            signature.Show();
        }

        private void See_Instrument_Assignment_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Instrumentos' Puede moverla o quitarla según sea necesario.
            this.instrumentosTableAdapter.Fill(this.trazabilidadTestDataSet4.Instrumentos);
        }

        private void Btn_Filter_Click(object sender, EventArgs e)
        {
            DateForReport dates = new DateForReport();

            dates.dateBegan=  dates.convertToValidDate(TimePicker_DateBegan.Text);
            dates.dateFinal= dates.convertToValidDate(TimePicker_DateFinal.Text);
            
            switch (kindOfSerch)
            {
                case "Instrument":
                    Dgv_Instrument_Assignment.DataSource = controler.selectAllByEquinoAndDates(instrumentAssignment.Rows[0]["Equino_Instrumento"].ToString(),
                        dates);
                    break;
                case "Enterprise":
                    string numberEnterprise = instrumentAssignment.Rows[0]["Ingeniero"].ToString();
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
