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
using System.Windows.Controls;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class Add_Delivery_Instrument_ByGroup : MaterialForm
    {
        C_Instruments instrumentsControler;
        static List<int> idInstruments = new List<int>();
        static Dictionary<int, string> informationId_Equino;

        DataTable engineers;
        C_Instrument_Assignments controlerInstrumentAssignments;
        private  int idInstrument;
        private  string equinoInstrument;

        public Add_Delivery_Instrument_ByGroup()
        {
            InitializeComponent();
            informationId_Equino = new Dictionary<int, string>();
            fillMaterialComboBoxEngineers();
        }

        private void fillMaterialComboBoxEngineers()
        {
            C_Usuario userControler = new C_Usuario();
            engineers = userControler.getEngineers();
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string item = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                MaterialComboBox_Engineers.Items.Add(item);
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
                    informationId_Equino.Add(idInstrument, equinoInstrument);
                    idInstruments.Add(idInstrument);
                    ComboBox_Instruments.Items.Add(equinoInstrument);
                    MessageBox.Show("Se agrego Equino " + equinoInstrument);
                    TxtBox_Instrumenst.Clear();
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

        private void Btn_Regist_kit_Click(object sender, EventArgs e)
        {
            DateForReport dates = new DateForReport();
            string emailEngineer = serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());

            Instrument_Assignments instrument_Assignments = new Instrument_Assignments();
            instrument_Assignments.dateDelivery = dates.convertToValidDate(TimePicker_Date_Delivery.Text);
            instrument_Assignments.engineer = MaterialComboBox_Engineers.Text;
            instrument_Assignments.numberEnterprise = TxtBox_Enterprise.Text;
            instrument_Assignments.observationDelivery =TxtBox_ObservationDelivery.Text;
            instrument_Assignments.approximateDateOfReturn = dates.convertToValidDate(TimePicker_Date_Estimate_Return.Text);
            instrument_Assignments.nameEnterprise =TxtBox_NameEnterprise.Text;
            instrument_Assignments.mailEngineer = emailEngineer;
            instrument_Assignments.equinoInstrument = equinoInstrument;
            instrument_Assignments.idInstrument = idInstrument;

            controlerInstrumentAssignments = new C_Instrument_Assignments();
            controlerInstrumentAssignments.registerDeliveryInstrument(instrument_Assignments, informationId_Equino);

            RegistSignature signature = new RegistSignature(idInstruments, "EngineerByGroup",emailEngineer);
            signature.Show();
            this.Close();
        }

        private string serchEmailEngineer(string name)
        {
            string emailEngineer = "";
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string nameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                if (nameEngineer.Equals(name))
                {
                    emailEngineer = engineers.Rows[i]["Mail"].ToString();
                }
            }
            return emailEngineer;
        }


    }
}
