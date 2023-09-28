using CTZ.Controlador;
using CTZ.Vista.Traceability;
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

namespace CTZ.Vista.Certificates
{
    public partial class SerchCertificate : MaterialForm
    {
        C_Certificate controler;
        public SerchCertificate()
        {
            controler = new C_Certificate();
            InitializeComponent();
            
        }

        private void Btn_Serch_Certificate_Click(object sender, EventArgs e)
        {
            if (serchNumberOfCertificate(TxtBox_Certificate.Text))
            {
                AddTraceability_Letter traceability = new AddTraceability_Letter(TxtBox_Certificate.Text);
                traceability.Show();
            }
            else
            {
                MessageBox.Show("No existe ese numero de certificado");
            }
        }

        public bool serchNumberOfCertificate(string numberOfCertificate)
        {
            return controler.checkIfNumberExist(numberOfCertificate);
        }
    }
}
