using CTZ.Controlador;
using CTZ.Controler.Estandard;
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.View.Estandard.Assignment
{
    public partial class Add_Loan_Estandard : MaterialForm
    {
        private C_Estandard controler;
        public List<string> estandardList;
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

            estandardList = new List<string>();
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
            controler = new C_Estandard();
            if (controler.check(TxtBox_Estandards.Text))
            {
                DataTable estandardInformation = controler.selectEstandardByEST(TxtBox_Estandards.Text);
                if (estandardInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("PRESTADO"))
                {
                    MessageBox.Show("El estandard "+ TxtBox_Estandards.Text + " se encuentra prestado");
                }
                else
                {
                    try
                    {
                        int idEstandard = Convert.ToInt32(estandardInformation.Rows[0]["Id"].ToString());
                        addEstandard(idEstandard, TxtBox_Estandards.Text);
                        TxtBox_Estandards.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message.ToString());
                    }
                }  
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandard(int idEstandard, string estEstandard)
        {
            if (estandardList.Contains(estEstandard))
            {
                MessageBox.Show("El estandard "+estEstandard+" ya fue agregado, no puedes repetirlo");   
            }
            else
            {
                estandardList.Add(estEstandard);
                ComboBox_Estandards.Items.Add(estEstandard);
                MessageBox.Show("Se agrego el Estandard " + estEstandard);
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

                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_User(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
                assignment.EngineerEmail = emailEngineer;

                C_Loan_Estandard controler = new C_Loan_Estandard();
                controler.registerDeliveryEstandard(assignment, estandardList);

                MessageBox.Show("Se creo la asignacion para los estandares ");
                this.Close();
            }  
        }

        private void Btn_DeleteEstandard_Click(object sender, EventArgs e)
        {
            deleteEstandardFromComboBox(ComboBox_Estandards);
        }

        public void deleteEstandardFromComboBox(MaterialComboBox comboBox)
        {
            try
            {
                string estandar = comboBox.SelectedItem.ToString();
                int index = comboBox.FindString(estandar);
                comboBox.Items.RemoveAt(index);
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
