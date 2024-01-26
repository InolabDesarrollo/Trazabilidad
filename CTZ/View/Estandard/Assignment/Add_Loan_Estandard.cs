using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Controler.Estandard.Assignment;
using CTZ.Modelo.Browser;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace CTZ.View.Estandard.Assignment
{
    public partial class Add_Loan_Estandard : MaterialForm
    {
        private C_Estandard controler;
        public List<string> standardList;
        private C_User usuarioControler;
        private DataTable engineers;
        public static Estandard_Assignment assignment;

        public Add_Loan_Estandard()
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
                bool standarWasBorrowed = controler.checkIfStandarWasBorrowed(standar);
                if (standarWasBorrowed)
                {
                    MessageBox.Show("El estándar " + standar + " se encuentra prestado o asignado");
                }
                else
                {
                    addEstandardToList(standar);
                }
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
                if (standardList.Contains(standar))
                {
                    MessageBox.Show("El estandard " + standar + " ya fue agregado, no puedes repetirlo");
                }
                else
                {
                    standardList.Add(standar);
                    ComboBox_Estandards.Items.Add(standar);
                    MessageBox.Show("Se agrego el Estandard " + standar);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message.ToString());
            }  
            TxtBox_Estandards.Clear();
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
                assignment.Type = "Prestamo";
                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_User(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
                assignment.EngineerEmail = emailEngineer;

                C_Loan_Standar_Complete controler = new C_Loan_Standar_Complete();
                controler.registerDeliveryStandar(assignment, standardList);

                MessageBox.Show("Se creo la asignacion para los estandares ");
                this.Close();
            }  
        }

        private void Btn_DeleteEstandard_Click(object sender, EventArgs e)
        {
            try
            {
                string estandar = ComboBox_Estandards.SelectedItem.ToString();
                int index = ComboBox_Estandards.FindString(estandar);
                ComboBox_Estandards.Items.RemoveAt(index);
                MessageBox.Show("Estándar " + estandar + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Estándar");
            }
        }

    }
}
