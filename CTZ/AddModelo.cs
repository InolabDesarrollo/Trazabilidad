using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddModelo : MaterialForm
    {
        private string Table;
        private string queryString;
        private Functions ft = new Functions();

        //****************NO REALIZA NINGUN PROCESO AL ESTAR DESACTIVADOS LOS CONTROLES - AL INGRESR DESDE EL MENU SUPERIOR DE FORM1******************************
        //se guarda desde Archivo-Nuevo-Equipo-Marca-Modelo, se activan todos los campos y permite el guardado

        public AddModelo()
        {
            InitializeComponent();
        }

        public AddModelo(string modelo)
        {
            /*Clase MultiProposito
             * dependiendo del string modelo dependerá el comportamiento
             */
            InitializeComponent();
            Table = modelo;
            queryString = "insert into " + Table;
            if (modelo == "ModeloE")//Comportamiento para Modelos Externos(Instrumentos de los Laboratorios que calibran los instrumentos de INOLAB), información reservada para las cartas de trazabilidad
            {
                try
                {
                    DataSet dsDataFromDB = ft.GetDataFromDatabaseinDataSet("getmarcae");
                    marcas.DataSource = dsDataFromDB.Tables[0];
                    carac.Visible = false;
                    materialLabel3.Visible = false;
                    model.Visible = false;
                    materialLabel4.Visible = false;
                    rango.Visible = false;
                    materialLabel5.Visible = false;
                    marcas.DisplayMember = "Nombre";
                    marcas.ValueMember = "IdMarcaE";
                    queryString += " (Descripcion,IdMarcaE) ";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    MessageBox.Show(exc.ToString());
                }
                this.Text = "Modelo(externo)";
            }
            else if (modelo == "ModeloI")//Modelos internos, Modelos de los instrumentos que se usan en INOLAB
            {
                try
                {
                    DataSet dsDataFromDB = ft.GetDataFromDatabaseinDataSet("getmarcai");
                    marcas.DataSource = dsDataFromDB.Tables[0];
                    marcas.DisplayMember = "Nombre";
                    marcas.ValueMember = "IdMarca";
                    queryString += " (Descripcion,IdMarcaI,Caracteristica,ModeloI,rango) ";
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    MessageBox.Show(exc.ToString());
                }
                this.Text = "Modelo(interno)";
            }
        }

        private void addBrand_Click(object sender, EventArgs e)
        {
            //cambia las marcas a internas al agregar alguna nueva o presionar el boton
            AddUso au = new AddUso("MarcaI");

            au.ShowDialog(this);
            DataSet dsDataFromDB = ft.GetDataFromDatabaseinDataSet("getmarcai");
            marcas.DataSource = dsDataFromDB.Tables[0];
            marcas.DisplayMember = "Nombre";
            marcas.ValueMember = "IdMarca";
        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                //no realiza ningun cambio si no se ven todos los controles
                if (
                   ft.IsValid(desc.Text)
                    && marcas.SelectedIndex != -1
                    && ft.IsValid(model.Text)
                    && ft.IsValid(desc.Text)
                    || (ft.IsValid(carac.Text)
                    && carac.Visible == true
                    && model.Visible == true
                    )

                    )
                {
                    //Seleccion de modelo de string donde se guardan los datos
                    if (Table == "ModeloE")
                    {
                        queryString += "values('" + desc.Text + "','" + marcas.SelectedValue + "')";
                    }
                    else if (Table == "ModeloI")
                    {
                        queryString += "values('" + desc.Text + "','" + marcas.SelectedValue + "','" + carac.Text + "','" + model.Text + "','" + rango.Text + "')";
                    }
                    if (ft.SetSql(queryString))
                    {
                        this.Close();
                    }
                }
                else
                {
                    if (!ft.IsValid(desc.Text))
                    {
                        MessageBox.Show("La descripción no puede estar vacia");
                        desc.Focus();
                    }
                    else if (
                        (!ft.IsValid(carac.Text))
                    && carac.Visible == true
                    )
                    {
                        
                        MessageBox.Show("La característica no puede ir vacia.");
                        desc.Focus();
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.ToString());
            }
        }

        private void AddModelo_Load(object sender, EventArgs e)
        {

        }
    }
}