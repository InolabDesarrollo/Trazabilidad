using CTZ.Controlador;
using CTZ.Controler.Instruments;
using CTZ.View.Instruments.Assignment;
using MaterialSkin.Controls;
using Model;
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

            Instrumentos instrument = new Instrumentos();
            instrument.ID_Instrumentos = TxtBox_Id.Text;
            instrument.INSTRUMENTO = TxtBox_Instrument.Text;
            instrument.MARCA = TxBox_Brand.Text;
            instrument.MODELO = TxtBox_Model.Text;
            instrument.N_S_ = TxtBox_NumSerie.Text;
            instrument.UBICACIÓN = ComboBox_Ubication.SelectedItem.ToString();
            instrument.OBSERVACIÓN = TxtBox_Observation.Text;
            instrument.ESTATUS = ComboBox_Status.SelectedItem.ToString();
            instrument.MAGNITUD = TxtBox_Magnitud.Text;
            instrument.USO = TxtBox_USE.Text;
            instrument.INTERVALO_DE_MEDIA = TxtBox_Mean_Interval.Text;

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
