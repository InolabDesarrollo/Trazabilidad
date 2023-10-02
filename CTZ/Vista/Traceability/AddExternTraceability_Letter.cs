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
using System.Windows.Forms;

namespace CTZ.Vista.Traceability
{
    public partial class AddExternTraceability_Letter : MaterialForm
    {
        private int idInternTraceabilityLetter;
        private string numberOfCertificate;
        C_ExternTraceabilityRepository controler;

        public AddExternTraceability_Letter(int idInternTraceabilityLetter, string numberOfCertificate)
        {
            InitializeComponent();
            this.idInternTraceabilityLetter = idInternTraceabilityLetter;
            this.numberOfCertificate = numberOfCertificate;
            Lbl_NumberOfCertificate.Text = "Certificado numero "+numberOfCertificate;
            controler = new C_ExternTraceabilityRepository();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ExternalTraceability_Letter traceability = new ExternalTraceability_Letter(idInternTraceabilityLetter,TxtBox_Calibrate.Text,
                TxtBox_Title.Text,TxtBox_Organization.Text,TxtBox_Enterprise.Text,TxtBox_Equipment.Text,TxtBox_Brand.Text,
                TxtBox_Model.Text,TxtBox_NumberOfSerie.Text,TxtBox_Uncertainty.Text);

             controler.add(traceability);
        }
    }
}
