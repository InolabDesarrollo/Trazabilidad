using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.View.Responsabilitis;
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

namespace CTZ.View.Estandard.Assignment
{
    public partial class Add_Delivery_Estandard : MaterialForm
    {
        private C_Estandard controler;
        private static Dictionary<int, string> informationEstandards;
        private C_Usuario usuarioControler;
        private DataTable engineers;
        public Add_Delivery_Estandard()
        {
            InitializeComponent();
            informationEstandards = new Dictionary<int, string>();
            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_Usuario(userRepository);

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
                addEstandard();
                DataTable estandardInformation= controler.selectEstandardByEST(TxtBox_Estandards.Text);
                int idEstandard = Convert.ToInt32(estandardInformation.Rows[0]["Id"].ToString());
                informationEstandards.Add(idEstandard, TxtBox_Estandards.Text);
                TxtBox_Estandards.Clear();
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandard()
        {
            ComboBox_Estandards.Items.Add(TxtBox_Estandards.Text);
            MessageBox.Show("Se agrego el Estandard " + TxtBox_Estandards.Text);
        }

        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            Estandard_Assignment assignment = new Estandard_Assignment();
            assignment.DateDelivery = TimePicker_Date_Delivery.Text;
            assignment.Engineer= MaterialComboBox_Engineers.Text;
            assignment.NumberEnterprise = TxtBox_Enterprise.Text;
            assignment.NameEnterprise = TxtBox_NameEnterprise.Text;
            assignment.DeliveryObservations = TxtBox_ObservationDelivery.Text;
            assignment.EstimateDateReturn = TimePicker_Date_Estimate_Return.Text;

            RegistSignature signature = new RegistSignature(assignment, informationEstandards);
            signature.Show();   
        }
    }
}
