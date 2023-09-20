﻿using CTZ.Vista.Responsabilitis;
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
        private  string idSql;
        Instruments instrument;
        DataTable certificates;

        public UpdateInstrument(string id)
        {
            InitializeComponent();
            this.id = id;
            instrument = new Instruments();
            getInformationFromInstrument(id);
        }

        public UpdateInstrument(string idInstrument, string idSql)
        {
            InitializeComponent();
            this.id = idInstrument;
            this.idSql = idSql;
            instrument = new Instruments();
            getInformationFromInstrument(idInstrument);
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
            getCertificatesFromInstrument(Convert.ToInt32(idSql));
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

        private void getCertificatesFromInstrument(int idSqlInstrument)
        {
            RelationCertificateInstrument relation = new RelationCertificateInstrument(idSqlInstrument);
            certificates =  relation.getAllCertificatesForInstrument();
            Certificate certificate = new Certificate();

            for (int i =0; i< certificates.Rows.Count; i++)
            {
                int idCertificate = Convert.ToInt32(certificates.Rows[i]["Id_Certificado"].ToString());
                ComboBox_Certificate.Items.Add(certificate.getCelValue(idCertificate, "Numero"));
            }
        }

        private void Btn_Update_Instrument_Click(object sender, EventArgs e)
        {
            Instruments instruments = new Instruments();
            instrument.id = id;
            instrument.instrument = TxtBox_Instrument.Text;
            instrument.brand = TxtBox_Brand.Text;
            instrument.model = TxtBox_Model.Text;
            instrument.numberOfSerie = TxtBox_NumSerie.Text;
            instrument.ubication = TxtBox_Ubication.Text;
            instrument.observation = TxtBox_Observation.Text;
            instrument.status = ComboBox_Status.SelectedItem.ToString();

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
            AddCertificate certificate = new AddCertificate(idSql);
            certificate.Show();
        }

        private void BtnDelete_Certificate_Click(object sender, EventArgs e)
        {
            Certificate certificate = new Certificate();
            certificate.delete(ComboBox_Certificate.SelectedItem.ToString());
        }

        private void BtnUnassign_Certificate_Click(object sender, EventArgs e)
        {          
            Certificate certificate = new Certificate();
            string numberCerCertificate="";
            for (int i=0; i< certificates.Rows.Count; i++)
            {
                int idCertificate =Convert.ToInt32(certificates.Rows[i]["Id_Certificado"].ToString());
                numberCerCertificate= certificate.getCelValue(idCertificate, "Numero");
                if (numberCerCertificate == ComboBox_Certificate.SelectedItem.ToString())
                {
                    RelationCertificateInstrument relation = new RelationCertificateInstrument(Convert.ToInt32(idSql), idCertificate);
                    relation.deleteRelation();
                }
            }
            MessageBox.Show("Certificado con Numero " + numberCerCertificate);
        }
    }
}
