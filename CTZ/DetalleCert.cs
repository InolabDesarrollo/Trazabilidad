using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CTZ
{
    public partial class DetalleCert : MaterialForm
    {
        private int IDU, IDROL;
        private Functions ft = new Functions();

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public DetalleCert(int idu, int idrol)
        {
            //En esta clase se visualizan todos los certificados
            InitializeComponent();
            IDU = idu;
            IDROL = idrol;
            DoubleBuffered(dataGridView1, true);
        }

        private void DetalleCert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getCertGRL.GetCert' table. You can move, or remove it, as needed.
            this.getCertTableAdapter.Fill(this.getCertGRL.GetCert);
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

            int rows = dataGridView1.Rows.Count;
            int cols = dataGridView1.Columns.Count;

            //Loop para colorear la fecha de proxima calibración
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string value = dataGridView1[j, i].Value.ToString();
                    var cell = dataGridView1.Rows[i].Cells[j];
                    switch (j)
                    {
                        case 3:
                            if (value == "" || value.Length <= 0)
                            {
                                cell.Style.BackColor = Color.FromArgb(0, 0, 0);
                            }
                            else if (ft.ToDate(value).Subtract(DateTime.Now).TotalDays == 30)
                            {
                                cell.Style.BackColor = Color.FromArgb(255, 255, 51);
                                cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            }
                            else if (ft.ToDate(value).Subtract(DateTime.Now).TotalDays < 30)
                            {
                                cell.Style.BackColor = Color.FromArgb(255, 51, 51);
                                cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            }
                            else
                            {
                                cell.Style.BackColor = Color.FromArgb(92, 255, 51);
                                cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            }
                            break;
                    }
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Acciones a realizar
            if (e.RowIndex != -1)
            {
                //abre el form para editar, agregar o modificar los datos del certificado
                DialogResult dr = MessageBox.Show("¿Modificar certificado " + dataGridView1[0, e.RowIndex].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    AddCert ac = new AddCert();
                    ac.SetUs("Actualizar Certificado");
                    ac.SetIDU1(IDU);
                    ac.SetNoCert1(dataGridView1[0, e.RowIndex].Value.ToString());
                    ac.ShowDialog(this);
                }
                else
                {
                    //abre form para cambiar el uso del certificado
                    dr = MessageBox.Show("¿Agregar Nuevo Uso al certificado " + dataGridView1[0, e.RowIndex].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.Yes)
                    {
                        AddDetalleCert adc = new AddDetalleCert(IDU, IDROL, dataGridView1[0, e.RowIndex].Value.ToString());
                        adc.ShowDialog(this);
                    }
                    else
                    {
                        //muestra los usos de los certificados en un listado
                        dr = MessageBox.Show("¿Ver usos del certificado  " + dataGridView1[0, e.RowIndex].Value.ToString() + "?", "", MessageBoxButtons.YesNo);
                        if (dr == DialogResult.Yes)
                        {
                            ShowUsosCert suc = new ShowUsosCert(IDU, IDROL, dataGridView1[0, e.RowIndex].Value.ToString());
                            suc.ShowDialog(this);
                        }
                    }
                }
            }
            this.getCertTableAdapter.Fill(this.getCertGRL.GetCert);
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