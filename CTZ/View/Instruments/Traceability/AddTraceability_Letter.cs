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
        InternTraceability_Letter traceability;
        public AddTraceability_Letter(string numberOfCertificate)
        {
            InitializeComponent();
            Lbl_NumberOfCertificate.Text = "Numero de Certificado: "+numberOfCertificate;
            this.numberOfCertificate = numberOfCertificate;
            traceability = new InternTraceability_Letter(numberOfCertificate);

            if (traceability.verifiTraceabilityIdLetter())
            {
                Lbl_Warning.Text = "El certificado numero "+ numberOfCertificate + " Ya tiene carta de " +
                    " trazabilidad interna asignada, solo agrega la externa ";
                Btn_AddTraceabilityLetter.Visible = false;
            }
        }

        private void Btn_AddTraceabilityLetter_Click(object sender, EventArgs e)
        {
            traceability = new InternTraceability_Letter(numberOfCertificate, TxtBox_Title.Text,
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

        private void BtnAdd_ExternTraceability_Click(object sender, EventArgs e)
        {
            checkId(traceability.verifiTraceabilityIdLetter());
        }

        private void checkId(bool verifiIfThereIsTraceabilityLetter)
        {
            if (verifiIfThereIsTraceabilityLetter == true)
            {
                idTraceabilityLetter = Convert.ToInt32(traceability.selectColumn("ID", numberOfCertificate));
                AddExternTraceability_Letter externTraceability = new AddExternTraceability_Letter(idTraceabilityLetter, numberOfCertificate);
                externTraceability.Show();
            }
            else
            {
                MessageBox.Show("Debes agregar la carta de trazabilidad interna antes de la Externa");
            }
        }

    }
}
