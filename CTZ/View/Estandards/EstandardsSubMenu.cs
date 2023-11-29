using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Estandards
{
    public partial class EstandardsSubMenu : MaterialForm
    {
        public EstandardsSubMenu()
        {
            InitializeComponent();
        }

        private void EstandardsSubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Instrumentos_Certificado' Puede moverla o quitarla según sea necesario.
            this.instrumentos_CertificadoTableAdapter.Fill(this.trazabilidadTestDataSet3.Instrumentos_Certificado);

        }
    }
}
