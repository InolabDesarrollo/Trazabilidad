using CTZ.Controler.Estandard;
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
    public partial class Add_Delivery_Estandard : MaterialForm
    {
        C_Estandard controler;
        public Add_Delivery_Estandard()
        {
            InitializeComponent();
        }

        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            controler = new C_Estandard();
            if (controler.check(TxtBox_Estandards.Text))
            {
                addEstandard();
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandard()
        {
            ComboBox_Estandards.Text = TxtBox_Estandards.Text;
            TxtBox_Estandards.Clear();
        }
    }
}
