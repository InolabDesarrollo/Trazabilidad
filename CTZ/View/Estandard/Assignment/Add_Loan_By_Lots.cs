using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
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

namespace CTZ.View.Estandard.Assignment
{
    public partial class Add_Loan_By_Lots : MaterialForm
    {
        private C_Estandard controler;
        public List<string> standardList;
        private C_User usuarioControler;
        private DataTable engineers;
        public static Estandard_Assignment assignment;

        public Add_Loan_By_Lots()
        {
            InitializeComponent();

            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_User(userRepository);
            assignment = new Estandard_Assignment();
            assignment.EngineerSignature = "";

            standardList = new List<string>();
            engineers = usuarioControler.getEngineers();
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

        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            string standar = TxtBox_Estandards.Text;
            controler = new C_Estandard();
            if (controler.checkIfEstandarExist(standar))
            {
                addEstandardToList(standar);
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandardToList(string standar)
        {
            try
            {
                standardList.Add(standar);
                ComboBox_Estandards.Items.Add(standar);
                MessageBox.Show("Se agrego el Estandard " + standar);
                fillNumberOfLotsAvailable(standar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message.ToString());
            }
            TxtBox_Estandards.Clear();
            fillAvailableLots(standar);
        }

        private void fillNumberOfLotsAvailable(string standar)
        {
            controler = new C_Estandard();
            int numberOfLotsAvailable = controler.getNumberOfLotsAvailable(standar);
            for (int i = 0; i < numberOfLotsAvailable; i++)
            {
                ComBox_Number_Lots.Items.Add(i);
            }
        }

        private void fillAvailableLots(string standar)
        {
            controler = new C_Estandard();
            int numberOfLotsAvailable = controler.getNumberOfLotsAvailable(standar);
            for(int i = 1; i <= numberOfLotsAvailable; i++)
            {
                ComBox_Number_Lots.Items.Add(i);
            }
        }

        private void Btn_RegistEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(assignment, "EngineerEstandard");
            signature.Show();
        }

        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            if (assignment.EngineerSignature.Equals(""))
            {
                MessageBox.Show("No puedes prestar un estándar sin registrar la firma del Ingeniero");
            }
            else
            {
                assignment.DateDelivery = TimePicker_Date_Delivery.Text;
                assignment.Engineer = MaterialComboBox_Engineers.Text;
                assignment.NumberEnterprise = TxtBox_Enterprise.Text;
                assignment.NameEnterprise = TxtBox_NameEnterprise.Text;
                assignment.DeliveryObservations = TxtBox_ObservationDelivery.Text;
                assignment.EstimateDateReturn = TimePicker_Date_Estimate_Return.Text;
                assignment.NumberOfLots = Convert.ToInt32(ComBox_Number_Lots.SelectedItem.ToString());
                assignment.type = "Prestamo_Por_Lotes";

                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_User(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
                assignment.EngineerEmail = emailEngineer;

                C_Loan_Estandard controler = new C_Loan_Estandard();
                controler.registerDeliveryEstandardByLots(assignment, standardList);

                MessageBox.Show("Se creo la asignacion para los estandares ");
                this.Close();
            }
        }
    }
}
