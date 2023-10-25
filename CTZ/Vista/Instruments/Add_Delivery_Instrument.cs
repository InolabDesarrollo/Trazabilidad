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
        C_Instrument_Assignments controler;
        Instrument_Assignments instrumentAssignments;
        Engineer engineer;

        private  int idInstrument;
        private string equinoInstrument;
        DataTable engineers;
        public Add_Delivery_Instrument(int idInstrument, string equinoInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;       

            instrumentAssignments = new Instrument_Assignments();  
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
            controler = new C_Instrument_Assignments();
            string emailEngineer = engineer.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());  

            instrumentAssignments.idInstrument = idInstrument;
            instrumentAssignments.equinoInstrument = equinoInstrument;
            instrumentAssignments.dateDelivery = TimePicker_Date_Delivery.Text;
            
            instrumentAssignments.engineer = MaterialComboBox_Engineers.SelectedItem.ToString();
            instrumentAssignments.numberEnterprise = TxtBox_Enterprise.Text;
            instrumentAssignments.nameEnterprise = TxtBox_NameEnterprise.Text;
            instrumentAssignments.observationDelivery = TxtBox_ObservationDelivery.Text;

            instrumentAssignments.mailEngineer = emailEngineer;
            instrumentAssignments.approximateDateOfReturn = TimePicker_Date_Estimate_Return.Text;
            bool updateData= controler.registerDeliveryInstrument(instrumentAssignments);
            updateStatusInstrument(updateData);
            
            RegistSignature signature = new RegistSignature(idInstrument,equinoInstrument, "Engineer",emailEngineer);
            signature.Show();
            this.Close();
        }


        private void updateStatusInstrument(bool update)
        {
            if (update)
            {
                controler.updateStatusInstrumentAssignment(idInstrument, "OCUPADO");
            }
        }
    }
}
