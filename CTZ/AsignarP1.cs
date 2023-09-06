using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AsignarP1 : MaterialForm
    {
        private Functions ft = new Functions();
        private TestSpire.Functions ftt = new TestSpire.Functions();
        private int IDU, IDR;

        private void update()
        {
            /*Función para actualizar el datagridview del form principal*/
            var main = this.Owner as MenuPrincipal;
            if (main != null)
            {
                main.actualizar();
            }
        }

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            /*Despues de que se ha ligado la información al datagridview se recorre para poder colorear las celdas
             *
             */
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
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string val = dataGridView1[j, i].Value.ToString();
                    var cell = dataGridView1.Rows[i].Cells[j];
                    switch (val)
                    {
                        case "No Especificado":
                            cell.Style.BackColor = Color.FromArgb(105, 115, 133);
                            cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            break;

                        case "No Asignado":
                            cell.Style.BackColor = Color.FromArgb(105, 115, 133);
                            cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            break;

                        case "Disponible":
                            cell.Style.BackColor = Color.FromArgb(92, 255, 51);
                            cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            break;

                        case "No Disponible":
                            cell.Style.BackColor = Color.FromArgb(255, 181, 51);
                            cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            break;

                        case "SERVICIO":
                            cell.Style.BackColor = Color.FromArgb(255, 181, 51);
                            cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            break;

                        default:

                            if (val == "" || val.Length <= 0)
                            {
                                cell.Style.BackColor = Color.FromArgb(193, 196, 201);
                                cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            }
                            else if (ft.IsValid(val) && j == 8)
                            {
                                cell.Style.BackColor = Color.FromArgb(255, 181, 51);
                                cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            }
                            else if (ft.isDate(val) && (j == 9 || j == 10))
                            {
                                /*Se colorean de color rojo las celdas de fecha si la fecha de asignación es mayor a dos dias,
                                 * verde si es mayor a dos dias
                                 */
                                if (ft.ToDate(val).Subtract(DateTime.Now).TotalDays == 2)
                                {
                                    cell.Style.BackColor = Color.FromArgb(255, 255, 51);
                                    cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                                }
                                else if (ft.ToDate(val).Subtract(DateTime.Now).TotalDays < 2)
                                {
                                    cell.Style.BackColor = Color.FromArgb(255, 51, 51);
                                    cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                                }
                                else
                                {
                                    cell.Style.BackColor = Color.FromArgb(92, 255, 51);
                                    cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                                }
                            }

                            break;
                    }
                }
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

        private void AsignarP1_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'asignatedEQ2.AsignatedEQ' table. You can move, or remove it, as needed.
                this.asignatedEQTableAdapter.Fill(this.asignatedEQ2.AsignatedEQ);

                // TODO: This line of code loads data into the 'asignatedDataSet.AsignatedEQ' table. You can move, or remove it, as needed.
                //this.asignatedEQTableAdapter.Fill(this.asignatedDataSet.AsignatedEQ);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void asignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarP2 ap2 = new AsignarP2(IDU, IDR);
            ap2.ShowDialog();
            this.asignatedEQTableAdapter.Fill(this.asignatedEQ2.AsignatedEQ);
            update();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                Historial h = new Historial(dataGridView1[1, e.RowIndex].Value.ToString(), IDU, IDR);
                h.Show();
            }
        }

        private void desasignarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Desasignar ds = new Desasignar(IDU, IDR);
            ds.ShowDialog();
            this.asignatedEQTableAdapter.Fill(this.asignatedEQ2.AsignatedEQ);
            update();
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.SetREPORTE1("ResumenAsignacion");

            r.Show();
        }

        public AsignarP1(int idu, int idr)
        {
            InitializeComponent();
            ft.Material(this);
            IDU = idu;
            IDR = idr;
            DoubleBuffered(dataGridView1, true);
        }
    }
}