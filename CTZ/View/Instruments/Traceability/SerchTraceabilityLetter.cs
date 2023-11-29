using CTZ.Controlador;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CTZ.Vista.Traceability
{
    public partial class SerchTraceabilityLetter : MaterialForm
    {
        C_Certificate controler;
        C_TraceabilityRepository controlerTraceability;
        public SerchTraceabilityLetter()
        {
            InitializeComponent();
            controler = new C_Certificate();
            controlerTraceability = new C_TraceabilityRepository();
        }

        private void Btn_Serch_Click(object sender, EventArgs e)
        {
            if (controler.checkIfNumberExist(Txt_Box_Certificates.Text))
            {
                string idTraceabilityLetter = controlerTraceability.selectColumn("ID", Txt_Box_Certificates.Text);
                ReportTraceabilityLetter report = new ReportTraceabilityLetter(idTraceabilityLetter, Txt_Box_Certificates.Text);
                report.Show();
            }
            else
            {
                MessageBox.Show("No existe ese numero de certificado");
            }
        }
    }
}
