using AutoUpdaterDotNET;
using CTZ.Vista;
using CTZ.Vista.Responsabilitis;
using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Security.Policy;
using System.Windows.Forms;

namespace CTZ
{
    public partial class MenuPrincipal : MaterialForm
    {
        private Functions ft = new Functions();
        private int idUsuario, idRol, idArea;

        //Grid se mantiene sin parpadeos con esta funcion
        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        //carga los datos desde stored procedure GetEquipos
        public MenuPrincipal(int idUsuario, int idRol, int idArea)
        {
            //Form principal donde se muestran los ultimos certificados asignados a los equipos
            //en la tabla detalleequipo. Solo se muestran las tuplas de detalleequipo donde
            //la columna idcertificado es distinta de 0 o null
            this.idArea = idUsuario; 
            this.idArea = idArea; 
            this.idRol = idRol;

            ft.Material(this);
            InitializeComponent();
            //Función para que el datagridview se mantenga renderizado y no "parpadee" al recorrerlo
            DoubleBuffered(dgv, true);
            if (this.idRol == 5)
            {
                cartasTrazabilidadToolStripMenuItem.Enabled = true;
                cartaDeTrazabilidadToolStripMenuItem.Enabled = true;
            }
        }

        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        //abre formulario para agregar/cambiar nuevo uso de los sensores
        private void usoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("uso");
            au.ShowDialog(this);
        }

        //abre formulario para agregar/cambiar el estatus
        private void disponibilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Guarda un nuevo estatus
            AddUso au = new AddUso("disponibilidad");
            au.ShowDialog(this);
        }

        //abre formulario para agregar/cambiar la marca interna   marcaToolStripMenuItem_Click
        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("MarcaI");
            au.ShowDialog(this);
        }

        //abre formulario para agregar/cambia la magnitud
        private void magnitudToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("Magnitudes");
            au.ShowDialog(this);
        }

        private void laboratorioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //formulario para agregar nuevo laboratorio
            AddUso au = new AddUso("Laboratorio");
            au.ShowDialog(this);
        }

        private void procedimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("Procedimiento");
            au.ShowDialog(this);
        }

        private void marcaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Para insertar en la tabla MarcaE mrca externa
            AddUso au = new AddUso("MarcaE");
            au.ShowDialog(this);
        }

        private void modeloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           //***No realiza el proceso al estar desactivados los controles dentro de este form al seleccionarlos desde este menu***
            AddModelo am = new AddModelo("ModeloE");
            am.ShowDialog(this);
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddModelo am = new AddModelo("ModeloI");
            am.ShowDialog(this);
        }

        //abre form para crear nuevo equipo
        private void equipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipoP1 ae = new AddEquipoP1(idUsuario);
            ae.ShowDialog(this);
            this.getEquiposTableAdapter1.Fill(this.getequipos.GetEquipos);
        }

        private void incertidumbreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPuntos ap = new AddPuntos();
            ap.ShowDialog(this);
        }

        private void certificadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCert ac = new AddCert(idUsuario);
            ac.ShowDialog(this);
        }

        private void instrumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Agrega los instrumentos, la ejecucion del query esta desactivada
            AddInstrumento ai = new AddInstrumento();
            ai.ShowDialog(this);
        }

        private void cartaDeTrazabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCarta ac = new AddCarta();
            ac.ShowDialog(this);
        }

        private void cartasTrazabilidadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ctzWF fm2 = new ctzWF();
            fm2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'getequipos.GetEquipos' table. You can move, or remove it, as needed.
            this.getEquiposTableAdapter1.Fill(this.getequipos.GetEquipos);
        }

        private void ShowAllLabel_Click(object sender, EventArgs e)
        {
            DataGridViewAutoFilterTextBoxColumn.RemoveFilter(dgv);
        }

        private void dgv_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            string filterStatus = DataGridViewAutoFilterColumnHeaderCell.GetFilterStatus(dgv);
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
            int rows = dgv.Rows.Count;
            int cols = dgv.Columns.Count;

            Console.WriteLine("Cols: " + cols + " Rows: " + rows);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    string value = dgv[j, i].Value.ToString();
                    var cell = dgv.Rows[i].Cells[j];
                    switch (j)
                    {
                        case 3:
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

                        case 6:
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

        private void dgv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt
            && (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
            && dgv.CurrentCell != null
            && dgv.CurrentCell.OwningColumn.HeaderCell is DataGridViewAutoFilterColumnHeaderCell filterCell)
            {
                filterCell.ShowDropDownList();
                e.Handled = true;
            }
        }

        private void dgv_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Dependiendo de la columna donde se de dobleclick se abrirá un nuevo form
            switch (e.ColumnIndex)
            {
                case 0://Modificación del equipo
                    modEQ meq = new modEQ(dgv[0, e.RowIndex].Value.ToString(), dgv[dgv.ColumnCount - 1, e.RowIndex].Value.ToString(), idUsuario, idRol);
                    meq.ShowDialog(this);

                    break;

                case 2://Modificación del uso, solo si el usuario es administrador
                    if (idRol == 5)
                    {
                        AddUso au = new AddUso("uso", dgv[2, e.RowIndex].Value.ToString());
                        au.ShowDialog(this);
                    }
                    break;

                case 3:

                    break;

                case 4:

                    if (idRol == 5)
                    {
                        if (ft.IsValid(dgv[4, e.RowIndex].Value.ToString()))//Modificación del Certificado, solo si el usuario es administrador
                        {
                            DialogResult dialogResult = MessageBox.Show("¿Quiere modificar este certificado?", "", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                AddUso au = new AddUso("certificado", dgv[4, e.RowIndex].Value.ToString());
                                au.ShowDialog(this);
                            }
                            else if (dialogResult == DialogResult.No)//Visualización del certificado en box(se necesita una cuenta de box con los permisos necesarios)
                            {
                                string sql = "select link from Certificado where certificado='" + dgv[e.ColumnIndex, e.RowIndex].Value.ToString() + "'";
                                SqlDataReader read = ft.GetRead(sql);
                                if (ft.IsValid(read.GetValue(0).ToString()))
                                {
                                    Preview pv = new Preview();
                                    pv.SetUrl(read.GetValue(0).ToString());
                                    pv.Show();
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
                        //Visualización del certificado en box(se necesita una cuenta de box con los permisos necesarios)
                        string sql = "select link from Certificado where certificado='" + dgv[e.ColumnIndex, e.RowIndex].Value.ToString() + "'";
                        SqlDataReader read = ft.GetRead(sql);
                        if (read.Depth != 0)
                        {
                            Preview pv = new Preview();
                            pv.SetUrl(read.GetValue(0).ToString());
                            pv.Show();
                        }
                        else
                        {
                            MessageBox.Show("El Certificado no cuenta con un link");
                        }
                    }
                    break;

                case 1:
                    if (idRol == 5)//Modificación del uso mostrado, solo para los usuarios administradores
                    {
                        AddUso au = new AddUso("modeloi", dgv[6, e.RowIndex].Value.ToString());
                        au.ShowDialog(this);
                    }
                    break;

                case 8:
                    if (idRol == 5)//Modificación de la marca(interna) mostrada, solo para los usuarios administradores
                    {
                        AddUso au = new AddUso("marcai", dgv[7, e.RowIndex].Value.ToString());
                        au.ShowDialog(this);
                    }
                    break;
            }
            this.getEquiposTableAdapter1.Fill(this.getequipos.GetEquipos);
        }

        private void detalleEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEquipo ae = new AddEquipo(idUsuario);
            ae.ShowDialog(this);
            this.getEquiposTableAdapter1.Fill(this.getequipos.GetEquipos);
        }

        private void equipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void detalleEquipoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void getCTZBindingSource_CurrentChanged(object sender, EventArgs e)
        {
        }

        //Actualiza y carga los datos para el formulario GRL 
        public void actualizar()
        {
            this.getEquiposTableAdapter1.Fill(this.getequipos.GetEquipos);
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GRL grl = new GRL(idUsuario, idRol);
            grl.Owner = this;
            grl.Show(this);
        }

        private void asignadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void dgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgv.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void certificadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleCert dc = new DetalleCert(idUsuario, idRol);
            dc.Show();
        }

        private void calibraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra el calendario de uso y fecha de venimiento de los instrumentos
            Reporte rp = new Reporte();
            rp.SetREPORTE1("CalendarioCalibracion");
            rp.Show();
        }

        private void porFolioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialFSR hf = new HistorialFSR(idUsuario, idRol);
            hf.Show();
        }

        private void porClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HistorialCliente hc = new HistorialCliente(idUsuario, idRol);
            hc.Show();
        }

        private void asignaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AsignarP1 ap1 = new AsignarP1(idUsuario, idRol);
            ap1.Owner = this;
            ap1.Show(this);
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.SetREPORTE1("UltimosCertificados");

            r.Show();
        }

        private void calibraciónGeneralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.SetREPORTE1("CalendarioCalibracionGeneral");

            r.Show();
        }

        private void porEstatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //muestra los instrumntos por fechas de uso, realiza filtrado por tipo de marca y estatus
            Reporte r = new Reporte();
            r.SetREPORTE1("CalendarioEstatus");
            r.Show();
        }

        private void laboratoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetalleLabs dl = new DetalleLabs(idUsuario, idRol, idArea);
            dl.Show();
        }

        private void acuseDeCalibraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte r = new Reporte();
            r.SetREPORTE1("AcuseCalibracion");
            r.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Pestaña_Accesorios_Click(object sender, EventArgs e)
        {
            Accesorios accesorios= new Accesorios();
            accesorios.Owner = this;
            accesorios.Show(this);
        }

        private void PestañaDataLogger_Click(object sender, EventArgs e)
        {
            DataLogger dataLogger = new DataLogger();   
            dataLogger.Owner= this;
            dataLogger.Show(this);
        }

        private void Pestaña_Herramientas_Click(object sender, EventArgs e)
        {
            Herramientas herramientas = new Herramientas();
            herramientas.Owner = this;
            herramientas.Show(this);
        }

        private void Pestaña_Instrumentos_Click(object sender, EventArgs e)
        {
            Instrumentos instrumento = new Instrumentos();
            instrumento.Owner = this;
            instrumento.Show(this);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void usoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
        }

        private void estatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}