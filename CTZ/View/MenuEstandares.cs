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
    public partial class MenuEstandares : Form
    {
        public MenuEstandares()
        {
            InitializeComponent();
        }

        private void Btn_File_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_File);
        }

        private void Btn_Schedule_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Schedule);
        }

        private void Btn_History_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_History);
        }

        private void Btn_Asign_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Asign);
        }

        private void showMenu(Panel panel)
        {
            if (!panel.Visible)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void Btn_See_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_See);
        }


    }
}
