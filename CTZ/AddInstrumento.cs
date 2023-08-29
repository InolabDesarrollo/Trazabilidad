using System;
using System.Windows.Forms;

namespace CTZ
{
    public partial class AddInstrumento : Form
    {
        private Functions ft = new Functions();

        public AddInstrumento()
        {
            /*
             * Esta clase está destinada para crear registros acerca de los instrumentos utilizados en la calibración de los
             * Instrumentos de inolab. está es información externa que dan los laboratorios.
            */
            InitializeComponent();
        }

        private void AddInstrumento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Procedimiento' Puede moverla o quitarla según sea necesario.
            this.procedimientoTableAdapter.Fill(this.documentacionDataSet.Procedimiento);
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.MarcaE' Puede moverla o quitarla según sea necesario.
            this.marcaETableAdapter.Fill(this.documentacionDataSet.MarcaE);
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.ModeloE' Puede moverla o quitarla según sea necesario.
            this.modeloETableAdapter.Fill(this.documentacionDataSet.ModeloE);
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Laboratorio' Puede moverla o quitarla según sea necesario.
            this.laboratorioTableAdapter.Fill(this.documentacionDataSet.Laboratorio);
            // TODO: esta línea de código carga datos en la tabla 'documentacionDataSet.Instrumento' Puede moverla o quitarla según sea necesario.
            this.instrumentoTableAdapter.Fill(this.documentacionDataSet.Instrumento);
        }

        private void save_Click(object sender, EventArgs e)
        {
            string instru = "null", model = "null", brand = "null", proce = "null";
            if (
                ft.IsValid(equipo.Text) && ft.IsValid(informe.Text)
                && ft.IsValid(serie.Text)
                )
            {
                if (instrumentoCB.Checked == true)
                {
                    instru = instrumento.SelectedValue.ToString();
                }

                if (modeloCB.Checked == true)
                {
                    model = modelo.SelectedValue.ToString();
                }
                if (marcaCB.Checked == true)
                {
                    brand = marca.SelectedValue.ToString();
                }
                if (procedimientoCB.Checked == true)
                {
                    proce = procedimiento.SelectedValue.ToString();
                }
                //NO SE EJECUTA EL PROCESO DE GUARDADO
                string queryString = "DECLARE @OutputTbl TABLE (ID INT)" +

                   "insert into Instrumento(Equipo, NoInforme,Id,Serie,incertidumbre,IdInstrumentoFK,vigencia) OUTPUT INSERTED.IdInstrumento INTO @OutputTbl(ID) values('" + equipo.Text + "', '" + informe.Text + "','" + id.Text + "','" + serie.Text + "','" + incertidumbre.Text + "'," + instru + ",'" + ft.DateToString(vigencia.Value) + "')" +

                   "declare @id as int; set @id = (select ID from @OutputTbl);" +
                   "Insert into DetalleInstrumento(IdLaboratorio, IdModeloE, IdMarcaE, IdProcedimiento, IdInstrumento)values(" + laboratorio.SelectedValue + ", " + model + ", " + brand + ", " + proce + ", @id);"
                  ;
                //ft.SetSql(queryString);
            }
        }

        private void instrumentoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (instrumentoCB.Checked)
            {
                instrumento.Enabled = true;
            }
            else
            {
                instrumento.Enabled = false;
            }
        }

        private void modeloCB_CheckedChanged(object sender, EventArgs e)
        {
            if (modeloCB.Checked)
            {
                modelo.Enabled = true;
                marca.Enabled = false;
                marcaCB.Checked = false;
            }
            else
            {
                modelo.Enabled = false;
                marca.Enabled = true;
                marcaCB.Checked = true;
            }
        }

        private void marcaCB_CheckedChanged(object sender, EventArgs e)
        {
            if (marcaCB.Checked)
            {
                marca.Enabled = true;
                modeloCB.Checked = false;
                modelo.Enabled = false;
            }
            else
            {
                marca.Enabled = false;
                modeloCB.Checked = true;
                modelo.Enabled = true;
            }
        }

        private void procedimientoCB_CheckedChanged(object sender, EventArgs e)
        {
            if (procedimientoCB.Checked)
            {
                procedimiento.Enabled = true;
            }
            else
            {
                procedimiento.Enabled = false;
            }
        }
    }
}