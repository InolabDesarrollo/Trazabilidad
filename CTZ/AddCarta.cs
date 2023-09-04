using System;
using System.Data;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddCarta : Form
    {
        private Functions function = new Functions();

        //GUARDA EN LA TABLA CARTATRAZABILIDAD

        public AddCarta()
        {
            InitializeComponent();
            try
            {
                //No carga los instrumentos en el combo
                instChBx.Checked = false;
                instrumento.Enabled = false;
                DataSet dsDataFromDB = function.GetDataFromDatabaseinDataSet("GetInstrumentos");
                instrumento.DataSource = dsDataFromDB.Tables[0];
                instrumento.DisplayMember = "Equipo";
                instrumento.ValueMember = "IdDetalleinstrumento";
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
                MessageBox.Show(exc.ToString());
            }
        }

        private void AddCarta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Certificado' Puede moverla o quitarla según sea necesario.
            this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string query = "insert into cartatrazabilidad(idCertificado,iddetalleinstrumento,link)values(" + certificado.SelectedValue + "," + instrumento.SelectedValue + ",'" + linked.Text + "')";
            if (!instChBx.Checked)
            {
                query = "insert into cartatrazabilidad(idCertificado,iddetalleinstrumento,link)values(" + certificado.SelectedValue + ",0,'" + linked.Text + "')";
            }
            function.SetSql(query);
        }

        private void instChBx_CheckedChanged(object sender, EventArgs e)
        {
            if (instChBx.Checked)
            {
                instrumento.Enabled = true;
            }
            else
            {
                instrumento.Enabled = false;
            }
        }
    }
}