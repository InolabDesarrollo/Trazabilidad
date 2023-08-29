using AutoUpdaterDotNET;
using CTZ;
using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace TestSpire
{
    /*
     * Este proyecto ocupa una libreria llamada MaterialForms que le da ese aspecto Material Design
     * e incluye los elementos comolos campos de texto y comboboxes con pequeñas animaciones, los colores
     * fuentes etc.
     */

    public partial class LogIn : MaterialForm//Si se requiere usar Forms normales solo basta cambiar MaterialForm por Form en esta linea
    {
        private string path = System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        private CTZ.Functions ft = new CTZ.Functions();

        private void Timer1_Tick(object sender, EventArgs e)
        {
            AutoUpdater.Start(@"\\192.168.15.134\Public\Ejecutables\CTZ\versions.xml");
            AutoUpdater.ShowSkipButton = false;//Se pueden modificar elementos del AutoUpdater directo desde el código o desde el xml en public
        }

        public LogIn()
        {
            try
            {
                //AutoUpdater activo cada 5 Minutos
                Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName().Version);
                AutoUpdater.Start(@"\\192.168.15.134\Public\Ejecutables\CTZ\versions.xml");
                AutoUpdater.ShowSkipButton = false;
                InitializeComponent();
                Timer timer = new Timer();
                timer.Interval = 1 * 1000 * 60 * 5; // 5 Min
                timer.Tick += new EventHandler(Timer1_Tick);
                timer.Start();

                ft.Material(this);

                version.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private Functions FT = new Functions();

        private void Ingresar()
        {
            try
            {
                SqlDataReader dr = ft.GetLog(user.Text, pass.Text);//Obtencion de información del usuario
                if (dr != null)
                {
                    Usr.K = (int)dr.GetValue(dr.GetOrdinal("IdUsuario"));
                    Usr.Joi = (int)dr.GetValue(dr.GetOrdinal("IdRol"));
                    Usr.Rick = (int)dr.GetValue(dr.GetOrdinal("IdArea"));
                    if (dr.GetValue(dr.GetOrdinal("Mail")) is DBNull)
                    {
                    }
                    else
                    {
                        Usr.Mail = (string)dr.GetValue(dr.GetOrdinal("Mail"));
                    }
                    if (Usr.Rick == 5 || Usr.Rick == 4)
                    {
                        this.Hide();

                        Form1 Inicio = new Form1(Usr.K, Usr.Joi, Usr.Rick, Usr.Nombre);
                        Inicio.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no reconocidos");
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.ErrorCode == 40)
                {
                    MessageBox.Show("No se puede conectar con la BD.");
                }
                else
                {
                    MessageBox.Show(sqle.Message);
                    MessageBox.Show(sqle.ToString());
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void LogIn_Activated(object sender, EventArgs e)
        {
        }

        private void pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                Ingresar();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            Ingresar();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
        }
    }
}