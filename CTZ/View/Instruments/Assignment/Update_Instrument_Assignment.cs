using CTZ.Controler.Instruments.Assignments_;
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
    public partial class Update_Instrument_Assignment : MaterialForm
    {
        private int idSql;
        Instrument_Assignments instrumentAssignment;
        C_UpdateInstrument_Assignment controller;
        public Update_Instrument_Assignment(int idSql,string equino)
        {
            InitializeComponent();
            instrumentAssignment = new Instrument_Assignments();
            this.idSql = idSql;
            Lbl_Instrument.Text = equino;
            controller = new C_UpdateInstrument_Assignment();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            instrumentAssignment.idInstrument = idSql;
            instrumentAssignment.NumberEnterprise = TxtBox_NumberEnterprise.Text;
            instrumentAssignment.NameEnterprise = TxtBox_NameEnterprise.Text;
            instrumentAssignment.DeliveryObservations = TxtBox_Observation_Delivery.Text;
            instrumentAssignment.ReturnObservations =TxtBox_ObservationReturn.Text;

            controller.updateInstrumentAssignment(instrumentAssignment);
            clearButtons();
        }

        private void clearButtons()
        {
            TxtBox_NameEnterprise.Clear();
            TxtBox_NumberEnterprise.Clear();
            TxtBox_Observation_Delivery.Clear();
            TxtBox_ObservationReturn.Clear();
        }

    }
}
