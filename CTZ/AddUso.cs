using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddUso : MaterialForm
    {
        private string Table, Col = "descripcion";
        private Functions ft = new Functions();
        private string queryString, Uso1;

        //Realiza cambios en diversas tablas, dependiendo de, desde donde se abra el formulario
        public AddUso()
        {
            InitializeComponent();
        }

        public AddUso(string table, string uso1)
        {   /*Clase Multiproposito para actualizar información de estructura similar
            en tablas distintas
            */
            Table = table;
            Uso1 = uso1;
            InitializeComponent();
            switch (table)
            {
                //Tablas para contruir el query de actualización
                case "uso":
                    this.Text = "Modificar Uso";
                    uso.Text = uso1;
                    save.Text = "Modificar";
                    break;

                case "modeloi":
                    this.Text = "Modificar Modelo";
                    uso.Text = uso1;
                    save.Text = "Modificar";
                    break;

                case "marcai":
                    this.Text = "Modificar Marca";
                    uso.Text = uso1;
                    Col = "Nombre";
                    save.Text = "Modificar";
                    break;

                case "certificado":
                    this.Text = "Modificar certificado";
                    uso.Text = uso1;
                    Col = "certificado";
                    save.Text = "Modificar";
                    break;

                case "Laboratorio":
                    this.Text = "Modificar";
                    uso.Text = uso1;
                    Col = "Laboratorio";
                    direccion.Visible = true;
                    save.Text = "Modificar";
                    break;
            }
            queryString = "update " + Table + " set " + Col + "='";
        }

        public AddUso(string table, string uso1, string dir)
        {
            /*Clase Multiproposito para actualizar información de estructura similar
           en tablas distintas
           */
            Table = table;
            Uso1 = uso1;
            InitializeComponent();
            switch (table)
            {
                //Tablas para construir el query de actualización
                case "uso":
                    this.Text = "Modificar Uso";
                    uso.Text = uso1;
                    save.Text = "Modificar";
                    break;

                case "modeloi":
                    this.Text = "Modificar Modelo";
                    uso.Text = uso1;
                    save.Text = "Modificar";
                    break;

                case "marcai":
                    this.Text = "Modificar Marca";
                    uso.Text = uso1;
                    Col = "Nombre";
                    save.Text = "Modificar";
                    break;

                case "certificado":
                    this.Text = "Modificar certificado";
                    uso.Text = uso1;
                    Col = "certificado";
                    save.Text = "Modificar";
                    break;

                case "Laboratorio":
                    this.Text = "Modificar";
                    uso.Text = uso1;
                    Col = "Laboratorio";
                    direccion.Visible = true;
                    direccion.Text = dir;
                    save.Text = "Modificar";
                    break;

                case "FSR":
                    direccion.Visible = false;
                    uso.Hint = "Folio";
                    this.Text = "Nuevo Folio";
                    save.Text = "Modificar";
                    break;
            }
            queryString = "update " + Table + " set " + Col + "='";
        }

        private void AddUso_Load(object sender, EventArgs e)
        {

        }

        public AddUso(string table)
        {
            /*Clase Multiproposito para actualizar información de estructura similar
           en tablas distintas
           */
            Table = table;
            InitializeComponent();
            switch (Table)
            {
                //Tablas para insertar infromación

                case "disponibilidad": //Estatus del sensor

                    this.Text = "Estatus";
                    break;

                case "MarcaI":

                    Col = "nombre";
                    this.Text = "Nueva Marca";
                    break;

                case "MarcaE":

                    Col = "nombre";
                    this.Text = "Marca Externa";
                    break;

                case "Procedimiento":

                    this.Text = "Procedimiento";
                    break;

                case "Laboratorio":

                    Col = "nombre";
                    direccion.Visible = true;
                    this.Text = "Laboratorio";
                    break;

                case "Magnitudes":

                    this.Text = "Magnitud";
                    break;

                case "ModUso":
                    this.Text = "Modificar Uso";
                    break;
            }
            queryString = "insert into " + Table + "(" + Col + ")values('";
        }

        private void save_Click(object sender, EventArgs e)
        {
            //DocumentacionConnectionString

            try
            {
                if (ft.IsValid(uso.Text))
                {
                    //Selección de rutina(actualización o inserción)
                    if (save.Text == "Modificar")
                    {
                        if (Table.Contains("Laboratorio"))
                        {
                            queryString = "update laboratorio set Nombre='" + uso.Text + "',direccion='" + direccion.Text + "' where nombre='" + Uso1 + "'";
                        }
                        else if (Table.Contains("FSR"))
                        {
                            queryString = "Update detalleasignacion set fsr=" + uso.Text + " where iddetallea=" + Uso1;
                        }
                        else
                        {
                            //realiza la insercion en la tabla correspondiente
                            queryString += uso.Text + "' where " + Col + "='" + Uso1 + "';";
                        }
                    }
                    else
                    {
                        if (Table.Contains("Laboratorio"))
                        {
                            queryString = "insert into " + Table + "(" + Col + ",direccion)values('" + uso.Text + "','" + direccion.Text + "')";
                        }
                        else
                        {
                            queryString += uso.Text + "')";
                        }
                    }

                    if (ft.SetSql(queryString))
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("El campo no puede ir vacío");
                }
            }
            catch (SqlException sqle)
            {
                //no permite repertir primary key dentro de la tabla 
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
                MessageBox.Show(ex.ToString());
            }
        }
    }
}