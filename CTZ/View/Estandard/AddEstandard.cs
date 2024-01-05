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
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (TxtBox_ESTE.Text.Equals(""))
            {
                MessageBox.Show("Se tiene que agregar el EST");
            }
            else
            {
                C_Estandard controler = new C_Estandard();
                if (!controler.check(TxtBox_ESTE.Text))
                {
                    addEstandart();
                }
                else
                {
                    MessageBox.Show("Este Estandard ya existe");
                }
            }            
        }

        private void addEstandart()
        {
            CTZ.View.Responsabilitis.Estandard estandard = new Responsabilitis.Estandard();
            estandard.EstatusAssignments = "Sin Asignar";
            estandard.EstEstandard = TxtBox_ESTE.Text;
            estandard.EstandardDescription = TxtBox_Estandard.Text;
            estandard.Use = TxtBox_Use.Text;
            estandard.Brand = TxtBox_Brand.Text;
            estandard.Presentation = TxtBox_Presentation.Text;
            estandard.Number = TxtBox_Number.Text;
            estandard.FabricationDate = TimePicker_FabricationDate.Text;
            estandard.ExpirationDate = TimePicker_ExpirationDate.Text;
            estandard.Quantity = TxtBox_Quantity.Text;
            estandard.Ubication = TxtBox_Ubication.Text;
            estandard.Estatus = TxtBox_Estatus.Text;
            estandard.Inventory = TxtBox_Inventory.Text;

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
            cleanButtons();
        }

        private void cleanButtons()
        {
            TxtBox_ESTE.Clear();
            TxtBox_Estandard.Clear();
            TxtBox_Use.Clear();
            TxtBox_Brand.Clear();
            TxtBox_Presentation.Clear();
            TxtBox_Number.Clear();
            TxtBox_Presentation.Clear();
            TxtBox_Number.Clear();
            TxtBox_Quantity.Clear();
            TxtBox_Ubication.Clear();
            TxtBox_Estatus.Clear(); 
            TxtBox_Inventory.Clear();
        }

        private void assignEstandardPermanently(string estEstandard)
        {
            Permanent_Assignment assignment = new Permanent_Assignment(estEstandard);
            assignment.Show();
        }

    }
}
