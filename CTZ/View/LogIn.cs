using AutoUpdaterDotNET;
using CTZ;
using CTZ.Vista;
using MaterialSkin.Controls;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using System.Dynamic;
using System.Reflection;
using System.Windows.Forms;

namespace TestSpire
{
    public partial class LogIn : MaterialForm
    {
        const int IntervalFiveMinutes = (1 * 1000 * 60 * 5);
        const int Calidad = 4;
        const int Gerencia = 5;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            AutoUpdater.Start(@"\\192.168.15.134\Public\Ejecutables\CTZ\versions.xml");
            AutoUpdater.ShowSkipButton = false;
        }

        public LogIn()
        {
            try
            {
                Console.WriteLine(System.Reflection.Assembly.GetEntryAssembly().GetName().Version);
                AutoUpdater.Start(@"\\192.168.15.134\Public\Ejecutables\CTZ\versions.xml");
                AutoUpdater.ShowSkipButton = false;
                InitializeComponent();

                Timer timer = new Timer();
                timer.Interval = IntervalFiveMinutes;
                timer.Tick += new EventHandler(Timer1_Tick);
                timer.Start();

                version.Text = Assembly.GetEntryAssembly().GetName().Version.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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

        private void Ingresar()
        {
            try
            {
                if (User.validateUser(user.Text, pass.Text))
                {
                    DataTable userInformation = User.loginUser(user.Text, pass.Text);

                    User.IdUsuario = int.Parse(userInformation.Rows[0]["IdUsuario"].ToString());
                    User.IdRol = int.Parse(userInformation.Rows[0]["IdRol"].ToString());
                    User.IdArea = int.Parse(userInformation.Rows[0]["IdArea"].ToString());
                    User.Mail = userInformation.Rows[0]["Mail"].ToString();

                    if (User.IdArea == Gerencia || User.IdArea == Calidad)
                    {
                        this.Hide();
                        SubMenu subMenu = new SubMenu();
                        subMenu.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña no reconocidos");
                }
            }
            catch (SqlException exeption)
            {
                if (exeption.ErrorCode == 40)
                {
                    MessageBox.Show("No se puede conectar con la BD.");
                }
                else
                {
                    MessageBox.Show(exeption.Message.ToString());
                }
            }
        }

    }
}