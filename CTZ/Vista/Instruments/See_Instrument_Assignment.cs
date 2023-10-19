using CTZ.Controlador;
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
        public See_Instrument_Assignment(string equinoInstrument)
        {
            InitializeComponent();
            controler = new C_Instrument_Assignments();
            Dgv_Instrument_Assignment.DataSource = controler.selectAllInformationInstrumentAssignment(equinoInstrument);
            Lbl_Equino_Instrument.Text = equinoInstrument;
        }

        public See_Instrument_Assignment(string numberEnterprise,string nameEnterprise)
        {
            InitializeComponent();
            controler = new C_Instrument_Assignments();
            Dgv_Instrument_Assignment.DataSource = controler.selectAllByNumberEnterprise(numberEnterprise);
            Lbl_Equino_Instrument.Text = nameEnterprise;
        }

        private void Dgv_Instrument_Assignment_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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
            Signature signature = new Signature(id);
            signature.Show();
        }
    }
}
