using CTZ.Controlador;
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
    public partial class Serch_Instruments_Assignments : MaterialForm 
    {
        C_Instruments controler;
        C_Instrument_Assignments controlerInstrumentAssignment;
        public Serch_Instruments_Assignments()
        {
            InitializeComponent();
            controler = new C_Instruments();
        }
        private void Btn_Serch_By_Instrument_Click(object sender, EventArgs e)
        {
            if(controler.serchInstrumen(TxtBox_Instrument.Text)){
                string equinoInstrument = TxtBox_Instrument.Text;
                See_Instrument_Assignment instrument_Assignment = new See_Instrument_Assignment(equinoInstrument);
                instrument_Assignment.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("El Equino del instrumento no existe");
                TxtBox_Instrument.Text = string.Empty;
            }       
        }

        private void Btn_Number_Enterprise_Click(object sender, EventArgs e)
        {
            controlerInstrumentAssignment = new C_Instrument_Assignments();
            if (controlerInstrumentAssignment.checkInformationWidthNumberEnterprise(TxtBox_Number_Enterprise.Text))
            {
                DataTable informationInstrumentAssignment = controlerInstrumentAssignment.selectAllByNumberEnterprise(TxtBox_Number_Enterprise.Text);
                See_Instrument_Assignment instrumentAssignment = new See_Instrument_Assignment(TxtBox_Number_Enterprise.Text,
                    informationInstrumentAssignment.Rows[0]["Nombre_Empresa"].ToString());
                instrumentAssignment.Show();
            }
            else
            {
                MessageBox.Show("El numero de empresa no existe");
                TxtBox_Number_Enterprise.Text = "";
            }
        }
    }
}
