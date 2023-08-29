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

namespace CTZ
{
    public partial class DetalleLabs : MaterialForm
    {
        private int IDA, IDR, IDU;

        public DetalleLabs(int idu, int idr, int ida)
        {
            //En esta clase se visualizan todos los laboratorios
            InitializeComponent();
            IDU = idu;
            IDR = idr;
            IDA = ida;
        }

        private void DetalleLabs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSctz.Laboratorio1' table. You can move, or remove it, as needed.
            this.laboratorio1TableAdapter.Fill(this.dSctz.Laboratorio1);
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //abre form para editar nombre y direccion del laboratorio
                AddUso au = new AddUso("Laboratorio", dataGridView1[1, e.RowIndex].Value.ToString(), dataGridView1[2, e.RowIndex].Value.ToString());//Función para modificar el laboratorio
                au.ShowDialog(this);
                this.laboratorio1TableAdapter.Fill(this.dSctz.Laboratorio1);
            }
        }
    }
}