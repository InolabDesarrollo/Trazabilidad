using CTZ.DatasetHistoryTableAdapters;
using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Reflection;
using System.Windows.Forms;

namespace CTZ
{
    public partial class Historial : MaterialForm
    {
        private int IDU, IDR;
        private string IDENT;
        private Functions ft = new Functions();

        public void refresh(string id, DateTime f1, DateTime f2)
        {
            getHistoryTableAdapter getassigned = new getHistoryTableAdapter();
            BindingSource bs = new BindingSource();
            bs.DataSource = getassigned.GetData(id, f1, f2);
            dataGridView1.DataSource = bs;
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

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        private void f2_ValueChanged(object sender, EventArgs e)
        {
            refresh(IDENT, f1.Value, f2.Value);
        }

        private void f1_ValueChanged(object sender, EventArgs e)
        {
            refresh(IDENT, f1.Value, f2.Value);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.SetREPORTE1("HistoryEQ");
            r.SetIdent(IDENT);
            r.SetF1(f1.Value);
            r.SetF2(f2.Value);
            r.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                //Modificacion del Folio de servicio de la tupla en la tabla detalleasignacion
                AddUso au = new AddUso("FSR", dataGridView1[0, e.RowIndex].Value.ToString(), "");
                au.ShowDialog();
                refresh(IDENT, f1.Value, f2.Value);
            }
        }

        public Historial(string ident, int idu, int idr)
        {
            //Aqui se muestran todas las tuplas de la tabla detalleasignación de un equipo
            InitializeComponent();
            IDENT = ident;
            IDU = idu;
            IDR = idr;
            this.Text = "Historial del instrumento: " + IDENT;
            refresh(IDENT, DateTime.Now.AddYears(-1), DateTime.Now);
            DoubleBuffered(dataGridView1, true);
        }
    }
}