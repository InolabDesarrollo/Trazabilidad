using DataGridViewAutoFilter;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AsignarP2 : MaterialForm
    {
        private int IDU, IDR;
        private Functions ft = new Functions();
        private string body;
        private string email;

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        private void AsignarP2_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'asignacionDataSet.Asignacion' table. You can move, or remove it, as needed.
                this.asignacionTableAdapter.Fill(this.asignacionDataSet.Asignacion);
                // TODO: This line of code loads data into the 'getAvailableDataSet.GetAvailable' table. You can move, or remove it, as needed.
                this.getAvailableTableAdapter.Fill(this.getAvailableDataSet.GetAvailable);
                // TODO: This line of code loads data into the 'getClienteDataSet.GetCliente' table. You can move, or remove it, as needed.
                this.getClienteTableAdapter.Fill(this.getClienteDataSet.GetCliente);
                // TODO: This line of code loads data into the 'ingesDataSet.GetInges' table. You can move, or remove it, as needed.
                this.getIngesTableAdapter.Fill(this.ingesDataSet.GetInges);
                // TODO: This line of code loads data into the 'clientesDataSet.Clientes' table. You can move, or remove it, as needed.
                this.clientesTableAdapter.Fill(this.clientesDataSet.Clientes);
                int ind = perm.SelectedIndex;
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                MessageBox.Show(EX.ToString());
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

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    /*Para poder agregar equipos al otro datagrid es necesario seleccionar toda la fila
                     */
                    var cell = dataGridView1[0, e.RowIndex];
                    var cell1 = dataGridView1[1, e.RowIndex];

                    string send = cell.Value.ToString() + "*" + cell1.Value.ToString();
                    dataGridView1.DoDragDrop(send, DragDropEffects.Copy | DragDropEffects.Move);//Envío de datos DragAndDrop
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView2_DragEnter(object sender, DragEventArgs e)
        {
            //Recolecciónde informacion de Drag and Drop
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private List<string[]> EQ = new List<string[]>();

        public string Body { get => body; set => body = value; }
        public string Email { get => email; set => email = value; }

        private void DisplayStringListInDataGrid(List<string[]> passedList, DataGridView gridToUpdate, string newColumnHeader)
        {
            //Mostrar la información de la lista EQ el datagrid
            DataTable gridData = new DataTable();
            gridData.Columns.Add(newColumnHeader);

            foreach (string[] listItem in passedList)
            {
                gridData.Rows.Add(listItem[1]);
            }

            BindingSource gridDataBinder = new BindingSource();
            gridDataBinder.DataSource = gridData;
            dataGridView2.DataSource = gridDataBinder;
        }

        public bool IsinList(string val, List<string[]> values)
        {
            //Verificación de no duplicidad de información
            foreach (string[] id in values)
            {
                if (val == id[0])
                {
                    return true;
                }
            }
            return false;
        }

        private void dataGridView2_DragDrop(object sender, DragEventArgs e)
        {
            /*Manejo de informacion
             * Se reciben las filas seleccionadas y se agregan a la lista EQ si no existen en la Lista
             */
            DataGridViewSelectedRowCollection rows = dataGridView1.SelectedRows;
            foreach (DataGridViewRow row in rows)
            {
                string[] done1 = new string[] { row.Cells[0].Value.ToString(), row.Cells[1].Value.ToString() };
                if (!IsinList(done1[0], EQ))
                {
                    EQ.Add(done1);
                }
                else
                {
                    MessageBox.Show(done1[1] + " ya se encuentra en la seleccion");
                }
            }

            DisplayStringListInDataGrid(EQ, dataGridView2, "EQ's");//Se actualioza la vista de la Lista Eq en el datagridview2
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            try
            {
                //Se limpia la vista y la lista de Eq's seleccionados
                EQ.Clear();
                DisplayStringListInDataGrid(EQ, dataGridView2, " ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private bool save()
        { //Funcion para asentar los cambios en la tabla detalleasignacion
            string IdInge = Ings.SelectedValue.ToString();
            string IdLoc = Location.SelectedValue.ToString();
            string disp = "2";
            string perma = perm.Text; //permanencia
            string isper = "NULL";
            string Fsr = fsr.Text;
            string idlab = "null";
            if (perma != "SERVICIO")
            {
                IdInge = "null";
                Fsr = "null";
                IdLoc = "null";
            }
            if (perma == "CALIBRACIÓN")
            {
                disp = "3";
                Fsr = "null";
                idlab = Location.SelectedValue.ToString();
            }
            if (perma == "PERMANENTE")
            {
                isper = "1";
                Fsr = "null";
                IdInge = Ings.SelectedValue.ToString();
            }
            else
            {
                Fsr = "'" + Fsr + "'";
            }
            //Loop por cada uno de los elementos en la Lista EQ
            foreach (string[] eq in EQ)
            {
                //Para asegurar su correcta ejecucion el query se define como una transación por cada elemento
                string sql = "begin TRAN    Update detalleasignacion set actual=0 where idEQ=" + eq[0] + ";";
                string sql1 = "Update detalleequipo set iddisp=" + disp + " where idequipo=" + eq[0] + "; commit TRAN";

                string qq = "insert into detalleasignacion(idusr,iding,idcliente,ideq,fechainicio," +
                    "fechafin,fecharegistro,permanente,actual,Ida,fsr,IdLab)" +
                       "values(" + IDU + "," + IdInge + "," + IdLoc + "," + eq[0] + ",'" +
                       ft.DateToString(date1.Value) + "','" + ft.DateToString(date2.Value) +
                       "',SYSDATETIME()," + isper + ",1," + perm.SelectedValue + "," + Fsr + "," + idlab + ");";
                sql += qq;
                sql += sql1;
                if (IDU == 27)
                {
                }
                else
                {
                    if (!ft.SetSql(sql, false))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private bool mail()
        {
            //Funcion que escribe un html que será enviado a quien asigna los instrumentos y al ingeniero a quien se le han asignado
            string query1 = "Select * from usuarios where IdUsuario= " + Ings.SelectedValue + ";";
            SqlDataReader sdr1 = ft.GetRead(query1, ft.connectionStringBrowser);
            Email = (string)sdr1.GetValue(sdr1.GetOrdinal("Mail"));
            string ccEmail = User.Mail;
            if (Email != null)
            {
                Body = "<html>\n" +
        "<head>\n" +
            "<style>\n" +
                "header{\n" +
                "   top: 0%;\n" +
                "   border: cadetblue solid 1px;\n" +

                "}\n" +
                ".Head{\n" +
                "   text-align: center;\n" +

                "}\n" +
                ".content{\n" +
                "   padding: 2rem;\n" +
               "     border: cadetblue solid 1px;\n" +

               " }\n" +
               ".ContentHead{\n" +
               "   text-align: center;\n " +
               "}\n" +
               " h1{\n" +
                "   color: cadetblue;\n" +
                "}\n" +
               " h3{\n" +
               "    margin-left: auto;\n" +
                "   margin-right: auto;\n" +
                "   margin-top: .25rem;\n" +
                "}\n" +
               " h5{\n" +
               "     margin-left: 1.7rem;\n" +
               " }\n" +
               " footer{\n" +
               "    bottom: 0%;\n" +
               "    border: cadetblue solid 1px;\n" +
                "   background-image: url('./ BG1.png');\n" +

               " }\n" +
               " body{\n" +
                "    background-color: #f1f1f1;\n" +
               " }\n" +
           " </style>\n" +
        "</head>\n" +
        "<body>\n" +
            "<header>\n" +
               " <div class='Head'>\n" +
                   " <h1>Instrumentos Asignados</h1>\n" +
               " </div>\n" +

            "</header>\n" +

            "<div class='content'>\n" +
            "<div class='ContentHead'>\n" +
             "  <h3>Folio: " + fsr.Text + "</h3>\n" +
             "  <h3>Cliente: " + Location.Text + "</h3>" +
            "</div>\n"
             ;

                string bodyFinal = "</div>\n" +
                        "<footer>\n" +
                        //"   <h1> FooterData </h1>\n" +
                        "</footer>\n" +
                    "</body>\n" +
                "</html>";
                foreach (string[] eq in EQ)
                {
                    Body = Body + "<h5>" + eq[1] + "<h5>\n";
                }
                Body = Body + bodyFinal;
                var smtpClient = new SmtpClient(User.host)
                {
                    Port = User.port,
                    Credentials = new NetworkCredential(User.name, User.pass),
                    EnableSsl = false,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(User.name),
                    Subject = "Instrumentos Asignados",
                    Body = Body,
                    IsBodyHtml = true,
                };
                //CambiarCorreoDeQuienRecibe
                if (IDU == 27) //IDU == 27
                {
                    mailMessage.To.Add("sandraovando@inolab.com");//"ivannarruel@inolab.com"
                }
                else
                {
                    mailMessage.To.Add(Email);
                    if (ft.IsValid(ccEmail))
                    {
                        mailMessage.CC.Add(ccEmail);
                    }
                }

                //;

                smtpClient.Send(mailMessage);
                //Test de html que se envia
                //File.WriteAllText("./LastSent.html", Body + "<!--" + Email + "-->");
            }

            return false;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ings.SelectedIndex != -1 && Location.SelectedIndex != -1 && EQ.Count != 0)//EQ LISTA DE EQUIPOS
                {
                    if (save())
                    {
                        if (perm.Text == "SERVICIO")
                        {
                            mail();
                        }
                        else if (perm.Text == "CALIBRACIÓN")
                        {
                            //Acuse
                            Reporte r = new Reporte();
                            r.SetREPORTE1("AcuseCalibracion");
                            r.Show();
                        }
                        MessageBox.Show("Completado");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al ejecutar");
                    }

                    EQ.Clear();
                    DisplayStringListInDataGrid(EQ, dataGridView2, " ");
                    //dataGridView1.Columns.Clear();
                    this.getAvailableTableAdapter.Fill(this.getAvailableDataSet.GetAvailable);
                }
                else
                {
                    MessageBox.Show("Verifique el formato de los datos");
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 53)
                {
                    MessageBox.Show("Verifique su conexión");
                }
                MessageBox.Show(sqle.Message);
                MessageBox.Show(sqle.ToString());
            }
            catch (SmtpException smtpEx)
            {
                //Si ocurre algun problema de envio del correo se escribe el ultimo correo en un htmnl en rl folder del programa
                //Y se pregunta al usuario si quiere reintentar el envio
                File.WriteAllText("./LastSent.html", Body + "<!--" + Email + "-->");
                MessageBox.Show("No se ha podido enviar el correo elecrónico\n con los elementos asignados.\n Verifique su conexión");
                DialogResult dialog = MessageBox.Show("¿Desea reintentar enviar el correo?",
                    "", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    try
                    {
                        mail();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Problema persistente.\n El programa no puede enviar el correo electrónico.");
                        MessageBox.Show(ex.Message);
                        Close();
                    }
                }

                MessageBox.Show(smtpEx.Message);
                MessageBox.Show(smtpEx.ToString());
            }
            catch (WebException wex)
            {
                MessageBox.Show(wex.Message);
                MessageBox.Show(wex.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void perm_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Se modifica el comportamiento del form dependiendo de los valores de
            //permanencia que serán asignados
            string asg1 = perm.Text;
            if (asg1 == "SERVICIO")
            {
                Location.Enabled = true;
                Ings.Enabled = true;
                fsr.Enabled = true;
            }
            else if (asg1.Contains("PERMANENTE"))
            {
                //Location.Enabled = true;
                Ings.Enabled = true;
                //fsr.Enabled = true;
            }
            else if (asg1.Contains("CALIBRACIÓN"))
            {
                Location.Enabled = true;
                DataSet dsDataFromDB1 = ft.DS(ft.connectionString, "select * from Laboratorio order by nombre asc");
                Location.DataSource = dsDataFromDB1.Tables[0];
                Location.DisplayMember = "Nombre";
                Location.ValueMember = "IdLaboratorio";
            }
            else
            {
                Location.Enabled = false;
                Ings.Enabled = false;
                fsr.Enabled = false;
            }
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView1.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView2_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dataGridView2.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // dataGridView1.Rows[e.RowIndex].Selected = true;
        }

        public AsignarP2(int idu, int idr)
        {
            InitializeComponent();
            IDU = idu;
            IDR = idr;
            DoubleBuffered(dataGridView1, true);
            DoubleBuffered(dataGridView2, true);
        }
    }
}