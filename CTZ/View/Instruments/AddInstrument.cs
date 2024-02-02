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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public partial class AddInstrument : MaterialForm
    {
        private static int numberOfAccessories;
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

            this.checkIfCanCreateNewInstrument(instrument);         
        }

        private void checkIfCanCreateNewInstrument(Instrumentos instrument)
        {
            C_Instruments controler = new C_Instruments();
            bool instrumentWasCreate = controler.addNewInstrument(instrument);
            if (instrumentWasCreate)
            {
                MessageBox.Show("Se creo instrumento con exito");
                if (Switch_Assignment.Checked && !TxtBox_Id.Text.Equals(""))
                {
                    Permanently_Assignment_Instrument assignment = new Permanently_Assignment_Instrument(TxtBox_Id.Text);
                    assignment.Show();
                }
                MessageBox.Show("Instrumento agregado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Instrumento ya existe, cambia el Equino");
            }
        }

        private void Btn_Add_Accessory_Click(object sender, EventArgs e)
        {
            numberOfAccessories++;
            
        }

        private bool checkIfThereIsAnEquino()
        {
            if (TxtBox_Id.Text.Equals(""))
            {
                return false;
            }
            else
            {
                return true;
            }
            
        }
    }
}
