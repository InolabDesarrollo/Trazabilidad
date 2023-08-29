using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddEquipoP1 : MaterialForm
    {
        private int IDU;

        public AddEquipoP1(int idu)
        {
            /*En esta clase se dan de alta la informacion de la tabla equipo que funciona como un catalogo de equipos
             */
            IDU = idu;
            InitializeComponent();
            ft.Material(this);
        }

        private Functions ft = new Functions();

        private void Save_Click(object sender, EventArgs e)
        {
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (ft.IsValid(noserie.Text) && ft.IsValid(ident.Text) && ident.Text.Contains("EQ-INO-")) //todos los equipos deben iniciar con esta estructura y con texto valido
                {
                    string queryString =
                   "Insert into Equipo(NoSerie, Identificacion,ManualUsuario)values('" + noserie.Text + "', '" + ident.Text + "','" + manual.Text + "');"; //se crea query para insertar datos
                    if (ft.SetSql(queryString))
                    {
                        this.Close();
                        AddEquipo ae = new AddEquipo(ident.Text, IDU); //se abre formulario para agregar los detalles del equipo
                        ae.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un problema al guardar los datos en el servidor.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un equipo para continuar.");
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2627)//error en la conexion con la base de datos
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

        private void AddEquipoP1_Load(object sender, EventArgs e)
        {

        }
    }
}