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

    }
}
