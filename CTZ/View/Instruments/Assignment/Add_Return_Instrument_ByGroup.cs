using CTZ.Controlador;
using CTZ.Controler.Instruments;
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
    public partial class Add_Return_Instrument_ByGroup : MaterialForm
    {
        C_Instruments instrumentsControler;
        C_Instrument_Assignments instrumentAssignmentsControler;
        Instrument_Assignments instrumentAssignments;


        string equinoInstrument;
        int idInstrument;
        static List<int> idInstruments;
        DataTable instrumentInformation;

        public Add_Return_Instrument_ByGroup()
        {
            InitializeComponent();
            idInstruments = new List<int>();
            instrumentAssignments = new Instrument_Assignments();
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrumen(TxtBox_Instrumenst.Text))
            {
                instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();

                idInstrument= Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());
                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();

                if (statusAssignments.Equals("DISPONIBLE"))
                {
                    MessageBox.Show("Este Instrumento No ha sido asignado");
                }
                else
                {
                    idInstruments.Add(idInstrument);
                    ComboBox_Instruments.Items.Add(equinoInstrument);
                    MessageBox.Show("Se agrego Equino " + equinoInstrument);
                    TxtBox_Instrumenst.Clear();
                }
            }
            else
            {
                MessageBox.Show("Instrumento No Existe");
            }
        }

        private void Btn_Regist_ReturnOfInstruments_Click(object sender, EventArgs e)
        {
            instrumentAssignmentsControler = new C_Instrument_Assignments();
            DataTable instrumenAssignmentInformation = instrumentAssignmentsControler.selectMoreRecentInformationInstrumenAssignment(Convert.ToInt32(idInstruments[0].ToString()));
            string engineerMail = instrumenAssignmentInformation.Rows[0]["Correo_Ingeniero"].ToString();

            instrumentAssignments.idInstrument = idInstrument;
            instrumentAssignments.equinoInstrument = equinoInstrument;
            instrumentAssignments.dateOfReturn = DatePicker_DateOfReturn.Text;
            instrumentAssignments.observationsReturn = TxtBox_ObservationReturn.Text;
            C_ReturnOfInstrument returnOfInstrument = new C_ReturnOfInstrument();

            returnOfInstrument.registerReturnInstrument(instrumentAssignments, idInstruments);
            updateStatusInstruments();

            RegistSignature signatureQualityAgent = new RegistSignature(idInstruments,  "QualityByGroup", engineerMail);
            signatureQualityAgent.Show();
            this.Hide();
        }

        private void updateStatusInstruments()
        {
            foreach (int id in idInstruments)
            {
                instrumentAssignmentsControler.updateStatusInstrumentAssignment(id,"DISPONIBLE");
            }
        }

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            try
            {
                string equino = ComboBox_Instruments.SelectedItem.ToString();
                int index = ComboBox_Instruments.FindString(equino);
                ComboBox_Instruments.Items.RemoveAt(index);
                MessageBox.Show("Equino " + equino + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Equino");
            }
        }
    }
}
