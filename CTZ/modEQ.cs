using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class modEQ : MaterialForm

    {
        private Functions ft = new Functions();
        private SqlDataReader read;
        private string idr, identif;
        private int IDU, IDROL, NoCert;
        private string qq;

        private string temp;

        public modEQ()
        {
            InitializeComponent();
        }

        private void Actualizar()
        {
            try
            {
                //Obtención de Certificados dependiendo del 'uso' seleccionado
                string like = read.GetValue(1).ToString();//'Uso' asignado en detalleequipo
                if (like != uso.GetItemText(uso.SelectedItem))
                {
                    /*Si el 'uso' de la tabla es distinto al seleccionado en el combobox
                     * se buscan los certificados libres de este 'nuevo' uso y los certificados previamente asignados
                     * a este equipo
                     */
                    DataSet dsDataFromDB1 = ft.GetCertU1(uso.SelectedValue.ToString());
                    cert.DataSource = dsDataFromDB1.Tables[0];
                    cert.DisplayMember = "cer";
                    cert.ValueMember = "IdCertificado";
                }
                else
                {
                    /*Se buscan todos los certificados libres de este uso y los que hayan sifo previamente
                     * asignados a este equipo con el uso de la tabla detalleequipo
                     */
                    DataSet dsDataFromDB1 = ft.GetCertU(uso.SelectedValue.ToString(), ident.Text);
                    cert.DataSource = dsDataFromDB1.Tables[0];
                    cert.DisplayMember = "certificado";
                    cert.ValueMember = "idCertificado";
                    cert.SelectedIndex = cert.FindStringExact(read.GetValue(7).ToString());
                    cert.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        public modEQ(string identi, string IDR, int idu, int idrol)
        {
            //Clase para la modificación de un equipo
            ft.Material(this);
            idr = IDR;
            IDU = idu;
            IDROL = idrol;
            identif = identi;
            string sql = "declare @id as int;" +
                        "set @id = (select IdEquipo from equipo where Identificacion = '" + identi + "');" +
                                    "select equipo.NoSerie,uso.descripcion,disponibilidad.Descripcion,ModeloI.modeloi, " +
                        "MarcaI.Nombre,detalleequipo.idequipo,modeloi.rango as Rango,certificado.certificado as Certificado,certificado.idcertificado " +
                        "from DetalleEquipo " +
                        "INNER JOIN EQUIPO ON equipo.idequipo = @id " +
                        "inner join uso on uso.IdUso = DetalleEquipo.iduso " +
                        "inner join disponibilidad on Disponibilidad.IdDisp = DetalleEquipo.IdDisp " +
                        "inner join ModeloI on modeloi.IdModeloI = DetalleEquipo.IdModelo " +
                        "inner join MarcaI on MarcaI.IdMarca = ModeloI.IdMarcaI " +
                        "left join certificado on certificado.IdCertificado = DetalleEquipo.IdCertificado " +
                        "where DetalleEquipo.IdEquipo = @id and detalleequipo.iddetalleequipo = " + IDR + " ;";
            InitializeComponent();
            if (!idr.Contains("No Asignado"))
            {
                read = ft.GetRead(sql);//Recuperación de información de las tablas equipo y detalleequipo
                //A los usuarios administradores se les muestra el boton para eliminar el equipo
                //Y el boton para desasignar el certificado mostrado
                if (IDROL != 5)
                {
                    delete.Visible = false;
                    unassign.Visible = false;
                }
                label3.Text = "Registro: " + IDR;

                DataSet dsDataFromDB1 = ft.GetDataFromDatabaseinDataSet("getmarcai");
                brand.DataSource = dsDataFromDB1.Tables[0];
                brand.DisplayMember = "Nombre";
                brand.ValueMember = "IdMarca";

                noserie.Text = read.GetValue(0).ToString();
                ident.Text = identi;
                Range.Text = read.GetValue(read.GetOrdinal("Rango")).ToString();
                Range.Enabled = false;
            }
        }

        private void modEQ_Load(object sender, EventArgs e)
        {
            /*Este if hace referencia a que el equipo tiene informacion en la tabla Equipo
             * pero no cuenta con una tupla ligada en la tabla detalleequipo
             */
            if (idr.Contains("No Asignado"))
            {
                MessageBox.Show(identif + " NO cuenta con detalles para mostrar");
                this.Close();
            }
            else
            {
                // TODO: This line of code loads data into the 'documentacionDataSet.Certificado' table. You can move, or remove it, as needed.
                //this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);

                // TODO: This line of code loads data into the 'documentacionDataSet.Disponibilidad' table. You can move, or remove it, as needed.
                this.disponibilidadTableAdapter.Fill(this.documentacionDataSet.Disponibilidad);
                // TODO: This line of code loads data into the 'documentacionDataSet.Uso' table. You can move, or remove it, as needed.
                this.usoTableAdapter.Fill(this.documentacionDataSet.Uso);
                // TODO: This line of code loads data into the 'documentacionDataSet.ModeloI' table. You can move, or remove it, as needed.
                //this.modeloITableAdapter.Fill(this.documentacionDataSet.ModeloI);
                uso.SelectedIndex = uso.FindStringExact(read.GetValue(1).ToString());//coincidencia exacta (FindStringExact) a seleccionar del dato de la consulta
                disp.SelectedIndex = disp.FindString(read.GetValue(2).ToString());//coincidencia parcial (FindString) al seleccionar indice del combo con dato de consulta

                brand.SelectedIndex = brand.FindString(read.GetValue(4).ToString());

                string mod = read.GetValue(3).ToString();

                DataSet dsDataFromDB11 = ft.GetModeloIm(brand.SelectedValue.ToString());
                modelo.DataSource = dsDataFromDB11.Tables[0];
                modelo.DisplayMember = "ModeloI";
                modelo.ValueMember = "IdModeloI";
                modelo.SelectedIndex = modelo.FindString(mod);

                //Busqueda y selección del certificado
                temp = read.GetValue(7).ToString();
                if (ft.IsValid(temp))
                {
                    //Obtención de certificado asignado, y selección en el combobox
                    DataSet dsDataFromDB1 = ft.GetCertU(uso.SelectedValue.ToString(), ident.Text);
                    cert.DataSource = dsDataFromDB1.Tables[0];
                    cert.DisplayMember = "certificado";
                    cert.ValueMember = "idCertificado";
                    cert.SelectedIndex = cert.FindStringExact(temp);
                    cert.Enabled = true;
                    certCheck.Checked = true;
                }
                else
                {
                    cert.Text = "";
                    cert.SelectedIndex = -1;
                    //cert.SelectedValue = null;
                    cert.Enabled = false;
                    unassign.Visible = false;
                    certCheck.Checked = false;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            //Rutina para asentar los cambios
            try
            {
                qq = "declare @id as int;" +
                            "set @id = (select IdEquipo from equipo where Identificacion = '" + ident.Text + "') ;" +
                            "update detalleCert set detallecert.actual=0" +
                            "from DetalleEquipo " +
                            "INNER JOIN equipo on Equipo.IdEquipo = @id " +
                            "inner join certificado on certificado.IdCertificado = DetalleEquipo.IdCertificado " +
                            "inner join detalleCert on detalleCert.idCert = certificado.IdCertificado " +
                            "where detallecert.actual = 1  and DetalleEquipo.IdEquipo=@id;";
                string sql = "update equipo set identificacion='" + ident.Text + "',noserie='" + noserie.Text + "' where idequipo=" + read.GetValue(5) + ";";
                string sql2 = "update detalleequipo set iduso='" + uso.SelectedValue + "',iddisp='" + disp.SelectedValue + "',idmodelo='" + modelo.SelectedValue + "' where iddetalleequipo='" + idr + "';";

                sql += sql2;
                string text = disp.Text;
                if (text.Contains("FUERA DE USO"))
                {
                    string sql3 = " declare @id int;" +
                           "set @id = (select idequipo from equipo where identificacion = '" + ident.Text + "'); " +
                           "update detalleasignacion set IdA = 2 where ideq = @id;";
                    sql += sql3;
                }
                else if (text.Contains("CALIBRANDO"))
                {
                    string sql3 = " declare @id int;" +
                           "set @id = (select idequipo from equipo where identificacion = '" + ident.Text + "'); " +
                           "update detalleasignacion set IdA = 4 where ideq = @id;";
                    sql += sql3;
                }
                if (ft.SetSql(sql, true))
                {
                    if (certCheck.Checked)
                    {
                        if (cert.Items.Count > 0 && cert.SelectedIndex != -1)
                        {
                            string sqll = "update detallecert set actual=1 where idCert='" + cert.SelectedValue + "';";
                            string sqlu = "update detalleequipo set iduso='" + uso.SelectedValue + "',iddisp='" + disp.SelectedValue + "',idmodelo='"
                                + modelo.SelectedValue + "',idcertificado='" + cert.SelectedValue + "' where iddetalleequipo='" + idr + "';";

                            if (!(read.GetValue(8) is DBNull) && cert.SelectedValue.ToString() != read.GetValue(8).ToString())
                            {
                                sqlu = "update detallecert set actual=0 where idcert=" + read.GetValue(8).ToString() + ";" +

                            "insert into detalleequipo(idequipo,iduso,iddisp,idcertificado,idmodelo,fecharegistro,idusuario,observaciones)" +
                            "values(@id,'" + uso.SelectedValue + "','" + disp.SelectedValue + "','" + cert.SelectedValue + "','" + modelo.SelectedValue + "',SYSDATETIME(),'" + IDU + "','" + descr.Text + "')"
                            ;
                            }
                            if (ft.SetSql(qq + sqlu, false))
                            {
                                if (ft.SetSql(sqll, false))
                                {
                                }
                                else
                                {
                                    MessageBox.Show("Ha ocurrido algun problema con la Base de datos.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Ha ocurrido algun problema con la Base de datos.");
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ha ocurrido algun problema con la Base de datos.");
                }
                Actualizar();
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

        private void modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //verificar el error al cambiar los modelos
            string sql = "select MarcaI.Nombre,ModeloI.rango,ModeloI.Descripcion from ModeloI " +
                        "inner join MarcaI on MarcaI.IdMarca = ModeloI.IdMarcaI " +
                        "where ModeloI.IdModeloI = " + modelo.SelectedValue + ";";
            if (modelo.SelectedValue != null)
            {
                SqlDataReader reader = ft.GetRead(sql);
                // DataSet dsDataFromDB1 = ft.GetDataFromDatabaseinDataSet("getmarcai");
                //brand.DataSource = dsDataFromDB1.Tables[0];
                //brand.DisplayMember = "Nombre";
                //brand.ValueMember = "IdMarca";
                //brand.SelectedIndex = brand.FindString(reader.GetValue(0).ToString());
                Range.Text = reader.GetValue(1).ToString();
                if (!reader.GetValue(2).ToString().Contains("null"))
                {
                    descr.Text = reader.GetValue(2).ToString();
                }
                else
                {
                    descr.Text = "Sin descripcion.";
                }
            }
        }

        private void cert_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (ft.IsValid(cert.Text))
                {
                    cert.SelectedIndex = cert.FindString(cert.Text);
                }
            }
        }

        private void modelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (ft.IsValid(modelo.Text))
                {
                    modelo.SelectedIndex = modelo.FindString(modelo.Text);
                }
            }
        }

        private void addCert_Click(object sender, EventArgs e)
        {
            AddCert ac = new AddCert(IDU);
            ac.ShowDialog(this);
            Actualizar();
            //this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);
        }

        private void uso_SelectedIndexChanged(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void cert_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!brand.SelectedValue.ToString().Contains("System.Data.DataRowView"))
            {
                DataSet dsDataFromDB1 = ft.GetModeloIm(brand.SelectedValue.ToString());
                modelo.DataSource = dsDataFromDB1.Tables[0];
                modelo.DisplayMember = "ModeloI";
                modelo.ValueMember = "IdModeloI";
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            if (ft.IsValid(identif))
            {
                Historial h = new Historial(identif, IDU, IDROL);
                h.Show();
            }
        }

        private void uso_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string query = "declare @id as int;" +
                            "set @id = (select IdEquipo from equipo where Identificacion = '" + ident.Text + "') ;" +
                            "Update detalleequipo set idcertificado=0 where idequipo=@id;"
                + "update detallecert set actual=0 where idcert=" + cert.SelectedValue + "and iddetalleequipo=" + idr + ";";
            ft.SetSql(query);
        }

        private void certCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (certCheck.Checked)
            {
                cert.Enabled = true;
            }
            else
            {
                cert.Enabled = false;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Seguro que desea eliminar este equipo?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                string SQL = "delete from equipo where identificacion='" + ident.Text + "';";
                if (ft.SetSql(SQL))
                {
                    string sql1 = "declare @id as int;" +
                    "set @id = (select idequipo from equipo where identificacion = '" + ident.Text + "');" +
                    "delete DetalleAsignacion where IdEQ = @id; ";
                    ft.SetSql(sql1, false);
                }
            }
            this.Close();
        }
    }
}