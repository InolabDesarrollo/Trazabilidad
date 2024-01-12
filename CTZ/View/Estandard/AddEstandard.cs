using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.View.Estandard.Assignment;
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

namespace CTZ.View.Estandard
{
    public partial class AddEstandard : MaterialForm
    {
        public AddEstandard()
        {
            InitializeComponent();
            fillComboBoxNumberOfLots();
        }

        private void fillComboBoxNumberOfLots()
        {
            for(int i = 0; i<=5; i++)
            {
                ComBox_Number_Lots.Items.Add(i);
            }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (TxtBox_ESTE.Text.Equals(""))
            {
                MessageBox.Show("Se tiene que agregar el EST");
            }
            else
            {  
                manageEstandard();
            }            
        }

        private void manageEstandard()
        {
            CTZ.View.Responsabilitis.Estandard estandard = new Responsabilitis.Estandard();
            try
            {
                
                estandard.EstatusAssignments = "Sin Asignar";
                estandard.EstEstandard = TxtBox_ESTE.Text;
                estandard.EstandardDescription = TxtBox_Estandard.Text;
                estandard.Use = TxtBox_Use.Text;
                estandard.Brand = TxtBox_Brand.Text;
                estandard.Presentation = TxtBox_Presentation.Text;
                estandard.Number = Convert.ToInt32(ComBox_Number_Lots.SelectedItem.ToString());
                estandard.FabricationDate = TimePicker_FabricationDate.Text;
                estandard.ExpirationDate = TimePicker_ExpirationDate.Text;
                estandard.Quantity = Convert.ToInt32(TxtBox_Quantity.Text);
                estandard.Ubication = TxtBox_Ubication.Text;
                estandard.Estatus = TxtBox_Estatus.Text;
                estandard.Inventory = TxtBox_Inventory.Text;
                estandard.NumberOfAvailableLots = Convert.ToInt32(ComBox_Number_Lots.SelectedItem.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llena todos los campos de estándar de forma correcta " + ex.Message);
            }
           
            addEstandard(estandard);

            if (Switch_Assignment.Checked && !TxtBox_ESTE.Text.Equals(""))
            {
                assignEstandardPermanently(TxtBox_ESTE.Text);
            }
            this.Close();
        }

        private void addEstandard(CTZ.View.Responsabilitis.Estandard estandard)
        {
            C_AddEstandard controlerAdd = new C_AddEstandard();
            controlerAdd.add(estandard);
            MessageBox.Show("El Estandar " + TxtBox_ESTE.Text + " Se agrego correctamente");
        }

        private void assignEstandardPermanently(string estEstandard)
        {
            Permanent_Assignment assignment = new Permanent_Assignment(estEstandard);
            assignment.Show();
            this.Close();
        }

    }
}
