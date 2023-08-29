using MaterialSkin.Controls;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CTZ
{
    public partial class ModUsosCert : MaterialForm
    {
        private int IDU, IDROL; private string IDREG;

        private Functions ft = new Functions();


        //carga el uso del certificado en el combo
        private void ModUsosCert_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'documentacionDataSet.Uso' table. You can move, or remove it, as needed.
            this.usoTableAdapter.Fill(this.documentacionDataSet.Uso);
            string sql = "select uso.Descripcion from detalleCert " +
                        "inner join uso on uso.IdUso = detalleCert.idUso " +
                        "where idDetalleCert = " + IDREG + ";";
            //Se obtiene el uso actual asignado al certificado
            //Para seleccionarlo en el combobox
            SqlDataReader read = ft.GetRead(sql);
            if (read != null)
            {
                materialComboBox1.SelectedIndex = materialComboBox1.FindStringExact(read.GetValue(0).ToString());//elemento exacto de la BD
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            string sql = "update detallecert set iduso=" + materialComboBox1.SelectedValue + " where iddetallecert=" + IDREG + " ;";
            if (!ft.SetSql(sql))
            {
                MessageBox.Show("Ha ocurrido un problema. \n Cambio NO guardado");
            }
        }

        //elimina todo el detalle ?****
        private void delete_Click(object sender, EventArgs e)
        {
            string sql = "delete from detallecert where iddetallecert= " + IDREG + ";";
            DialogResult dr = MessageBox.Show("¿Seguro qué desea eliminar este registro?", "", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (!ft.SetSql(sql))
                {
                    MessageBox.Show("Ha ocurrido un problema. \n registro NO guardado");
                }
                else
                {
                    this.Close();
                }
            }
        }

        public ModUsosCert(int idu, int idrol, string idreg)
        {
            //En esta clase se puede seleccionar un nuevo uso para un certificado o
            //eliminar la tupla actual con el uso mostrado de la tabla detallecertificado
            InitializeComponent();
            IDU = idu;
            IDROL = idrol;
            IDREG = idreg;
            this.Text = "Modificar Uso";
        }
    }
}