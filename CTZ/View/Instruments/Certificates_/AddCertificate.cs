using CTZ.Controlador;
using CTZ.Controler.Instruments.Certificates_;
using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
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

namespace CTZ.Vista.Responsabilitis
{
    public partial class AddCertificate : MaterialForm
    {
        private readonly string instrument;
        Certificate certificate;
        DateForReport dateForReport;
        public AddCertificate()
        {
            InitializeComponent(); 
        }
        public AddCertificate(string instrument)
        {
            InitializeComponent();
            this.instrument = instrument;
            dateForReport = new DateForReport();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TxtBox_Number.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debes llenar el numero de certificado");
            }
            else
            {
                string dateCalibration = dateForReport.convertToValidDate(DatePicker_Calibration.Text);
                string dateNextCalibration = dateForReport.convertToValidDate(DatePicker_NextCalibration.Text);
                certificate = new Certificate();

                certificate.instrument = this.instrument;
                certificate.dateCalibration = dateCalibration;
                certificate.nextCalibration = dateNextCalibration;
                certificate.link = TxtBox_Link.Text;
                certificate.number = TxtBox_Number.Text;
                certificate.use = ComboBox_Use.SelectedItem.ToString();
                certificate.laboratory = TxtBox_Laboratory.Text;
                certificate.status = "Activo";
                
                C_Add_Certificate controller = new C_Add_Certificate();

                if (controller.checkIfNumberExist(certificate.number))
                {
                    MessageBox.Show("El numero de Certificado ya existe");
                }
                else
                {
                    controller.add(certificate);
                    MessageBox.Show("Nuevo certificado creado y agregado a Instrumento");
                    Close();
                }
            }        
        }
    }
}
