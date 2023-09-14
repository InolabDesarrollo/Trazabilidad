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
        private  string idSqlInstrument;
        Certificate certificate;
        RelationCertificateInstrument relation;
        public AddCertificate()
        {
            InitializeComponent(); 
        }
        public AddCertificate(string idSqlInstrument)
        {
            InitializeComponent();
            this.idSqlInstrument = idSqlInstrument;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string dateCalibration = convertToValidDate(DatePicker_Calibration.Text);
            string dateNextCalibration = convertToValidDate(DatePicker_NextCalibration.Text);

            certificate = new Certificate(dateCalibration, dateNextCalibration,
                TxtBox_Link.Text, TxtBox_Number.Text,ComboBox_Use.SelectedItem.ToString(),TxtBox_Laboratory.Text);
            certificate.add();

            createAsosiation();
            MessageBox.Show("Nuevo certificado creado y agregado a Instrumento");
            Close();
        }

        private string convertToValidDate(string date)
        {
            DateTime validDate = Convert.ToDateTime(date);
            return validDate.ToString("yyyy/MM/dd");
        }

        private void createAsosiation()
        {
            int idSqlCertificate = certificate.getLastCertificateRegistered();
            relation = new RelationCertificateInstrument(Convert.ToInt32(idSqlInstrument), idSqlCertificate);
            relation.create();
        }

    }
}
