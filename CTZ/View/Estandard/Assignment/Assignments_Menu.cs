using CTZ.View.Estandard.Assignment;
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
    public partial class Assignments_Menu : MaterialForm
    {
        public Assignments_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Assignment_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Serch_Assignments_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Add_Assignments_Click(object sender, EventArgs e)
        {
            Add_Delivery_Estandard add_Delivery_Estandard= new Add_Delivery_Estandard();
            add_Delivery_Estandard.Show();
        }

        private void Btn_Regist_Return_Instrument_Click(object sender, EventArgs e)
        {
            Regist_Return_Estandard regist_Return_Estandard = new Regist_Return_Estandard();
            regist_Return_Estandard.Show();
        }
    }
}
