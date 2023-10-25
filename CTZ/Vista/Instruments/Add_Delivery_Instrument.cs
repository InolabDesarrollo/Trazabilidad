using CTZ.Controlador;
using CTZ.Modelo.Browser;
using CTZ.Vista.Responsabilitis;
using MaterialSkin;
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
    public partial class Add_Delivery_Instrument : MaterialForm
    {
        Instrument_Assignments instrumentAssignments;
        Engineer engineer;

        DataTable engineers;
        private  int idInstrument;
        private string equinoInstrument;
        
        public Add_Delivery_Instrument(int idInstrument, string equinoInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;        
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;

            engineer = new Engineer();
            engineers = engineer.getEngineers();
            fillMaterialComboBoxEngineers();
        }
        
        private void fillMaterialComboBoxEngineers()
        {
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string completeNameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                MaterialComboBox_Engineers.Items.Add(completeNameEngineer);
            }
        }
        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            string emailEngineer = engineer.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
            
            instrumentAssignments = new Instrument_Assignments(idInstrument,equinoInstrument,TimePicker_Date_Delivery.Text
                , MaterialComboBox_Engineers.SelectedItem.ToString(),TxtBox_Enterprise.Text,TxtBox_NameEnterprise.Text,
                TxtBox_ObservationDelivery.Text,emailEngineer, TimePicker_Date_Estimate_Return.Text);

            instrumentAssignments.addDeliveryInstrument();
            instrumentAssignments.updateStatus("OCUPADO");
            
            RegistSignature signature = new RegistSignature(idInstrument,equinoInstrument, "Engineer",emailEngineer);
            signature.Show();
            this.Close();
        }

    }
}
