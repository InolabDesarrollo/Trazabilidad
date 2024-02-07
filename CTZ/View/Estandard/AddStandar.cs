using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.View.Estandard.Assignment;
using CTZ.View.Responsabilitis;
using MaterialSkin.Controls;
using Model;
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
    public partial class AddStandar : MaterialForm
    {
        public AddStandar()
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
            Estandares standar = new Estandares();
            try
            {   
                standar.Estatus_Prestamo = "Sin Asignar";
                standar.Id_Estandares = TxtBox_ESTE.Text;
                standar.Estandar = TxtBox_Estandard.Text;
                standar.Uso = TxtBox_Use.Text;
                standar.Marca = TxtBox_Brand.Text;
                standar.Presentacion = TxtBox_Presentation.Text;
                standar.NoLote = ComBox_Number_Lots.SelectedItem.ToString();
                standar.FechaDeFabricacion = TimePicker_FabricationDate.Text;
                standar.FechaDeCaducidad = TimePicker_ExpirationDate.Text;
                standar.Cantidad = Convert.ToInt32(TxtBox_Quantity.Text);
                standar.Ubicacion = TxtBox_Ubication.Text;
                standar.Estatus = TxtBox_Estatus.Text;
                standar.Inventario = TxtBox_Inventory.Text;
                standar.NoLote = ComBox_Number_Lots.SelectedItem.ToString();

                C_AddEstandard controller = new C_AddEstandard();
                controller.add(standar);

                MessageBox.Show("El Estandar " + TxtBox_ESTE.Text + " Se agrego correctamente");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Llena todos los campos de estándar de forma correcta " + ex.Message);
            }

            if (Switch_Assignment.Checked && !TxtBox_ESTE.Text.Equals(""))
            {
                assignEstandardPermanently(TxtBox_ESTE.Text);
            }
            this.Close();
        }


        private void assignEstandardPermanently(string estEstandard)
        {
            Permanent_Assignment assignment = new Permanent_Assignment(estEstandard);
            assignment.Show();
            this.Close();
        }

    }
}
