using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace CTZ
{
    public partial class GRL : MaterialForm
    {
        private Functions ft = new Functions();
        private int IDU, IDROL;

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        //datos provienen de stored procedure GetEquiposGrl
        public GRL(int idu, int idrol)
        {
            //Clase donde se muestran todos los equipos registrados independientemente de si tienen un certificado asignado o no

            IDU = idu;
            IDROL = idrol;
            InitializeComponent();

            ft.Material(this);
            DoubleBuffered(dataGridView1, true);
        }

        private void GRL_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'grl2.GetEquiposGrl' table. You can move, or remove it, as needed.

            try
            {
                // TODO: This line of code loads data into the 'getequiposgrl.GetEquiposGrl' table. You can move, or remove it, as needed.
                this.getEquiposGrlTableAdapter1.Fill(this.grl2.GetEquiposGrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        //quita todos los filtros del formulario y muestra los resultados anteriores
        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dataGridView1);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            //si existe algun filtro aparece la opcion para removerlo y ven todos los resultados 
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

            //Console.WriteLine("Cols: " + cols + " Rows: " + rows);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string value = dataGridView1[j, i].Value.ToString();
                    var cell = dataGridView1.Rows[i].Cells[j];
                    switch (j)
                    {
                        case 2: // El color varia acorde al Estatus/Disponibilidad
                            switch (value)
                            {
                                case "CALIBRADO":
                                    cell.Style.BackColor = Color.FromArgb(92, 255, 51);
                                    cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                                    break;

                                case "EN USO":
                                    cell.Style.BackColor = Color.FromArgb(255, 255, 51);
                                    cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                                    break;

                                case "CALIBRANDO":
                                    cell.Style.BackColor = Color.FromArgb(255, 181, 51);
                                    cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                                    break;

                                case "FUERA DE USO":
                                    cell.Style.BackColor = Color.FromArgb(255, 51, 51);
                                    cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                                    break;
                            }
                            break;

                        case 5:
                            if (value == "" || value.Length <= 0) //si esta vacio o sin valor 
                            {
                                cell.Style.BackColor = Color.FromArgb(0, 0, 0);
                            }
                            // Amarillo: faltan 30 dias
                            else if (ft.ToDate(value).Subtract(DateTime.Now).TotalDays == 30)
                            {
                                cell.Style.BackColor = Color.FromArgb(255, 255, 51);
                                cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            }
                            //Rojo: faltan menos de 30 dias
                            else if (ft.ToDate(value).Subtract(DateTime.Now).TotalDays < 30)
                            {
                                cell.Style.BackColor = Color.FromArgb(255, 51, 51);
                                cell.Style.ForeColor = Color.FromArgb(255, 255, 255);
                            }
                            //Verde mas de 30 dias
                            else
                            {
                                cell.Style.BackColor = Color.FromArgb(92, 255, 51);
                                cell.Style.ForeColor = Color.FromArgb(0, 0, 0);
                            }
                            break;
                    }
                }
            }
            dataGridView1.ReadOnly = true;
        }

        //Genera el listado de filtros para el Grid
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

        //El formulario tiene como folrmulario padre a FORM1, actualiza la informacion a visualizar inmediantamente al regresar a la ventana principal
        private void update()
        {
            //owner: pertenece al Form1
            var main = this.Owner as Form1;
            if (main != null)
            {
                main.actualizar();
            }
        }

        private void GRL_FormClosing(object sender, FormClosingEventArgs e)
        {
            //se realiza el proceso para actualizar el formulario principal al cerrar el secundario(this)
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
            //Abre reporteador con los datos del grid para impresion
            Reporte r = new Reporte();
            r.SetREPORTE1("Inventario");

            r.Show();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                switch (e.ColumnIndex)
                {
                    case 0://Modificación del equipo
                        modEQ meq = new modEQ(dataGridView1[0, e.RowIndex].Value.ToString(), dataGridView1[8, e.RowIndex].Value.ToString(), IDU, IDROL);
                        if (meq != null)
                        {
                            meq.ShowDialog(this);
                        }

                        break;

                    case 1:// Modifica el uso
                        if (IDROL == 5)
                        {
                            AddUso au = new AddUso("uso", dataGridView1[1, e.RowIndex].Value.ToString());
                            au.ShowDialog(this);
                        }
                        break;

                    case 2:

                        break;

                    case 3:// Modifica el certificado

                        if (IDROL == 5)
                        {
                            if (ft.IsValid(dataGridView1[3, e.RowIndex].Value.ToString()))
                            {
                                DialogResult dialogResult = MessageBox.Show("¿Quiere modificar este certificado?", "", MessageBoxButtons.YesNo);
                                if (dialogResult == DialogResult.Yes)
                                {
                                    AddUso au = new AddUso("certificado", dataGridView1[3, e.RowIndex].Value.ToString());
                                    au.ShowDialog(this);
                                }
                                //Al seleccionar NO, se abre el certificado, siempre que el sensor cuente con el link
                                else if (dialogResult == DialogResult.No)
                                {
                                    string sql = "select link from Certificado where certificado='" + dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() + "'";
                                    SqlDataReader read = ft.GetRead(sql);
                                    if (ft.IsValid(read.GetValue(0).ToString()))
                                    {
                                        ProcessStartInfo sInfo = new ProcessStartInfo(read.GetValue(0).ToString());
                                        Process.Start(sInfo);
                                    }
                                    else
                                    {
                                        MessageBox.Show("El Certificado no cuenta con un link");
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Este equipo no cuenta con un certificado asignado.");
                            }
                        }
                        else
                        {
                            //pbtiene el lick para abrir el explorador y ver el certificado
                            string sql = "select link from Certificado where certificado='" + dataGridView1[e.ColumnIndex, e.RowIndex].Value.ToString() + "'";
                            SqlDataReader read = ft.GetRead(sql);
                            if (read.Depth != 0 || read != null)
                            {
                                //genera el proceso para abir directamente en el explorador
                                ProcessStartInfo sInfo = new ProcessStartInfo(read.GetValue(0).ToString());
                                Process.Start(sInfo);
                            }
                            else
                            {
                                MessageBox.Show("El Certificado no cuenta con un link");
                            }
                        }
                        break;

                    case 6:// Modifica el modelo interno
                        if (IDROL == 5)
                        {
                            AddUso au = new AddUso("modeloi", dataGridView1[6, e.RowIndex].Value.ToString());
                            au.ShowDialog(this);
                        }
                        break;

                    case 7://modifica la marca interna
                        if (IDROL == 5)
                        {
                            AddUso au = new AddUso("marcai", dataGridView1[7, e.RowIndex].Value.ToString());
                            au.ShowDialog(this);
                        }
                        break;
                }
                this.getEquiposGrlTableAdapter1.Fill(this.grl2.GetEquiposGrl);
                //Llama la funcion del FORM1 para actualizar la vista en la tabla
                update();
            }
            catch (ObjectDisposedException ode)
            {
                string error = ode.ToString();
                if (!error.Contains("No se puede obtener acceso al objeto desechado"))
                {
                    MessageBox.Show(ode.Message);
                    MessageBox.Show(ode.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}