using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Instruments;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.View.Estandard.Assignment
{
    public partial class Add_Delivery_Estandard : MaterialForm
    {
        private C_Estandard controler;
        private static Dictionary<int, string> informationEstandards;
        List<string> estandardList;
        private C_User usuarioControler;
        private DataTable engineers;
        public static Estandard_Assignment assignment;
        public Add_Delivery_Estandard()
        {
            InitializeComponent();
            informationEstandards = new Dictionary<int, string>();
            UserRepository userRepository = new UserRepository();
            usuarioControler = new C_User(userRepository);
            assignment = new Estandard_Assignment();
            assignment.EngineerSignature = "";

            estandardList = new List<string>();
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

        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            controler = new C_Estandard();
            if (controler.check(TxtBox_Estandards.Text))
            {
                DataTable estandardInformation = controler.selectEstandardByEST(TxtBox_Estandards.Text);
                if (estandardInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("PRESTADO"))
                {
                    MessageBox.Show("El estandard "+ TxtBox_Estandards.Text + " se encuentra prestado");
                }
                else
                {
                    try
                    {
                        int idEstandard = Convert.ToInt32(estandardInformation.Rows[0]["Id"].ToString());
                        addEstandard(idEstandard, TxtBox_Estandards.Text);
                        TxtBox_Estandards.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message.ToString());
                    }
                }  
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandard(int idEstandard, string estEstandard)
        {
            if (estandardList.Contains(estEstandard))
            {
                MessageBox.Show("El estandard "+estEstandard+" ya fue agregado, no puedes repetirlo");   
            }
            else
            {
                informationEstandards.Add(idEstandard, estEstandard);
                estandardList.Add(estEstandard);
                ComboBox_Estandards.Items.Add(estEstandard);
                MessageBox.Show("Se agrego el Estandard " + estEstandard);
            }
        }

        private void Btn_RegistEnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(assignment, "EngineerEstandard");
            signature.Show();
        }

        private void Btn_Add_Delivery_Click(object sender, EventArgs e)
        {
            if (assignment.EngineerSignature.Equals(""))
            {
                MessageBox.Show("No puedes prestar un estándar sin registrar la firma del Ingeniero");
            }
            else
            {
                assignment.DateDelivery = TimePicker_Date_Delivery.Text;
                assignment.Engineer = MaterialComboBox_Engineers.Text;
                assignment.NumberEnterprise = TxtBox_Enterprise.Text;
                assignment.NameEnterprise = TxtBox_NameEnterprise.Text;
                assignment.DeliveryObservations = TxtBox_ObservationDelivery.Text;
                assignment.EstimateDateReturn = TimePicker_Date_Estimate_Return.Text;

                UserRepository userRepository = new UserRepository();
                usuarioControler = new C_User(userRepository);
                string emailEngineer = usuarioControler.serchEmailEngineer(MaterialComboBox_Engineers.SelectedItem.ToString());
                assignment.EngineerEmail = emailEngineer;

                C_DeliveryOfEstandard controler = new C_DeliveryOfEstandard();
                controler.registerDeliveryEstandard(assignment, estandardList);
                controler.updateEstatusLoanEstandard("PRESTADO", estandardList);

                sendNotification();
                MessageBox.Show("Se creo la asignacion para los estandares ");
                this.Close();
            }  
        }
        private void sendNotification()
        {
            string emailEngineer = assignment.EngineerEmail;            
            string bodyMail = bodyEmailEngineer();
            Notification notification = new Notification();
            notification.sendMailNotification(emailEngineer, bodyMail, "Prestamo de estándar");
        }

        private string bodyEmailEngineer()
        {
            string idOfEstandards = string.Join(", ", estandardList);
            CertificateEstandard certificate = new CertificateEstandard();
            string linkCertificate = certificate.getCertificates(informationEstandards);

            string body = "<!DOCTYPE html>\r\n\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n</head>\r\n<body>\r\n   <h2>Entrega de Estándar </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        " +
                "<tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"purple\"  >Buen día  Ingeniero  " + assignment.Engineer.ToString() + " y responsable del area de  calidad se notifica que se ha entregado el Estándar con las caracteristicas</font><br />                   \r\n                    <b><font COLOR=\"blue\" >Est:</font></b>                                     <b>" + idOfEstandards + " </b> <br />\r\n                    " +
                "<b><font COLOR=\"blue\" >Fecha de entrega:</font></b>                        <b>" + assignment.DateDelivery + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Fecha aproximada de devolucion:</font></b>            <b>" + assignment.EstimateDateReturn + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Empresa:</font></b>                                   <b>" + assignment.NameEnterprise + " </b> <br />\r\n                    <b><font COLOR=\"blue\" >Folio Empresa:</font></b>                             <b>" + assignment.NumberEnterprise + " </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de entrega:</font></b>                  <b>" + assignment.DeliveryObservations + "</b>  <br />\r\n\r\n                    <b>" +
                "<font COLOR=\"blue\" >Link del certificado:</font></b>                  <b>" + linkCertificate + "</b>  <br />\r\n\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            return body;
        }

        private void Btn_DeleteEstandard_Click(object sender, EventArgs e)
        {
            deleteEstandardFromComboBox(ComboBox_Estandards);
        }

        public void deleteEstandardFromComboBox(MaterialComboBox comboBox)
        {
            try
            {
                string estandar = comboBox.SelectedItem.ToString();
                int index = comboBox.FindString(estandar);
                comboBox.Items.RemoveAt(index);
                MessageBox.Show("Estándar " + estandar + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Estándar");
            }
        }
    }
}
