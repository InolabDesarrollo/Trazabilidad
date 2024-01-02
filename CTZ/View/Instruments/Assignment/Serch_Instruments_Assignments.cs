using CTZ.Controlador;
using CTZ.Controler.Instruments.Assignments_;
using CTZ.Modelo.Browser;
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
        C_ConsultInstrument_Assignment controlerInstrumentAssignment;
        public Serch_Instruments_Assignments()
        {
            InitializeComponent();
            controler = new C_Instruments();
        }
        private void Btn_Serch_By_Instrument_Click(object sender, EventArgs e)
        {
            controler = new C_Instruments();
            if (controler.serchInstrumen(TxtBox_Instrument.Text)){
                string equinoInstrument = TxtBox_Instrument.Text;
                See_Instrument_Assignment instrument_Assignment = new See_Instrument_Assignment(equinoInstrument);
                instrument_Assignment.Show();
                TxtBox_Instrument.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El Equino del instrumento no existe");
                TxtBox_Instrument.Text = string.Empty;
            }       
        }

        private void Btn_Number_Enterprise_Click(object sender, EventArgs e)
        {
            controlerInstrumentAssignment = new C_ConsultInstrument_Assignment();
            if (controlerInstrumentAssignment.checkInformationWidthNumberEnterprise(TxtBox_Number_Enterprise.Text))
            {
                DataTable informationInstrumentAssignment = controlerInstrumentAssignment.selectAllByNumberEnterprise(TxtBox_Number_Enterprise.Text);
                See_Instrument_Assignment instrumentAssignment = new See_Instrument_Assignment(TxtBox_Number_Enterprise.Text,
                    informationInstrumentAssignment.Rows[0]["Nombre_Empresa"].ToString());
                instrumentAssignment.Show();
                TxtBox_Instrument.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("El numero de empresa no existe");
                TxtBox_Number_Enterprise.Text = "";
            }
        }

        private void Btn_Engineer_Click(object sender, EventArgs e)
        {
            UserRepository userRepository = new UserRepository();
            C_User userControler = new C_User(userRepository);
            if (userControler.checkIfExistEngineer(TxtBox_Engineer.Text))
            {
                controlerInstrumentAssignment = new C_ConsultInstrument_Assignment();
                if (controlerInstrumentAssignment.checkIfEngineerHasAssignment(TxtBox_Engineer.Text))
                {
                    controlerInstrumentAssignment = new C_ConsultInstrument_Assignment();
                    DataTable instrumenAssignmentInformation = controlerInstrumentAssignment.selectAllByEngineer(TxtBox_Engineer.Text);
                    See_Instrument_Assignment instrument_Assignment = new See_Instrument_Assignment(instrumenAssignmentInformation);
                    instrument_Assignment.Show();
                    TxtBox_Instrument.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("El ingeniero no tiene Asignaciones");
                    TxtBox_Instrument.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("El ingeniero no Existe");
                TxtBox_Instrument.Text = string.Empty;
            }   
        }
    }
}
