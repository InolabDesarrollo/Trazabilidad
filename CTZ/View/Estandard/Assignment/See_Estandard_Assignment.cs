using CTZ.Controler.Estandard.Assignment;
using CTZ.Vista.Instruments;
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
    public partial class See_Estandard_Assignment : MaterialForm
    {
        private C_Query_Estandard_Assignment controller;
        public See_Estandard_Assignment()
        {
            InitializeComponent();
            controller = new C_Query_Estandard_Assignment();
        }

        private void See_Estandard_Assignment_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.AsignacionEstandares' Puede moverla o quitarla según sea necesario.
            this.asignacionEstandaresTableAdapter.Fill(this.trazabilidadTestDataSet4.AsignacionEstandares);

        }

        private void Dgv_Assignment_FilterStringChanged(object sender, EventArgs e)
        {
            this.asignacionEstandaresBindingSource.Filter = this.Dgv_Assignment.FilterString;
        }

        private void Btn_Clean_Click(object sender, EventArgs e)
        {
            this.Dgv_Assignment.DataSource = asignacionEstandaresBindingSource;
        }

        private void Btn_Serch_Enginner_Click(object sender, EventArgs e)
        {
            Dgv_Assignment.DataSource = controller.selectAllByEnginner(TxtBox_Enginner.Text);
        }

        private void Btn_Serch_Estandard_Click(object sender, EventArgs e)
        {
            Dgv_Assignment.DataSource = controller.selectAllByEstandard(TxtBox_Estandard.Text);
        }

        private void Btn_Serch_Brand_Click(object sender, EventArgs e)
        {
            Dgv_Assignment.DataSource = controller.selectAllByBrand(TxtBox_Brand.Text);
        }

        private void Dgv_Assignment_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 || e.ColumnIndex == 10 || e.ColumnIndex == 13)
            {
                showSignature(e);
            }
        }

        private void showSignature(DataGridViewCellEventArgs e)
        {
            string signature  = Dgv_Assignment[e.ColumnIndex, e.RowIndex].Value.ToString();
            Show_Signature showSignature = new Show_Signature(signature);
            showSignature.Show();
        }
    }
}
