﻿using CTZ.Controlador;
using CTZ.Modelo.Browser;
using CTZ.Vista.Responsabilitis;
using MaterialSkin;
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

namespace CTZ.Vista.Instruments
{
    public partial class Add_Delivery_Instrument : MaterialForm
    {
        C_Instrument_Assignments controler;
        C_Usuario userControler;
        Instrument_Assignments instrumentAssignments;
        DateForReport dateForReport;
        private  int idInstrument;
        private string equinoInstrument;

        public Add_Delivery_Instrument(int idInstrument, string equinoInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;       

            instrumentAssignments = new Instrument_Assignments();
            dateForReport = new DateForReport();    
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;

            fillMaterialComboBoxEngineers();
        }
        
        private void fillMaterialComboBoxEngineers()
        {
            userControler= new C_Usuario();
            DataTable engineers = userControler.getEngineers();
            for (int i =0;  i <engineers.Rows.Count; i++ )
            {
                string item = engineers.Rows[i]["Nombre"].ToString() +" "+ engineers.Rows[i]["Apellidos"].ToString();
                MaterialComboBox_Engineers.Items.Add(item);
            }  
        }
        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            controler = new C_Instrument_Assignments();

            instrumentAssignments.idInstrument = idInstrument;
            instrumentAssignments.equinoInstrument = equinoInstrument;
            instrumentAssignments.dateDelivery = dateForReport.convertToValidDate(TimePicker_Date_Delivery.Text);
            
            instrumentAssignments.engineer = MaterialComboBox_Engineers.SelectedItem.ToString();
            instrumentAssignments.numberEnterprise = TxtBox_Enterprise.Text;
            instrumentAssignments.observationDelivery = TxtBox_ObservationDelivery.Text;

            instrumentAssignments.approximateDateOfReturn = dateForReport.convertToValidDate(TimePicker_Date_Estimate_Return.Text);
            bool updateData= controler.registerDeliveryInstrument(instrumentAssignments);
            updateStatusInstrument(updateData);

            RegistSignature signature = new RegistSignature(idInstrument,equinoInstrument, "Engineer");
            signature.Show();
            this.Close();
        }

        private void updateStatusInstrument(bool update)
        {
            if (update)
            {
                controler.updateStatusInstrumentAssignment(idInstrument, "OCUPADO");
            }
        }
    }
}
