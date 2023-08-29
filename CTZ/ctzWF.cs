using DataGridViewAutoFilter;
using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class ctzWF : Form
    {
        public ctzWF()
        {
            //Aqui se miestran todos los elementos almacenados en la tabla cartatrazabilidad
            InitializeComponent();
        }

        private void ctzWF_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSctz.GetCTZ' table. You can move, or remove it, as needed.
            try
            {
                this.getCTZTableAdapter.Fill(this.dSctz.GetCTZ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
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

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            { GetCTZ ctc = new GetCTZ(dataGridView1[3, e.RowIndex].Value.ToString()); }
        }
    }
}