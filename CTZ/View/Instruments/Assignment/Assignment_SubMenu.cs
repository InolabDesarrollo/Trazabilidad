using CTZ.Vista.Instruments;
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

namespace CTZ.View.Instruments.Assignment
{
    public partial class Assignment_SubMenu : MaterialForm
    {
        public Assignment_SubMenu()
        {
            InitializeComponent();
        }

        private void Btn_Serch_Assignments_Click(object sender, EventArgs e)
        {
            Serch_Instruments_Assignments assignments_Instruments = new Serch_Instruments_Assignments();
            assignments_Instruments.Show();
        }

        private void Btn_Add_Assignments_Click(object sender, EventArgs e)
        {
            Serch_Instruments_Assignments assignments_Instruments = new Serch_Instruments_Assignments();
            assignments_Instruments.Show();
        }

        private void Btn_Regist_Return_Instrument_Click(object sender, EventArgs e)
        {
            Add_Instrument_Assignment assignment = new Add_Instrument_Assignment();
            assignment.Show();
        }

        private void Btn_Add_Assignments_ByGroup_Click(object sender, EventArgs e)
        {
            Add_Delivery_Instrument_ByGroup deliveryInstrument = new Add_Delivery_Instrument_ByGroup();
            deliveryInstrument.Show();
        }

        private void Btn_Regist_Return_Instrument_ByGroup_Click(object sender, EventArgs e)
        {
            Add_Return_Instrument_ByGroup returnOfInstrumentByGroup = new Add_Return_Instrument_ByGroup();
            returnOfInstrumentByGroup.Show();
        }
    }
}
