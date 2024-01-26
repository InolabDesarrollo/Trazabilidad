using CTZ.Controlador;
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
            Instrument instrument = new Instrument();
            instrument.id = TxtBox_Id.Text;
            instrument.instrument = TxtBox_Instrument.Text;
            instrument.brand = TxBox_Brand.Text;
            instrument.model = TxtBox_Model.Text;
            instrument.numberOfSerie = TxtBox_NumSerie.Text;
            instrument.ubication = ComboBox_Ubication.SelectedItem.ToString();
            instrument.observation = TxtBox_Observation.Text;
            instrument.status = ComboBox_Status.SelectedItem.ToString();
            instrument.magnitude = TxtBox_Magnitud.Text;
            instrument.use = TxtBox_USE.Text;
            instrument.meanInterval = TxtBox_Magnitud.Text;

            C_Instruments controler = new C_Instruments();
            controler.addNewInstrument(instrument);

            if (Switch_Assignment.Checked && !TxtBox_Id.Text.Equals(""))
            {
                Permanently_Assignment_Instrument assignment = new Permanently_Assignment_Instrument(TxtBox_Id.Text);
                assignment.Show();
            }
            MessageBox.Show("Instrumento agregado correctamente");
            this.Close();
        }

    }
}
