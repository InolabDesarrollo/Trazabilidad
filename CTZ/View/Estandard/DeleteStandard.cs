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

namespace CTZ.View.Estandard
{
    public partial class DeleteStandard : MaterialForm
    {
        public DeleteStandard()
        {
            InitializeComponent();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            C_Estandard controlEstandard = new C_Estandard();
            if (controlEstandard.checkIfEstandarExist(TxtBox_EST.Text))
            {
                C_DeleteEstandard controler = new C_DeleteEstandard(TxtBox_EST.Text);
                controler.Delete();
                TxtBox_EST.Clear();
                MessageBox.Show("Se elimino el Estandard " + TxtBox_EST.Text);
            }
            else
            {
                MessageBox.Show("El Estandar No existe");
            }
            
        }
    }
}
