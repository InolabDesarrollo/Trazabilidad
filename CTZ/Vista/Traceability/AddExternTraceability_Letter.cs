using CTZ.Controlador;
using CTZ.Vista.Responsabilitis;
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
            checkNumberOfExternTraceability_Letters(idInternTraceabilityLetter);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            ExternalTraceability_Letter traceability = new ExternalTraceability_Letter(idInternTraceabilityLetter,TxtBox_Calibrate.Text,
                TxtBox_Title.Text,TxtBox_Organization.Text,TxtBox_Enterprise.Text,TxtBox_Equipment.Text,TxtBox_Brand.Text,
                TxtBox_Model.Text,TxtBox_NumberOfSerie.Text,TxtBox_Uncertainty.Text);

             controler.add(traceability);
             clearPanel();
        }

        private void clearPanel()
        {
            TxtBox_Title.Clear();
            TxtBox_Model.Clear();
            TxtBox_Organization.Clear();
            TxtBox_NumberOfSerie.Clear();
            TxtBox_Enterprise.Clear();
            TxtBox_Calibrate.Clear();
            TxtBox_Brand.Clear();
            TxtBox_Uncertainty.Clear();
            TxtBox_Equipment.Clear();

            MessageBox.Show("Carta de trazabilidad externa agregada correctamente");
        }

        private void checkNumberOfExternTraceability_Letters(int idInternTraceabilityLetter)
        {
            DataTable externalTrazabilityLetters= controler.selectExternalTrazabilityLetters(idInternTraceabilityLetter);
            Lbl_NumberOfLetters.Text = "Cartas de Trazabilidad externas actuales: "+idInternTraceabilityLetter;
            if (externalTrazabilityLetters.Rows.Count > 4)
            {
                Btn_Add.Visible = false;
                Lbl_NumberOfLetters.Text = "Numeros de Cartas de Trazabilidad externas actuales revasado";
            }
        }

        private void Btn_See_Report_Click(object sender, EventArgs e)
        {
            ReportTraceabilityLetter report = new ReportTraceabilityLetter("Carta_Trazabilidad",Convert.ToString(idInternTraceabilityLetter),numberOfCertificate);
            report.Show();
        }
    }
}
