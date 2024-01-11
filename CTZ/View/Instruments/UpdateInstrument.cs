using CTZ.Controler.Instruments.Certificates_;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.Vista
{
    public partial class UpdateInstrument : MaterialForm
    {
        private  string id;
        Responsabilitis.Instruments instrument;
        DataTable certificates;
        public UpdateInstrument(string id)
        {
            InitializeComponent();
            this.id = id;
            instrument = new Responsabilitis.Instruments();
            getInformationFromInstrument(id);
        }

        private void getInformationFromInstrument(string id)
        {
            DataTable informationIntrument = instrument.selectAllFromInstrument(id);
            TxtBox_Instrument.Text= informationIntrument.Rows[0]["INSTRUMENTO"].ToString();
            TxtBox_Brand.Text = informationIntrument.Rows[0]["MARCA"].ToString();
            TxtBox_Model.Text= informationIntrument.Rows[0]["MODELO"].ToString();
            TxtBox_NumSerie.Text = informationIntrument.Rows[0]["N#S#"].ToString();
            TxtBox_Ubication.Text = informationIntrument.Rows[0]["UBICACIÓN"].ToString();
            TxtBox_Observation.Text = informationIntrument.Rows[0]["OBSERVACIÓN"].ToString() ;

            checkStatus(informationIntrument.Rows[0]["ESTATUS"].ToString());
            getCertificatesFromInstrument(id);
            Lbl_Id_Instrument.Text = informationIntrument.Rows[0]["ID_Instrumentos"].ToString();
        }

        private void checkStatus(string status)
        {
            if (status.Equals("ACTIVO"))
            {
                ComboBox_Status.SelectedIndex = 0;
            }
            if(status.Equals("FUERA DE USO"))
            {
                ComboBox_Status.SelectedIndex= 1;
            }
            if (status.Equals("CALIBRANDO"))
            {
                ComboBox_Status.SelectedIndex = 2;
            }
            if (status.Equals("PENDIENTE"))
            {
                ComboBox_Status.SelectedIndex = 3;
            }
        }

        private void getCertificatesFromInstrument(string instrument)
        {
            C_Query_Certificate controller = new C_Query_Certificate();
            DataTable numberOfCertificates = controller.getAllActivesCertificate(instrument);
            for (int i=0; i< numberOfCertificates.Rows.Count; i++)
            {
                ComboBox_Certificate.Items.
                    Add(numberOfCertificates.Rows[i]["Numero"].ToString());
            }
        }

        private void Btn_Update_Instrument_Click(object sender, EventArgs e)
        {
            Responsabilitis.Instruments instruments = new Responsabilitis.Instruments();
            instrument.id = id;
            instrument.instrument = TxtBox_Instrument.Text;
            instrument.brand = TxtBox_Brand.Text;
            instrument.model = TxtBox_Model.Text;
            instrument.numberOfSerie = TxtBox_NumSerie.Text;
            instrument.ubication = TxtBox_Ubication.Text;
            instrument.observation = TxtBox_Observation.Text;
            instrument.status = ComboBox_Status.SelectedItem.ToString();
            instrument.magnitude =TxtBox_Magnitude.Text;
            instrument.range = TxtBox_Range.Text;
            instrument.accessories = TxtBox_Accessories.Text;

            instrument.updateInstrument();
            clearMenu();
            MessageBox.Show("Instrumento Actualizado");
        }

        private void clearMenu()
        {
            TxtBox_Instrument.Clear();
            TxtBox_Brand.Clear();
            TxtBox_Model.Clear();
            TxtBox_NumSerie.Clear();
            TxtBox_Observation.Clear();
        }

        private void BtnNew_Certificate_Click(object sender, EventArgs e)
        {
            AddCertificate certificate = new AddCertificate(id);
            certificate.Show();
        }

        private void BtnDelete_Certificate_Click(object sender, EventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.delete(ComboBox_Certificate.SelectedItem.ToString());
        }

        private void BtnUnassign_Certificate_Click(object sender, EventArgs e)
        {
            C_Query_Certificate controller = new C_Query_Certificate();
            controller.updateStatusCertificate(ComboBox_Certificate.SelectedItem.ToString(), id);
            MessageBox.Show("El certificado " + ComboBox_Certificate.SelectedItem.ToString() + "Se quito del instrumento " + id);
        }
    }
}
