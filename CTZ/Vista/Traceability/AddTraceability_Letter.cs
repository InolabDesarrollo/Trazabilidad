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
    public partial class AddTraceability_Letter : MaterialForm
    {
        private string numberOfCertificate;
        int idTraceabilityLetter;
        public AddTraceability_Letter(string numberOfCertificate)
        {
            InitializeComponent();
            Lbl_NumberOfCertificate.Text = "Numero de Certificado: "+numberOfCertificate;
            this.numberOfCertificate = numberOfCertificate;
        }

        private void Btn_AddTraceabilityLetter_Click(object sender, EventArgs e)
        {
            Traceability_Letter traceability = new Traceability_Letter(numberOfCertificate, TxtBox_Title.Text,
                "", TxtBox_Enterprise.Text, TxtBox_Team.Text, TxtBox_Brand.Text, TxtBox_Model.Text, TxtBox_NumberOfSerie.Text
                ,TxtBox_Uncertainty.Text);

            traceability.add();
            idTraceabilityLetter = Convert.ToInt32(traceability.selectColumn("ID", numberOfCertificate));
            traceability.verifiId(idTraceabilityLetter, numberOfCertificate);
            clean();
        }
        
        private void clean()
        {
            TxtBox_Title.Clear();
            TxtBox_Enterprise.Clear();
            TxtBox_Team.Clear();
            TxtBox_Brand.Clear();
            TxtBox_Model.Clear();
            TxtBox_NumberOfSerie.Clear();
            TxtBox_Uncertainty.Clear();
        }

 
    }
}
