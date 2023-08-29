using MaterialSkin.Controls;
using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddPuntos : MaterialForm
    {
        private Functions ft = new Functions();

        public AddPuntos()
        {
            /*
             * En está clase se pueden dar de alta las incertidumbres(errores dependiendo el punto de calibracion)
             * de los certifiados
             */
            InitializeComponent();
        }

        private void AddPuntos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Certificado' Puede moverla o quitarla según sea necesario.
            this.certificadoTableAdapter.Fill(this.documentacionDataSet.Certificado);
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Magnitudes' Puede moverla o quitarla según sea necesario.
            this.magnitudesTableAdapter.Fill(this.documentacionDataSet.Magnitudes);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (
               ft.IsValid(valor.Text)
                && ft.IsValid(incertidumbre.Text)
                && certificado.SelectedIndex != -1 && magnitud.SelectedIndex != -1
                && ft.MatchFloat(valor.Text) && ft.MatchFloat(incertidumbre.Text)
                )
            {
                string query = "insert into incertidumbrecert(valor,valorreal,idCertificado,IdMagnitud)" +
                    "values(" + valor.Text + "," + incertidumbre.Text + "," + certificado.SelectedValue + "," + magnitud.SelectedValue + ")";
                ft.SetSql(query);
            }
            else
            {
                MessageBox.Show("Verifique el formato de los campos.");
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            AddUso au = new AddUso("Magnitudes");
            au.ShowDialog(this);
        }
    }
}