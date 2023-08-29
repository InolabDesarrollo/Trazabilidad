using CTZ.DatasetHistoryTableAdapters;
using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class HistorialFSR : MaterialForm
    {
        private Functions ft = new Functions();
        private int IDU, IDR;

        public HistorialFSR(int idu, int idr)
        {
            //Aqui se muestran las tuplas por Folio de servicio
            InitializeComponent();
            IDU = idu;
            IDR = idr;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        }

        public void refresh(int id)
        {
            //Recuperación de información de la tabla detalleasignacion
            gethistorybyfsrTableAdapter getassigned = new gethistorybyfsrTableAdapter();
            BindingSource bs = new BindingSource();
            bs.DataSource = getassigned.GetData(28438);
            dataGridView1.DataSource = bs;
        }

        private void materialComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (materialComboBox1.SelectedIndex != -1)
            {
                try
                {
                    string val = materialComboBox1.SelectedValue.ToString();
                    if (!val.Contains("System.Data.DataRowView"))//no es igual al contenido de la variable(Folio)
                    {
                        refresh(Convert.ToInt32(val));
                    }
                    //refresh(Convert.ToInt32(val));
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message + " - " + ex.ToString());
                }                
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

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (materialComboBox1.SelectedIndex != -1)
            {
                Reporte r = new Reporte();
                r.SetREPORTE1("HistoryFSR");
                r.SetIdent(materialComboBox1.SelectedValue.ToString());
                r.Show();
            }
        }

        private void HistorialFSR_Load(object sender, EventArgs e)
        {
            string sql = "select distinct(fsr) as IdF,FSR as val from detalleasignacion where fsr is not null";
            ft.populateFromSqlStringDS(materialComboBox1, sql, "val", "IdF", "detalleasignacion");
        }
    }
}