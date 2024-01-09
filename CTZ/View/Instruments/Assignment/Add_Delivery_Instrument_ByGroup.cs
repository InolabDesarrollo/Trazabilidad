using CTZ.Controlador;
using CTZ.Controler.Instruments.Assignments_;
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
        private C_Instruments instrumentsControler;
        private C_RegistDeliveryInstrument instrumentAssignmentsControler;
        private C_User usuarioControler;

        public static Instrument_Assignments instrumentAssignments;
        private static List<string> instrumentsWithCertificate;
        private static Dictionary<int, string> informationId_Equino;
        private DataTable engineers;
        private int idInstrument;
        private string equinoInstrument;

        public Add_Delivery_Instrument_ByGroup()
        {
            InitializeComponent();
            informationId_Equino = new Dictionary<int, string>();
            instrumentsWithCertificate = new List<string>();

            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_User(userRepository);
            engineers = usuarioControler.getEngineers();

            instrumentAssignments = new Instrument_Assignments();
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
                bool instrumentIsAvailable = instrumentsControler.checkIfInstrumentIsAvailable(TxtBox_Instrumenst.Text);

                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());

                if (instrumentIsAvailable)
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

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            CTZ.Vista.Responsabilitis.Instruments instrument = new CTZ.Vista.Responsabilitis.Instruments();
            instrument.deleteEquinoFromComboBox(ComboBox_Instruments);
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
                if (relation.calculateDaysForNextCalibration(equinoInstrument) < 10)
                {
                    MessageBox.Show("Faltan menos de 10 dias para la calibracion de este instrumento " + equinoInstrument + " \n" +
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

            if (resultado == DialogResult.Yes)
            {
                instrumentsWithCertificate.Add(equinoInstrument);
            }
        }

        private void Btn_AddEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(instrumentAssignments, "Engineer");
            signature.Show();
        }

        private void Btn_Regist_kit_Click(object sender, EventArgs e)
        {
            if (MaterialComboBox_Engineers.SelectedItem == null)
            {
                MessageBox.Show("No haz seleccionado al Ingeniero");
            }
            else
            {
                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_User(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());

                instrumentAssignments.DateDelivery = TimePicker_Date_Delivery.Text;
                instrumentAssignments.Engineer = MaterialComboBox_Engineers.Text;
                instrumentAssignments.NumberEnterprise = TxtBox_Enterprise.Text;
                instrumentAssignments.DeliveryObservations = TxtBox_ObservationDelivery.Text;
                instrumentAssignments.EstimateDateReturn = TimePicker_Date_Estimate_Return.Text;
                instrumentAssignments.NameEnterprise = TxtBox_NameEnterprise.Text;
                instrumentAssignments.EngineerEmail = emailEngineer;
                instrumentAssignments.equinoInstrument = equinoInstrument;
                instrumentAssignments.idInstrument = idInstrument;

                instrumentAssignmentsControler = new C_RegistDeliveryInstrument();
                instrumentAssignmentsControler.registerDeliveryInstrument(instrumentAssignments, informationId_Equino);
                updateStatusInstruments();
                sendEngineerNotification(emailEngineer);
                this.Close(); 
            }
        }

        private void updateStatusInstruments()
        {
            foreach (KeyValuePair<int, string> id_Equino in informationId_Equino)
            {
                instrumentAssignmentsControler.updateStatusInstrumentAssignment(id_Equino.Value, "OCUPADO");
            }
        }

        private void sendEngineerNotification(string emailEngineer)
        {
            string emailBody = emailBodyForEngineer();
            string emailSubject = "Notificacion entrega de Instrumento";

            Notification notification = new Notification();
            notification.sendMailNotification(emailEngineer, emailBody, emailSubject);
        }

        private string emailBodyForEngineer()
        {
            string nameEngineer = instrumentAssignments.Engineer;
            string enterprise = instrumentAssignments.NameEnterprise;
            string numberEnterprise = instrumentAssignments.NumberEnterprise;
            string deliveryDate = instrumentAssignments.DateDelivery;
            string equinoInstrument = serchEquinosForEmail();
            string aproximateDateOfReturn = instrumentAssignments.EstimateDateReturn;
            string deliveryObservation = instrumentAssignments.DeliveryObservations;

            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();  
            string certificateLink = serchCertificates(instrumentsWithCertificate);

            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\\\"utf-8\"\\  />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Instrumento </h2><br />\r\n    <table border=\\\"0\"\\ cellpadding=\\\"8\"\\ >\r\n        <tr>\r\n            <td colspan= \\\"4\"\\ >\r\n                <p>\r\n                    <font COLOR= " + "'purple'" + " >Buen día estimado Ingeniero                         " + nameEngineer + "</font>  <br />\r\n                    Se le informa que se le han   asignado los Instrumentos  con las siguientes caracteristicas:  <br />\r\n <b><font COLOR= " + "'blue'" + "> Fecha De Entrega:</font></b>                          <b>" + deliveryDate.Substring(0, 9) + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Empresa:</font></b>                                   <b>" + enterprise + " </b> <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Folio Empresa:</font></b>                             <b>" + numberEnterprise + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + "> Fecha registrada de devolucion:</font></b>            <b>" + aproximateDateOfReturn.Substring(0, 9) + " </b>  <br />\r\n                    <b><font COLOR= " + "'blue'" + " > Observaciones de Entrega:</font></b>                  <b>" + deliveryObservation + " </b>  <br />   <b> <font COLOR=\"blue\" >Link de certificados:</font></b>                  <b>" + certificateLink + "</b>  <br />                \r\n</p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";
            body = body.Replace("{engineer}", nameEngineer);
            body = body.Replace("{equinos}", equinoInstrument);
            body = body.Replace("{deliveryDate}", instrumentAssignments.DateDelivery);
            body = body.Replace("{enterprise}", instrumentAssignments.NameEnterprise);
            body = body.Replace("{numberEnterprise}", instrumentAssignments.NumberEnterprise);
            body = body.Replace("{deliveryObservation}", instrumentAssignments.DeliveryObservations);
            body = body.Replace("{certificateLink}", certificateLink);
           
            return body;
        }

        private string serchEquinosForEmail()
        {
            List<string> equinosList = informationId_Equino.Values.ToList();
            string equinos = String.Join(", ", equinosList);
            return equinos;
        }

        private string serchCertificates(List<string> instrumentsWithCertificates)
        {
            C_View_Instrument_Certificate controler = new C_View_Instrument_Certificate();
            string certificates = "";
            foreach (string equino in instrumentsWithCertificates)
            {
                DataTable instrumentInformation = controler.getAllInstrumentCertificate(equino);
                certificates = string.Join(",", instrumentInformation.Rows[0]["Link"].ToString());
            }
            return certificates;
        }

    }
}