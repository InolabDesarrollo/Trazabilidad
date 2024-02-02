using CTZ.Controlador;
using CTZ.Controler;
using CTZ.Controler.Estandard;
using CTZ.Controler.Instruments;
using CTZ.Vista.Responsabilitis;
using Grpc.Core;
using MaterialSkin.Controls;
using Microsoft.ReportingServices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class Add_Return_Instrument_ByGroup : MaterialForm
    {
        private C_Instruments instrumentsControler;
        public Instrument_Assignments instrumentAssignments;
        private DataTable instrumenAssignmentInformation;
        private C_Return_Of_Instrument controllerReturnOfInstrument;

        public static List<int> idInstruments;
        private static List<string> equinosInstruments;
        public DataTable instrumentInformation;
        private List<string> engineers;

        public Add_Return_Instrument_ByGroup()
        {
            InitializeComponent();
            idInstruments = new List<int>();
            equinosInstruments = new List<string>();
            instrumentAssignments = new Instrument_Assignments();
            engineers = new List<string>();

            instrumentAssignments.QualitySignature = "";
            instrumentAssignments.EngineerSignatureReturn = "";
            instrumenAssignmentInformation = new DataTable();          
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrument(TxtBox_Instrumenst.Text))
            {
                instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();

                if (statusAssignments.Equals("DISPONIBLE"))
                {
                    MessageBox.Show("Este Instrumento No ha sido asignado");
                }
                else
                {
                    controllerReturnOfInstrument = new C_Return_Of_Instrument();
                    DataTable instrumentAssignmentInformation = controllerReturnOfInstrument.selectMoreRecentInformationInstrumenAssignment(TxtBox_Instrumenst.Text);
                    MessageBox.Show("Este Instrumento se le presto al Ingeniero " + instrumentAssignmentInformation.Rows[0]["Ingeniero"].ToString());
                    
                    if (checkIfEstandardBelongsToTheEngineer(instrumentAssignmentInformation.Rows[0]["Ingeniero"].ToString()))
                    {
                        string equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                        int idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());
                        engineers.Add(instrumentAssignmentInformation.Rows[0]["Ingeniero"].ToString());
                        addInstrumentInformation(equinoInstrument, idInstrument);
                    }
                    else
                    {
                        MessageBox.Show("Ese Instrumento fue prestado a un Ingeniero diferente no lo puedes agregar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Instrumento No Existe");
            }
        }
        
        private bool checkIfEstandardBelongsToTheEngineer(string nameEnginner)
        {
            bool belongToEnginner = true;
            if (engineers.Count >= 1)
            {
                if (engineers.Contains(nameEnginner))
                {
                    belongToEnginner = true;
                }
                else
                {
                    belongToEnginner = false;
                }
            }         
            return belongToEnginner;
        }


        private void addInstrumentInformation(string equinoInstrument, int idInstrument)
        {
            if (equinosInstruments.Contains(equinoInstrument))
            {
                MessageBox.Show("El Instrumento " + equinoInstrument + "Ya fue agregado, no lo puedes repetir");
            }
            else
            {
                idInstruments.Add(idInstrument);
                equinosInstruments.Add(equinoInstrument);
                ComboBox_Instruments.Items.Add(equinoInstrument);
                MessageBox.Show("Se agrego Equino " + equinoInstrument);
                TxtBox_Instrumenst.Clear();
            }       
        }

        private void Btn_RegistQualitySignatur_Click(object sender, EventArgs e)
        {
            RegistSignature signatureQualityAgent = new RegistSignature(instrumentAssignments, "Quality");
            signatureQualityAgent.Show();
        }

        private void Btn_RegistEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(instrumentAssignments, "EngineerReturnInstrument");
            signature.Show();
        }

        private void Btn_Regist_ReturnOfInstruments_Click(object sender, EventArgs e)
        {
            controllerReturnOfInstrument = new C_Return_Of_Instrument();
            instrumenAssignmentInformation = controllerReturnOfInstrument.selectMoreRecentInformationInstrumenAssignment(equinosInstruments.First());

            string engineerMail = instrumenAssignmentInformation.Rows[0]["Correo_Ingeniero"].ToString();
            instrumentAssignments.DateOfReturn = DatePicker_DateOfReturn.Text;
            instrumentAssignments.ReturnObservations = TxtBox_ObservationReturn.Text;
            instrumentAssignments.EngineerEmail = engineerMail;

            if (instrumentAssignments.QualitySignature.Equals("") || 
                instrumentAssignments.EngineerSignatureReturn.Equals("") )
            {
                MessageBox.Show("No se puede registrar la devolucion de Instrumento sin la firma" +
                    " del agente de calidad o sin la firma del Ingeniero");
            }
            else
            {
                controllerReturnOfInstrument.registerReturnInstrument(instrumentAssignments, equinosInstruments);
                MessageBox.Show("Devolucion de Instrumento registrada correctamente");
                this.Hide();
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
