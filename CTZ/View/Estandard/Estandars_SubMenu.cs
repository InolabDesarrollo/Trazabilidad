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
    public partial class Estandars_SubMenu : MaterialForm
    {
        public Estandars_SubMenu()
        {
            InitializeComponent();
        }

        private void Estandars_SubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Estandares' Puede moverla o quitarla según sea necesario.
            this.estandaresTableAdapter.Fill(this.trazabilidadTestDataSet4.Estandares);

        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_Estandards_FilterStringChanged(object sender, EventArgs e)
        {
            this.estandaresBindingSource.Filter = this.Dgv_Estandards.FilterString;

        }
    }
}
