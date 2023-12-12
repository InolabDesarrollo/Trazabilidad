using CTZ.Controler.Estandard;
using CTZ.Vista;
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
    public partial class SerchEstandard : MaterialForm
    {
        public SerchEstandard()
        {
            InitializeComponent();
        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {
            C_Estandard  controler = new C_Estandard();
            if(controler.check(TxtBox_EstEstandard.Text))
            {
                UpdateEstandard update = new UpdateEstandard(TxtBox_EstEstandard.Text);
                update.Show();  
            }
            else
            {
                MessageBox.Show("El estandard No Existe");
            }
            
        }
    }
}
