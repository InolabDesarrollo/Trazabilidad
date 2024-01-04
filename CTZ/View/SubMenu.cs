using CTZ.View.Estandard;
using CTZ.View.Instruments;
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
using System.Windows.Forms;

namespace CTZ.Vista
{
    public partial class SubMenu : MaterialForm
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        private void Btn_Estandares_Click(object sender, EventArgs e)
        {
            Estandards_Menu menu = new Estandards_Menu();
            menu.Show();    
        }

        private void Btn_Instrumentos_Click(object sender, EventArgs e)
        {
            Instruments_Menu menu = new Instruments_Menu();
            menu.Show();
        }
    }
}
