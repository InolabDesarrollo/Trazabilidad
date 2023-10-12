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

namespace CTZ.Vista.Instruments
{
    public partial class Add_Delivery_Instrument : MaterialForm
    {
        C_Instrument_Assignments controler;
        Instrument_Assignments instrumentAssignments;
        DateForReport dateForReport;
        private  int idInstrument;
        private string equinoInstrument;

        public Add_Delivery_Instrument(int idInstrument, string equinoInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;
            controler = new C_Instrument_Assignments();
            instrumentAssignments = new Instrument_Assignments();
            dateForReport = new DateForReport();    
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
        }

        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            instrumentAssignments.idInstrument = idInstrument;
            instrumentAssignments.equinoInstrument = equinoInstrument;
            instrumentAssignments.dateDelivery = dateForReport.convertToValidDate(TimePicker_Date_Delivery.Text);

            instrumentAssignments.engineer =ListBoxEngineers.SelectedIndex.ToString();
            instrumentAssignments.numberEnterprise = TxtBox_Enterprise.Text;
            instrumentAssignments.observationDelivery = TxtBox_ObservationDelivery.Text;

            instrumentAssignments.approximateDateOfReturn = dateForReport.convertToValidDate(TimePicker_Date_Estimate_Return.Text);
            controler.registerDeliveryInstrument(instrumentAssignments);

            EngineerSignature signature = new EngineerSignature(idInstrument,equinoInstrument);
            signature.Show();
        }
    }
}
