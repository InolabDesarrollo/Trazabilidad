using CTZ.Controlador;
using CTZ.Controler.Instruments.Assignments_;
using CTZ.Model.Browser.Interfaces;
using CTZ.Modelo.Browser;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Instruments.Assignment
{
    public partial class Permanently_Assignment_Instrument : MaterialForm
    {
        private readonly string instrument;
        private C_User userControler;
        private DataTable engineers;
        public Instrument_Assignments assignment;
        private C_Permanent_Assignment_Instrument controller;
        private UserRepository userRepository;
        public Permanently_Assignment_Instrument(string instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
            Lbl_Instrument.Text = this.instrument;
            controller = new C_Permanent_Assignment_Instrument();

            userRepository = new UserRepository();
            userControler = new C_User(userRepository);
            engineers = userControler.getEngineers();
            assignment = new Instrument_Assignments();
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

        private void Btn_AddEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(assignment, "Engineer");
            signature.Show();
        }

        private void Btn_Add_Assignment_Click(object sender, EventArgs e)
        {
            assignment.DateDelivery = TimePicker_Date_Delivery.Text;
            assignment.Engineer = MaterialComboBox_Engineers.Text;
            assignment.DeliveryObservations = TxtBox_ObservationDelivery.Text;
            assignment.equinoInstrument = instrument;
            assignment.EngineerEmail = getMailEngineer(MaterialComboBox_Engineers.Text);

            controller.registerPermantlyAssingmentInstrument(assignment);
        }

        private string getMailEngineer(string nameEngineer)
        {
            userRepository = new UserRepository();
            userControler = new C_User(userRepository);
            return userControler.findEmailByName(engineers, nameEngineer);
        }
    }

}

