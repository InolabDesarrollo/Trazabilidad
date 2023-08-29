using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddEquipo : MaterialForm
    {
        private Functions ft = new Functions();
        private string ident;
        private int IDU;
        private const int CP_NOCLOSE_BUTTON = 0x200;
        /*protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/

            //Se abre despues de crear un equipo nuevo para agregar datos faltantes
        public AddEquipo(int idu)
        {
            IDU = idu;
            InitializeComponent();
            ft.Material(this);
        }

        public AddEquipo(string Ident, int idu)
        {
            /*
             * Aqui se detalla un nuevo equipo, se agrega su información extra en la tabla detaleequipo
             *
             */
            IDU = idu;
            ident = Ident;
            InitializeComponent();
            ft.Material(this);
        }

        private void AddEquipo_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'documentacionDataSet.DetalleEquipo' table. You can move, or remove it, as needed.
                this.detalleEquipoTableAdapter.Fill(this.documentacionDataSet.DetalleEquipo);
                // TODO: This line of code loads data into the 'documentacionDataSet1.Equipo' table. You can move, or remove it, as needed.
                this.equipoTableAdapter.Fill(this.documentacionDataSet1.Equipo);
                // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Certificado' Puede moverla o quitarla según sea necesario.
                //this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);
                // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.ModeloI' Puede moverla o quitarla según sea necesario.
                this.modeloITableAdapter.Fill(this.documentacionDataSet.ModeloI);
                // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Disponibilidad' Puede moverla o quitarla según sea necesario.
                this.disponibilidadTableAdapter.Fill(this.documentacionDataSet.Disponibilidad);
                // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Uso' Puede moverla o quitarla según sea necesario.
                this.usoTableAdapter.Fill(this.documentacionDataSet.Uso);
                certChBx.Checked = false;
                certificado.Enabled = false;

                DataSet dsDataFromDB11 = ft.GetDataFromDatabaseinDataSet("getmarcai");
                brand.DataSource = dsDataFromDB11.Tables[0];
                brand.DisplayMember = "Nombre";
                brand.ValueMember = "IdMarca";
                /*
                 * Si un equipo ya cuenta con un registro en la tabla detalleequipo se intentara recuperar su información
                 */
                if (ident != null)
                {
                    equipo.SelectedIndex = equipo.FindStringExact(ident);

                    string sql = "declare @id as int;" +
                                " declare @ident as varchar(25) = '" + ident + "'; " +
                                 " set @id = (select idequipo from equipo where Identificacion = @ident ) " +
                                " select DetalleEquipo.IdEquipo, uso.Descripcion from detalleequipo" +
                                " inner join uso on uso.IdUso = DetalleEquipo.IdUso" +
                                " where DetalleEquipo.IdEquipo = @id"; //busca el detalle del equipo si existe
                    SqlDataReader read = ft.GetRead(sql);
                    if (read != null && read.Read())
                    {
                        equipo.SelectedValue = read.GetValue(0);
                        if (ft.IsValid(read.GetValue(1).ToString()))
                        {
                            uso.FindString(read.GetValue(1).ToString());
                        }
                        DataSet dsDataFromDB1 = ft.GetCertU(uso.SelectedValue.ToString());
                        certificado.DataSource = dsDataFromDB1.Tables[0];
                        certificado.DisplayMember = "certificado";
                        certificado.ValueMember = "idCert";
                    }
                    equipo.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (equipo.SelectedIndex != -1)
                {
                    /*
                     * Se crea un historial de detalles de equipo dónde se tienen los certificados que le han sido asignados a los equipos
                     * por eso se crea un query insert en vez de solo hacer un update
                     */
                    string queryString =
                   "Insert into DetalleEquipo(Idequipo, IdUso, IdDisp, IdCertificado, IdModelo,FechaRegistro,idusuario,observaciones)values(" + equipo.SelectedValue + ", " + uso.SelectedValue + ", " + disp.SelectedValue + ", " + certificado.SelectedValue + ", " + modelo.SelectedValue + ",'" + ft.DateToString1(DateTime.Now) + "'," + IDU + ",'" + observaciones.Text + "');";
                    string sqll = "update detallecert set actual=1 where idCert=" + certificado.SelectedValue + ";";
                    ;
                    if (!certChBx.Checked)
                    {
                        queryString = "Insert into DetalleEquipo(Idequipo, IdUso, IdDisp, IdCertificado, IdModelo,fecharegistro,idusuario)values(" + equipo.SelectedValue + ", " + uso.SelectedValue + ", " + disp.SelectedValue + ", '', " + modelo.SelectedValue + ",'" + ft.DateToString1(DateTime.Now) + "'," + IDU + ");"
                         ;
                        sqll = "";
                    }

                    if (ft.IsValid(sqll))//valida si el texto es correcto para el query
                    {
                        ft.SetSql(sqll, false);
                    }

                    ft.SetSql(queryString);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Seleccione un equipo para continuar.");
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2627)
                {
                    MessageBox.Show("No se pueden repetir elementos en la base de datos.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        //el combo no se puede editar para evitar el cambio de equipo
        private void equipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string sql = "select top 1 modeloi.Descripcion,MarcaI.Nombre as marca from detalleequipo " +
                         "inner join Modeloi on modeloi.IdModeloI = DetalleEquipo.IdModelo " +
                         "inner join MarcaI on ModeloI.IdMarcaI=MarcaI.IdMarca " +
                         "where IdEquipo = " + equipo.SelectedValue;
                SqlDataReader read = ft.GetRead(sql);
                if (equipo.SelectedValue != null)
                {
                    if (read != null)
                    {
                        if (read.FieldCount != 0)
                        {
                            brand.SelectedIndex = brand.FindStringExact(read.GetValue(read.GetOrdinal("marca")).ToString());
                            modelo.SelectedIndex = modelo.FindStringExact(read.GetValue(0).ToString());
                            //equipo.Enabled = false;
                            //modelo.Enabled = false;
                        }
                    }
                }
                else
                {
                    modelo.Enabled = true;
                }
            }
            catch (SqlException)
            {
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        //se activa el combo de para agregar certificado
        private void certChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (certChBx.Checked)
            {
                certificado.Enabled = true;
            }
            else
            {
                certificado.Enabled = false;
            }
        }

        //abre form para crear un nuevo modelo interno en caso de que el requerido no se encuentre en el combo
        private void button1_Click(object sender, EventArgs e)
        {
            AddModelo am = new AddModelo("ModeloI");
            am.ShowDialog(this);
            if (!brand.SelectedValue.ToString().Contains("System.Data.DataRowView"))
            {
                DataSet dsDataFromDB1 = ft.GetModeloIm(brand.SelectedValue.ToString());
                modelo.DataSource = dsDataFromDB1.Tables[0];
                modelo.DisplayMember = "ModeloI";
                modelo.ValueMember = "IdModeloI";
            }
        }

        //se abre el form para crear un certificado nuevo
        private void addCert_Click(object sender, EventArgs e)
        {
            AddCert ac = new AddCert(IDU);
            ac.ShowDialog(this);
            DataSet dsDataFromDB1 = ft.GetCertU(uso.SelectedValue.ToString());
            certificado.DataSource = dsDataFromDB1.Tables[0];
            certificado.DisplayMember = "certificado";
            certificado.ValueMember = "idCert";
            //this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);
        }

        //se toman los diferentes usos existentes
        private void uso_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet dsDataFromDB1 = ft.GetCertU(uso.SelectedValue.ToString());
            certificado.DataSource = dsDataFromDB1.Tables[0];
            certificado.DisplayMember = "certificado";
            certificado.ValueMember = "idCert";
        }

        private void certificado_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void disp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = disp.Text;
        }

        //combo Brand-Marca
        private void brand_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!brand.SelectedValue.ToString().Contains("System.Data.DataRowView"))//*******POR QUE SE HACE ESTE COMPARATIVO*******
                //Compra la opcion seleccionada para asegurar que se muestren de manera correcta
            {
                Console.WriteLine("Contains: " + brand.SelectedValue.ToString().Contains("System.Data.DataRowView"));

                DataSet dsDataFromDB1 = ft.GetModeloIm(brand.SelectedValue.ToString());
                modelo.DataSource = dsDataFromDB1.Tables[0];
                modelo.DisplayMember = "ModeloI";
                modelo.ValueMember = "IdModeloI";
            }
        }

        private void modelo_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                if (!reader.GetValue(2).ToString().Contains("null"))//*********POR QUE SE HACE ESTE COMPRATIVO***********
                {
                    descr.Text = reader.GetValue(2).ToString();
                }
                else
                {
                    descr.Text = "Sin descripcion.";
                }
            }
        }

        /*
         CONTAINS:
            Devuelve un valor que indica si una cadena especificada aparece dentro de esta cadena, mediante las reglas de comparación especificadas.
         */
    }
}