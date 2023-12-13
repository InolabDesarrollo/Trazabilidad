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
        private readonly string kindOfSerch;

        public SerchEstandard(string kindOfSerch)
        {
            InitializeComponent();
            this.kindOfSerch = kindOfSerch;
        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {
            C_Estandard  controler = new C_Estandard();
            if(controler.check(TxtBox_EstEstandard.Text) && kindOfSerch.Equals("UpdateEstandard"))
            {
                UpdateEstandard update = new UpdateEstandard(TxtBox_EstEstandard.Text);
                update.Show();  
            }else if (controler.check(TxtBox_EstEstandard.Text) && kindOfSerch.Equals("AddCertificate"))
            {
                AddCertificate addCertificate = new AddCertificate(TxtBox_EstEstandard.Text);
                addCertificate.Show();
            }
            else
            {
                MessageBox.Show("El estandard No Existe");
            }
            
        }
    }
}
