using CTZ.Controler.Estandard;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Estandard
{
    public partial class AddCertificate : MaterialForm
    {
        private readonly string estEstandard;
        private int idEstandard;
        public AddCertificate(string estEstandard)
        {
            InitializeComponent();
            this.estEstandard = estEstandard;
            C_Estandard controler = new C_Estandard();  
            DataTable estandardInformation= controler.selectEstandardByEST(estEstandard);
            idEstandard = Convert.ToInt16( estandardInformation.Rows[0]["Id"].ToString());
            Lbl_Estandard.Text = estEstandard;
        }

        public AddCertificate(string estEstandard, int idEstandard)
        {
            this.idEstandard = idEstandard;
            Lbl_Estandard.Text = estEstandard;
        }

        private void Btn_AddCertificate_Click(object sender, EventArgs e)
        {
            CertificateEstandard certificate = new CertificateEstandard();
            certificate.ExpirationDate = DatePicker_ExpirationDate.Text;
            certificate.Lot= TxtBox_Lot.Text;
            certificate.NumberOfPart= TxtBox_NumberOfPart.Text;
            certificate.RegisterDate= DateTime.Today.ToString();
            certificate.Link=TxtBox_Link.Text;
            certificate.idEstandard= idEstandard;
            certificate.Status = "Vigente";
            

            C_Certificate controler = new C_Certificate();
            controler.updateStatusCertificates(idEstandard);

            controler.createCertificate(certificate);
            MessageBox.Show("Se creo Certificado");
            this.Close();
        }

    }
}
