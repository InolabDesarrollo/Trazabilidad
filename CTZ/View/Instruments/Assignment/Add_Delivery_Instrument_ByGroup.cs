using CTZ.Controlador;
using CTZ.Model.Browser.Interfaces;
using CTZ.Modelo.Browser;
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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class Add_Delivery_Instrument_ByGroup : MaterialForm
    {
        C_Instruments instrumentsControler;
        C_Instrument_Assignments instrumentAssignmentsControler;
        C_Usuario usuarioControler;
        private static List<string> instrumentsWithCertificate;

        private static Dictionary<int, string> informationId_Equino;
        DataTable engineers;
        private int idInstrument;
        private string equinoInstrument;

        public Add_Delivery_Instrument_ByGroup()
        {
            InitializeComponent();
            informationId_Equino = new Dictionary<int, string>();
            instrumentsWithCertificate = new List<string>();
            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_Usuario(userRepository);

            engineers = usuarioControler.getEngineers();
            fillMaterialComboBoxEngineers();
        }

        private void fillMaterialComboBoxEngineers()
        {
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string completeNameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                MaterialComboBox_Engineers.Items.Add(completeNameEngineer);
            }
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrumen(TxtBox_Instrumenst.Text))
            {
                DataTable instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();

                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());

                if (statusAssignments.Equals("DISPONIBLE"))
                {
                    addEquinoToKit();
                }
                else
                {
                    MessageBox.Show("Este Instrumento esta Ocupado");
                }
            }
            else
            {
                MessageBox.Show("Instrumento No Existe");
            }
        }

        private void addEquinoToKit()
        {
            RelationCertificateInstrument relation = new RelationCertificateInstrument();
            string dateOfCalibrationForInstrument = relation.getDateForNextCalibration(equinoInstrument);
            if (dateOfCalibrationForInstrument.Equals("Sin fecha"))
            {
                addEquino();
            }
            else
            {   
                if(relation.calculateDaysForNextCalibration(equinoInstrument) < 10)
                {
                    MessageBox.Show("Faltan menos de 10 dias para la calibracion de este instrumento "+ equinoInstrument+" \n" +
                        "NO puede ser asignado");
                }
                else
                {
                    addEquino();
                }
            }
        }

        private void addEquino()
        {
            informationId_Equino.Add(idInstrument, equinoInstrument);
            ComboBox_Instruments.Items.Add(equinoInstrument);
            checkIfEngineerNeedCertificate();
            MessageBox.Show("Se agrego Equino " + equinoInstrument);
            TxtBox_Instrumenst.Clear();
        }

        private void checkIfEngineerNeedCertificate()
        {
            DialogResult resultado = MessageBox.Show("¿Quieres que se envie certificado de este instrumento?", "Pregunta", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado== DialogResult.Yes)
            {
                instrumentsWithCertificate.Add(equinoInstrument);
            }                   
        }

        private void Btn_Regist_kit_Click(object sender, EventArgs e)
        {
            if (MaterialComboBox_Engineers.SelectedItem ==null)
            {
                MessageBox.Show("No haz seleccionado al Ingeniero");
            }
            else
            {
                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_Usuario(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
                Instrument_Assignments instrument_Assignments = new Instrument_Assignments();
                instrument_Assignments.dateDelivery = TimePicker_Date_Delivery.Text;
                instrument_Assignments.engineer = MaterialComboBox_Engineers.Text;
                instrument_Assignments.numberEnterprise = TxtBox_Enterprise.Text;
                instrument_Assignments.observationDelivery = TxtBox_ObservationDelivery.Text;
                instrument_Assignments.approximateDateOfReturn = TimePicker_Date_Estimate_Return.Text;
                instrument_Assignments.nameEnterprise = TxtBox_NameEnterprise.Text;
                instrument_Assignments.mailEngineer = emailEngineer;
                instrument_Assignments.equinoInstrument = equinoInstrument;
                instrument_Assignments.idInstrument = idInstrument;

                instrumentAssignmentsControler = new C_Instrument_Assignments();
                instrumentAssignmentsControler.registerDeliveryInstrument(instrument_Assignments, informationId_Equino);
                updateStatusInstruments();

                RegistSignature signature = new RegistSignature(informationId_Equino, "EngineerByGroup", emailEngineer,instrumentsWithCertificate);
                
                signature.Show();
                this.Close();
            }
        }

        private void updateStatusInstruments()
        {
            foreach (KeyValuePair<int, string> id_Equino in informationId_Equino)
            {
                instrumentAssignmentsControler.updateStatusInstrumentAssignment(id_Equino.Key, "OCUPADO");
            }
        }

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            CTZ.Vista.Responsabilitis.Instruments instrument = new CTZ.Vista.Responsabilitis.Instruments();
            instrument.deleteEquinoFromComboBox(ComboBox_Instruments);
        }
    }
}