using CTZ.DatasetHistoryTableAdapters;
using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class HistorialCliente : MaterialForm
    {
        private int IDU, IDR;

        public int IDU1 { get => IDU; set => IDU = value; }
        public int IDR1 { get => IDR; set => IDR = value; }

        public HistorialCliente(int idu, int idr)
        {
            //Aqui se muestran los instrumentos asignados a alguna locacion(cliente)
            InitializeComponent();
        }

        private void HistorialCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'clientesDataSet.Clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.clientesDataSet.Clientes);
        }

        public void refresh(int id)
        {
            //Recuperación de tuplas de la Tabla detalleasignacion
            gethistorybyclientTableAdapter getassigned = new gethistorybyclientTableAdapter();
            BindingSource bs = new BindingSource();
            bs.DataSource = getassigned.GetData(id);
            dataGridView1.DataSource = bs;
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientes.SelectedIndex != -1)
            {
                refresh((int)clientes.SelectedValue);
            }
        }

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dataGridView1);
            if (string.IsNullOrEmpty(filterStatus))
            {
                ShowAllLabel.Visible = false;
                FilterStatusLabel.Visible = false;
            }
            else
            {
                ShowAllLabel.Visible = true;
                FilterStatusLabel.Visible = true;
                FilterStatusLabel.Text = filterStatus;
            }
        }

        private void print_Click(object sender, EventArgs e)
        {
            if (clientes.SelectedIndex != -1 || clientes.SelectedIndex != 0)
            {
                Reporte r = new Reporte();
                r.SetREPORTE1("HistoryCient");
                r.SetIdent(clientes.SelectedValue.ToString());
                r.Show();
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
            && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            && dataGridView1.CurrentCell != null
            && dataGridView1.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }
    }
}