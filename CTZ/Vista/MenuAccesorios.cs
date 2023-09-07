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
    public partial class MenuAccesorios : Form
    {
        public MenuAccesorios()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Ver_Click(object sender, EventArgs e)
        {
            if (!Pnl_See.Visible)
            {
                Pnl_See.Visible = true;
            }
            else
            {
                Pnl_See.Visible=false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
