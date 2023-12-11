﻿using MaterialSkin.Controls;
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
    public partial class Estandards_Menu : MaterialForm
    {
        public Estandards_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Estandards_Click(object sender, EventArgs e)
        {
            Estandars_SubMenu menu = new Estandars_SubMenu();   
            menu.Show();
        }

        private void Btn_Assignment_Click(object sender, EventArgs e)
        {
            Assignments_Menu assignments = new Assignments_Menu();
            assignments.Show();
        }


    }
}