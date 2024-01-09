using CTZ.Controler.Instruments;
using CTZ.View.Instruments.Assignment;
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

namespace CTZ.Vista.Responsabilitis
{
    public partial class AddInstrument : MaterialForm
    {
        public AddInstrument()
        {
            InitializeComponent();
        }

        private void Btn_Add_Instrument_Click(object sender, EventArgs e)
        {
            Instruments instrument = new Instruments(TxtBox_Id.Text,TxtBox_Instrument.Text,TxBox_Brand.Text,TxtBox_Model.Text
                ,TxtBox_NumSerie.Text,ComboBox_Ubication.SelectedItem.ToString(),TxtBox_Observation.Text, ComboBox_Status.SelectedItem.ToString(),
                TxtBox_Magnitud.Text,TxtBox_Range.Text,TxtBox_Accessories.Text);
            instrument.addNewInstrument();
            clearMenu();

            if (Switch_Assignment.Checked && !TxtBox_Id.Text.Equals(""))
            {
                Permanently_Assignment_Instrument assignment = new Permanently_Assignment_Instrument(TxtBox_Id.Text);
                assignment.Show();
            }
            MessageBox.Show("Instrumento agregado correctamente");
        }

        private void clearMenu()
        {
            TxtBox_Id.Clear();
            TxtBox_Instrument.Clear();
            TxBox_Brand.Clear();
            TxtBox_Model.Clear();
            TxtBox_NumSerie.Clear();
            TxtBox_Observation.Clear();
            TxtBox_Magnitud.Clear();
            TxtBox_Range.Clear();
            TxtBox_Accessories.Clear();
        }
    }
}
