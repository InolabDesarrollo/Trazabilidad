using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Controler.Estandard.Assignment;
using CTZ.Modelo.Browser;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
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

namespace CTZ.View.Estandard.Assignment
{
    public partial class Permanent_Assignment : MaterialForm
    {
        private readonly string estEstandard;
        private DataTable engineers;
        private C_User userController;
        private UserRepository userRepository;
        private Estandard_Assignment assignment;

        public Permanent_Assignment(string estEstandard)
        {
            InitializeComponent();
            userRepository = new UserRepository();
            userController = new C_User(userRepository);
            engineers = userController.getEngineers();
            fillMaterialComboBoxEngineers();
            assignment = new Estandard_Assignment();
            assignment.EngineerSignature = "";
            this.estEstandard = estEstandard;
            Lbl_Estandard.Text = estEstandard;
        }

        private void fillMaterialComboBoxEngineers()
        {
            ComboBox_Engineers.Items.Add("Sin Asignar");
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string completeNameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                ComboBox_Engineers.Items.Add(completeNameEngineer);
            }
        }

        private void Btn_RegistEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(assignment, "EngineerEstandard");
            signature.Show();
        }

        private void Btn_Add_DeliveryPermanently_Click(object sender, EventArgs e)
        {
            if (assignment.EngineerSignature.Equals(""))
            {
                MessageBox.Show("No se puede registrar la entrega de Estándar si la firma de Ingeniero");
            }
            else
            {
                assignment.DateDelivery = TimePicker_Date_Delivery.Text;
                assignment.Engineer = ComboBox_Engineers.Text;
                assignment.DeliveryObservations = TxtBox_ObservationDelivery.Text;
                assignment.EngineerEmail = getMailEngineer(ComboBox_Engineers.Text);
                assignment.type = "Asignacion";

                C_Permanent_Assignment controller = new C_Permanent_Assignment();
                controller.registerPermanentlyDeliveryEstandard(assignment, estEstandard);
                MessageBox.Show("Se asigno correctamente el estándar al ingeniero " + assignment.Engineer);
                this.Close();
            }          
        }

        private string getMailEngineer(string nameEngineer)
        {
            userRepository = new UserRepository();
            userController = new C_User(userRepository);
            return userController.findEmailByName(engineers, nameEngineer);
        }

    }
}
