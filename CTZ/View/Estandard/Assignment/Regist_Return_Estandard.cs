using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CTZ.View.Estandard.Assignment
{
    public partial class Regist_Return_Estandard : MaterialForm
    {
        private C_Estandard controllerEstandard;
        private C_ReturnOfEstandard controller;

        private List<string> estEstandards;
        public static Estandard_Assignment returnOfEstandard;
        public Regist_Return_Estandard()
        {
            InitializeComponent();
            estEstandards = new List<string>();
            returnOfEstandard = new Estandard_Assignment();
            returnOfEstandard.QualitySignature = "";
            returnOfEstandard.EngineerSignatureReturn = "";
        }
        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            controllerEstandard = new C_Estandard();
            if (controllerEstandard.check(TxtBox_Estandards.Text))
            {
                DataTable estandardInformation = controllerEstandard.selectEstandardByEST(TxtBox_Estandards.Text);
                if (estandardInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("PRESTADO") )
                {
                    controller = new C_ReturnOfEstandard();
                    DataTable informationLoan = controller.selectInformationOfMoreRecentLoan(TxtBox_Estandards.Text);
                    MessageBox.Show("Este estándar se le presto al Ingeniero " + informationLoan.Rows[0]["Ingeniero"].ToString());
                    try
                    {
                        returnOfEstandard.EngineerEmail = informationLoan.Rows[0]["Correo_Ingeniero"].ToString();
                        addEstandard(TxtBox_Estandards.Text);                      
                        TxtBox_Estandards.Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message.ToString());
                    }
                }
                else
                {
                    MessageBox.Show("El estándar " + TxtBox_Estandards.Text + " no ha se ha prestado, no se puede devolver ");
                }
            }
            else
            {
                MessageBox.Show("Estandard No existe");
            }
        }

        private void addEstandard(string estEstandard)
        {         
            if (estEstandards.Contains(estEstandard))
            {
                MessageBox.Show("El estándar " + estEstandard + " ya fue agregado, no puedes repetirlo");
            }
            else
            {
                ComboBox_Estandards.Items.Add(estEstandard);
                estEstandards.Add(estEstandard);
                MessageBox.Show("Se agrego el Estandard " + estEstandard);
            }
        }

        private void Btn_DeleteEstandard_Click(object sender, EventArgs e)
        {
            try
            {
                string estandar = ComboBox_Estandards.SelectedItem.ToString();
                int index = ComboBox_Estandards.FindString(estandar);
                ComboBox_Estandards.Items.RemoveAt(index);
                estEstandards.Remove(estandar);
                MessageBox.Show("Estándar " + estandar + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Estándar");
            }
        }

        private void Btn_Add_QualitySignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(returnOfEstandard, "QualityEstandard");
            signature.Show();
        }

        private void Btn_Add_EnginnerSignature_Click(object sender, EventArgs e)
        {
            RegistSignature signature = new RegistSignature(returnOfEstandard, "EnginnerReturnEstandard");
            signature.Show();
        }

        private void Btn_Add_Return_Click(object sender, EventArgs e)
        {
            if (returnOfEstandard.QualitySignature.Equals("") || returnOfEstandard.EngineerSignatureReturn.Equals(""))
            {
                MessageBox.Show("No puedes registrar la devolucion de estándar sin la firma del personal de " +
                    " calidad o sin la firma del Ingeniero ");
            }
            else
            {
                returnOfEstandard.ReturnObservations = TxtBox_ObservationReturn.Text;
                returnOfEstandard.DateOfReturn = TimePicker_Date_Return.Text;

                controller = new C_ReturnOfEstandard();
                controller.registerReturnOfEstandard(returnOfEstandard, estEstandards);
                controller.updateEstatusLoanEstandard("DISPONIBLE", estEstandards);
                sendNotification();

                MessageBox.Show("Registro de devolucion de estandard terminado");
                this.Close();
            }
        }

        private void sendNotification()
        {
            string[] qualityEmail = new string[3];
            qualityEmail[0] = returnOfEstandard.EngineerEmail;
            qualityEmail[1] = "omarflores@inolab.com";
            qualityEmail[2] = "calidad@inolab.com";

            string emailSubject = "Notificacion de devolucion de Estándar";
            string emailBody = emailBodyForQuality();
            Notification notification = new Notification();
            notification.sendMailNotification(qualityEmail, emailBody, emailSubject);
        }

        private string emailBodyForQuality()
        {
            DateForReport dates = new DateForReport();
            string body;
            body = "<!DOCTYPE html>\r\n<html >\r\n<head>\r\n    <meta charset=\"utf-8\" />\r\n    <title>Notificacion devolucion de Estándar</title>\r\n    <style>\r\n        a {\r\n            color: black;\r\n        }\r\n    \r\n        body {\r\n            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, Oxygen, Ubuntu, Cantarell, 'Open Sans', 'Helvetica Neue', sans-serif;\r\n            background: rgb(255,255,250);\r\n            margin: 10px;\r\n            background-repeat: no-repeat;\r\n            background-attachment: fixed;\r\n        }\r\n    </style>\r\n</head>\r\n<body>\r\n   <h2>Devolucion de Estándar </h2><br />\r\n    <table border=\"0\" cellpadding=\"8\">\r\n        <tr>\r\n            <td colspan=\"4\" >\r\n                <p  >\r\n                    <font COLOR=\"black\"  >Buen día  Ingeniero <a class=\"a\">{engineer}</a>  y responsable del area de  calidad se notifica que se ha devuelto el estándar con las siguientes caracteristicas: </font><br />                   \r\n                    <b><font COLOR=\"blue\" >Estándar:</font></b>                                     <b><a class=\"a\">{estandard}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Fecha De Devolucion:</font></b>                        <b><a class=\"a\">{dateOfReturn}</a> </b>  <br />\r\n                    <b><font COLOR=\"blue\" >Observaciones de Devolucion:</font></b>                  <b><a class=\"a\">{observations}</a></b>  <br />\r\n                </p><br />\r\n                <p>\r\n                    Este correo se envia automaticamente, favor de NO responder.<br />\r\n                    Saludos\r\n                </p>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n</body>\r\n</html>";

            string estandards = String.Join(", ", estEstandards);
            body = body.Replace("{estandard}", estandards);
            body = body.Replace("{dateOfReturn}", dates.convertToValidDateDatePicker(TimePicker_Date_Return.Text));
            body = body.Replace("{observations}", TxtBox_ObservationReturn.Text);
            body = body.Replace("{engineer}", "Omar Sotomayor");

            return body;
        }

       
    }
}
