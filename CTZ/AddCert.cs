using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddCert : MaterialForm
    {
        private Functions ft = new Functions();
        private int IDU;
        private string us, NoCert;
        private bool assignar;

        public string GetUs()
        {
            return us;
        }

        public void SetUs(string value)
        {
            us = value;
        }

        //Toma el id del usuario que inicia sesion
        public int GetIDU1()
        {
            return IDU;
        }

        public void SetIDU1(int value)
        {
            IDU = value;
        }

        public SqlDataReader GetCertU1()
        {
            return CertU;
        }

        public void SetCertU1(SqlDataReader value)
        {
            CertU = value;
        }

        private SqlDataReader CertU;

        public bool Assignar { get => assignar; set => assignar = value; }

        public string GetNoCert1()
        {
            return NoCert;
        }

        public void SetNoCert1(string value)
        {
            NoCert = value;
        }

        public AddCert(int idu)
        {
            SetIDU1(idu);
            InitializeComponent();
        }

        public AddCert()
        {
            /*Clase multiproposito
             donde se pueden dar de alta nuevos certificados
             y se pueden Modificar
             */
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                if (save.Text == "Modificar")
                {
                    string linkText = "'" + link.Text + "'";
                    if (linkText == "" || linkText.Length <= 2)
                    {
                        linkText = "NULL";
                    }
                    string query = "update certificado set intervalodemedida='" + intervalo.Text +
                        "',fechacalibracion='" + ft.DateToString(calibracion.Value) +
                        "',proximacalibracion='" + ft.DateToString(nxtCalibracion.Value) + "',link=" + linkText +
                        " where certificado='" + GetNoCert1() + "';";
                    string query2 = "declare @idcert int;" +
                        "set @idcert=(select idcertificado from certificado where certificado='" + GetNoCert1() + "')" +
                        "Update detallecert set IdLab=" + Lab.SelectedValue + "where idcert=@idcert;";
                    query = query + query2;
                    ft.SetSql(query);
                    Assignar = true;
                }
                else
                {
                    //Se guarda la info en las tablas de Cetificado y detalleCert
                    if (
                    ft.IsValid(intervalo.Text)

                    && ft.IsValid(cert.Text)
                    )
                    {
                        string linkText = "'" + link.Text + "'";
                        if (linkText == "" || linkText.Length <= 2)
                        {
                            linkText = "NULL";
                        }

                        string query = "declare @idcert int; insert  into certificado(IntervaloDeMedida,FechaCalibracion,ProximaCalibracion,link,certificado) " +
                                       "Values('" + intervalo.Text + "', '" + ft.DateToString(calibracion.Value) + "', '" + ft.DateToString(nxtCalibracion.Value) + "', " + linkText + ", '" + cert.Text + "');" +
                                    "set @idcert = (SCOPE_IDENTITY());" +
                                    "insert into detalleCert(iduso, idcert, fecharegistro, idusuario,IdLab) values(" + use.SelectedValue + ", @idcert, SYSDATETIME(), " + GetIDU1() + "," + Lab.SelectedValue + ");";
                        ft.SetSql(query);
                    }
                    else
                    {
                        MessageBox.Show("Verifique el formato de los campos.");
                    }
                }
                Close();
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2627)
                {
                    MessageBox.Show("No se pueden repetir elementos en la base de datos.");
                }
                else
                {
                    MessageBox.Show(sqle.Message);
                    MessageBox.Show(sqle.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.ToString());
            }
        }

        private void calibracion_ValueChanged(object sender, EventArgs e)
        {
            nxtCalibracion.Value = calibracion.Value.AddYears(1);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("Laboratorio");
            au.ShowDialog(this);
            this.laboratorioTableAdapter.Fill(this.dSctz.Laboratorio);
        }

        private void AddCert_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GetUs() == "Actualizar Certificado" && Assignar)
            {
                DialogResult dialogResult = MessageBox.Show("¿Desea Asignar el Certificado?", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    AddEquipo ae = new AddEquipo(IDU);
                    ae.ShowDialog(this);
                }
            }
        }

        //boton desasignar
        private void unassign_Click(object sender, EventArgs e)
        {
            //Query para desasignar el certificado
            //Se pone en 0 todos los registros de detalleequipo donde se tenía este certificado
            //Y en la tabla detalleCertificado se coloca el valor 0 en la columna 'actual' lo que indica que el certificado fue desasignado
            //Los valores en la columna 'actual' de detallecertificado pueden ser null(nuevo certificado no asignado),
            //1(El certificado está asignado a algún equipo en la tabla detalleequipo) y 0(el certificado fue desasignado)
            string query = "Update detalleequipo set idcertificado=0 where  idcertificado=(select idcertificado from certificado where certificado='" + GetNoCert1() + "');" +
                "update detallecert set actual=0 where idcert=(select idcertificado from certificado where certificado='" + GetNoCert1() + "');";
            ft.SetSql(query);
        }

        private void AddCert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dSctz.Laboratorio' table. You can move, or remove it, as needed.
            this.laboratorioTableAdapter.Fill(this.dSctz.Laboratorio);
            // TODO: This line of code loads data into the 'documentacionDataSet.Uso' table. You can move, or remove it, as needed.
            this.usoTableAdapter.Fill(this.documentacionDataSet.Uso);
            //Rutina de comportamiento de la clase
            switch (GetUs())
            {
                case "Actualizar Certificado":

                    save.Text = "Modificar";
                    this.Text = "Modificar Certificado: " + GetNoCert1();
                    string sql = "declare @idc int;" +
                            "set @idc = (select idcertificado from certificado where certificado = '" + GetNoCert1() + "');" +

                            "select certificado.*,detallecert.idUso,uso.Descripcion,Laboratorio.Nombre as lab from Certificado " +
                            "inner join detalleCert on detallecert.idCert = @idc " +
                            "inner join uso on uso.IdUso = detallecert.idUso " +
                            "left join laboratorio on detallecert.idlab=laboratorio.IdLaboratorio " +
                            "where IdCertificado = @idc";
                    SetCertU1(ft.GetRead(sql));//Recuperación de información del certificado de la Tabla certificado y detallecertificado
                    if (GetCertU1() != null)
                    {
                        intervalo.Text = GetCertU1().GetValue(1).ToString();
                        calibracion.Value = ft.ToDate(GetCertU1().GetValue(2).ToString());
                        nxtCalibracion.Value = ft.ToDate(GetCertU1().GetValue(3).ToString());//informacion de siguiente calibracion(datetime)
                        cert.Enabled = false;//No se puede Modificar el Número de certificado ya que son unicos
                        cert.Text = GetCertU1().GetValue(5).ToString();
                        link.Text = GetCertU1().GetValue(4).ToString();
                        //use.SelectedIndex = use.FindStringExact(GetCertU1().GetValue(7).ToString());
                        use.Visible = false;
                        if (!(GetCertU1().GetValue(GetCertU1().GetOrdinal("lab")) is DBNull))//Laboratorio emisor del certificado
                        {
                            Lab.SelectedIndex = Lab.FindStringExact(GetCertU1().GetValue(GetCertU1().GetOrdinal("lab")).ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Certificado NO cuenta con datos cargados");
                    }

                    break;

                default:
                    //Close();
                    break;
            }
        }
    }
}