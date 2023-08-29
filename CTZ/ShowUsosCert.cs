using CTZ.GetUsosCertDBTableAdapters;
using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class ShowUsosCert : MaterialForm
    {
        private int IDU, IDROL;
        private string CERT;

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void UpdateDGV()
        {
            //Recuperación de la información de la tabla detallecertificado
            GetCertUsosTableAdapter gcu = new GetCertUsosTableAdapter();
            BindingSource bs = new BindingSource();
            bs.DataSource = gcu.GetData(CERT);
            dataGridView1.DataSource = bs;
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
            if (e.RowIndex != -1 && IDROL == 5)
            {
                //abre form de Modificacion del uso del certificado siempre que el rol sea 5
                ModUsosCert muc = new ModUsosCert(IDU, IDROL, dataGridView1[0, e.RowIndex].Value.ToString());
                muc.ShowDialog(this);
                UpdateDGV();
            }
        }

        public ShowUsosCert(int idu, int idrol, string cert)
        {
            //Aqui se muestran los usos del certificado seleccionado
            InitializeComponent();
            IDU = idu;
            IDROL = idrol;
            CERT = cert;
            this.Text = "Usos de " + CERT;
            UpdateDGV();
        }
    }
}