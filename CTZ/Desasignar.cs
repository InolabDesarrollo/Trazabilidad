using CTZ.DocumentacionDataSet1TableAdapters;
using MaterialSkin.Controls;
using System;
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
    public partial class Desasignar : MaterialForm
    {
        private int IDU, IDROL, idinge;
        private Functions ft = new Functions();

        public void refresh(int id, int idas)
        {
            //Obtención de elementos en detalleasignación asignados a servicio y a un determinado ingeniero
            GetAssignedTableAdapter getassigned = new GetAssignedTableAdapter();
            BindingSource bs = new BindingSource();

            bs.DataSource = getassigned.GetAssignedInge(id, idas);
            dgv_asignados.DataSource = bs;
        }

        public void RefreshAsign(int id)
        {
            //Obtención de elementos en detalleasignación no asignados a algún servicio
            GetAssignatedTableAdapter getAssignatedTable = new GetAssignatedTableAdapter();
            BindingSource bs = new BindingSource();
            bs.DataSource = getAssignatedTable.GetData(id);
            dgv_asignados.DataSource = bs;
        }

        public new static void DoubleBuffered(DataGridView dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                  BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }

        public Desasignar(int idu, int idrol)
        {
            //En esta clase se actualizan los registros de la tabla detalleasignación
            InitializeComponent();
            IDU = idu; IDROL = idrol;
            DoubleBuffered(dgv_asignados, true);
            /*Datos1TableAdapter datos = new Datos1TableAdapter();
            dataGridView1.DataSource = datos.GetByID(index);*/
        }

        private void Desasignar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'asignacionDataSet.Asignacion' table. You can move, or remove it, as needed.
            this.asignacionTableAdapter.Fill(this.asignacionDataSet.Asignacion);
            // TODO: This line of code loads data into the 'getIngesUnas.GetInges' table. You can move, or remove it, as needed.
            this.getIngesTableAdapter.Fill(this.getIngesUnas.GetInges);
        }

        private void inge_SelectedIndexChanged(object sender, EventArgs e)
        {
            idinge = (int)inge.SelectedValue;
            int idas = (int)assigned.SelectedValue;
            refresh(idinge, idas);
        }

        private bool unassign()
        {
            DataGridViewSelectedRowCollection rows = dgv_asignados.SelectedRows;
            foreach (DataGridViewRow row in rows)//loop por cada una de las filas seleccionadas en el datagridview
            {
                /*por cada elemento se genera una transaccion sql para asegurar su correcta actualización y generación de nuevo registro
                 */
                string id = row.Cells[0].Value.ToString();
                string sql1 = "begin TRAN update detalleasignacion set actual=0 where IdEQ=" + id + ";";
                string sql11 = "declare @is as int;" +
                                "declare @id as int = " + id + ";" +

                                                    "set @is = (select count(Certificado.IdCertificado) " +
                                                    "from detalleequipo " +
                                                      "inner join detallecert on detallecert.idCert = DetalleEquipo.IdCertificado " +
                                "inner join equipo on equipo.idequipo = DetalleEquipo.IdEquipo " +
                                "inner join certificado on certificado.IdCertificado = DetalleEquipo.IdCertificado " +
                                "where detalleCert.actual = 1 and DetalleEquipo.IdEquipo = @id and DetalleEquipo.IdCertificado != 0) " +
                                "if @is != 0 " +
                                "begin " +
                                    "Update detalleequipo set IdDisp = 2 where IdEquipo = @id and IdCertificado = @is " +
                                "end " +
                                "else if @is = 0 or @is is null " +
                                "begin " +
                                    "Update detalleequipo set IdDisp = 2 where IdEquipo = @id end  commit TRAN";
                string sql2 = "insert into detalleasignacion(IdUsr,IdEQ,actual,Ida,fecharegistro,idcliente)values(" + IDU + "," + id + ",1,1,SYSDATETIME(),null)";
                sql1 += sql2;
                sql1 += sql11;
                if (!ft.SetSql(sql1, false))
                {
                    return false;
                }
            }
            return true;
        }

        private void dgv_asignados_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            using (SolidBrush b = new SolidBrush(dgv_asignados.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString((e.RowIndex + 1).ToString(), e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 10, e.RowBounds.Location.Y + 4);
            }
        }

        private void assigned_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rutina de comportamiento de acuerdo al elemento seleccionado
            if (assigned.Text.Contains("SERVICIO"))
            {
                inge.Enabled = true;
                dgv_asignados.DataSource = null;
                //RefreshAsign((int)assigned.SelectedValue);
            }
            else if (assigned.Text.Contains("PERMANENTE"))
            {
                inge.Enabled = true;
                RefreshAsign((int)assigned.SelectedValue);
            }
            else
            {
                inge.Enabled = false;
                RefreshAsign((int)assigned.SelectedValue);
            }
        }

        private class smtpConfig
        {
            public string Host { get; set; }
            public int Port { get; set; }
            public string UserName { get; set; }
            public string Password { get; set; }
        }

        private string body;
        public string Body { get => body; set => body = value; }

        private bool mail()
        {
            //Funcion para escribuir un acuse de recibido de los equipos devueltos por los ingenieros en formato html que
            //será enviado por correo al ingeniero uy a quien ha hecho la desasignación de los equipos
            string query = "Select Mail from usuarios where IdUsuario= " + inge.SelectedValue + ";";
            SqlDataReader sdr = ft.GetRead(query, ft.connectionStringBrowser);
            string Email = sdr.GetValue(sdr.GetOrdinal("Mail")).ToString();
            string query1 = "Select Mail from usuarios where IdUsuario= " + User.IdUsuario + ";";
            SqlDataReader sdr1 = ft.GetRead(query1, ft.connectionStringBrowser);
            string ccEmail = sdr1.GetValue(sdr1.GetOrdinal("Mail")).ToString();
            DataGridViewSelectedRowCollection rows = dgv_asignados.SelectedRows;
            if (Email != null)
            {
                string FileName = "MailConfig.json";
                string JsonString = File.ReadAllText(FileName);
                smtpConfig config = JsonSerializer.Deserialize<smtpConfig>(JsonString);

                //MessageBox.Show(JsonSerializer.Deserialize<smtpConfig>(JsonString).ToString());
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
                   " <h1>Instrumentos Devueltos</h1>\n" +
               " </div>\n" +

            "</header>\n" +
            //"<iframe src='https://inolabespecialistasdeservicio.box.com/s/bi0m8dqts2dyl5xj0tkbta29lq3hcnwp' title='W3Schools Free Online Web Tutorials'>" +
            //      "</ iframe > " +
            "<div class='content'>\n" +
            "<div class='ContentHead'>\n" +
             "  <h3>Folio: " + rows[0].Cells[2].Value + "</h3>\n" +
             "  <h3>Cliente: " + rows[0].Cells[6].Value + "</h3>" +
            "</div>\n"
             ;

                string bodyFinal = "</div>\n" +
                        "<footer>\n" +
                        //"   <h1> FooterData </h1>\n" +
                        "</footer>\n" +
                    "</body>\n" +
                "</html>";

                foreach (DataGridViewRow row in rows)
                {
                    Body = Body + "<h5>" + row.Cells[1].Value + "<h5>\n";
                }

                Body = Body + bodyFinal;
                var smtpClient = new SmtpClient(config.Host)
                {
                    Port = config.Port,
                    Credentials = new NetworkCredential(config.UserName, config.Password),
                    EnableSsl = false,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress(config.UserName),
                    Subject = "Instrumentos Asignados",
                    Body = Body,
                    IsBodyHtml = true,
                };
                //CambiarCorreoDeQuienRecibe
                if (IDU == 27)
                {
                    mailMessage.To.Add("ivannarruel@inolab.com");
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
                //File.WriteAllText("./LastSent.html", Body + "<!--" + Email + "-->");
            }

            return true;
        }

        private void un_Click(object sender, EventArgs e)
        {
            try
            {
                //Rutina para desasignar equipos
                if (assigned.Text.Contains("SERVICIO"))
                {
                    if (mail())
                    {
                        if (unassign())
                        {
                            MessageBox.Show("Completado");
                        }
                        else
                        {
                            MessageBox.Show("Ha ocurrido un error al ejecutar");
                        }
                        refresh(idinge, (int)assigned.SelectedValue);
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema mandando el correo.");
                    }
                }
                else
                {
                    if (unassign())
                    {
                        MessageBox.Show("Completado");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error al ejecutar");
                    }
                    refresh(idinge, (int)assigned.SelectedValue);
                }
            }
            catch (SqlException sqle)
            {
                MessageBox.Show(sqle.Message);
                MessageBox.Show(sqle.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgv_asignados_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                dgv_asignados.Rows[e.RowIndex].Selected = true;
            }
        }
    }
}