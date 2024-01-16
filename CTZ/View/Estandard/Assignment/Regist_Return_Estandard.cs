using CTZ.Controlador;
using CTZ.Controler.Estandard;
using CTZ.Modelo.Browser;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
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
        private C_Return_Of_Estandard controller;

        private List<string> standarList;
        private List<string> engineersNameList;    
        public static Estandard_Assignment returnOfEstandard;
        public Regist_Return_Estandard()
        {
            InitializeComponent();
            standarList = new List<string>();
            engineersNameList = new List<string>();
            returnOfEstandard = new Estandard_Assignment();
            returnOfEstandard.QualitySignature = "";
            returnOfEstandard.EngineerSignatureReturn = "";
        }
        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            controllerEstandard = new C_Estandard();
            if (controllerEstandard.checkIfEstandarExist(TxtBox_Estandards.Text))
            {
                bool standarWasBorrowed = controllerEstandard.checkIfStandarWasBorrowed(TxtBox_Estandards.Text);
                if (standarWasBorrowed)
                {
                    controller = new C_Return_Of_Estandard();
                    DataTable informationLoan = controller.selectInformationOfMoreRecentLoan(TxtBox_Estandards.Text);
                    MessageBox.Show("Este estándar se le presto al Ingeniero " + informationLoan.Rows[0]["Ingeniero"].ToString());
                    addStandardToReturnList(informationLoan, TxtBox_Estandards.Text);
                         
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
        private void addStandardToReturnList(DataTable informationLoan, string estEstandard)
        {
            string engineerName = informationLoan.Rows[0]["Ingeniero"].ToString();
            bool standarBelongsToEngineer = controller.checkIfStandarBelongsToEngineer(engineerName, engineersNameList);
            if (standarBelongsToEngineer)
            {
                try
                {
                    engineersNameList.Add(engineerName);
                    returnOfEstandard.EngineerEmail = informationLoan.Rows[0]["Correo_Ingeniero"].ToString();
                    addEstandard(estEstandard);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message.ToString());
                }
            }
            else
            {
                MessageBox.Show("Este estandard pertenece a otro Ingeniero");
            }
        }

        private void addEstandard(string Estandard)
        {         
            if (standarList.Contains(Estandard))
            {
                MessageBox.Show("El estándar " + Estandard + " ya fue agregado, no puedes repetirlo");
                TxtBox_Estandards.Clear();
            }
            else
            {
                ComboBox_Estandards.Items.Add(Estandard);
                standarList.Add(Estandard);
                MessageBox.Show("Se agrego el Estandard " + Estandard);
                TxtBox_Estandards.Clear();
            }
        }

        private void Btn_DeleteEstandard_Click(object sender, EventArgs e)
        {
            try
            {
                string standar = ComboBox_Estandards.SelectedItem.ToString();
                int index = ComboBox_Estandards.FindString(standar);
                ComboBox_Estandards.Items.RemoveAt(index);
                standarList.Remove(standar);
                MessageBox.Show("Estándar " + standar + " Eliminado");
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
            RegistSignature signature = new RegistSignature(returnOfEstandard, "EngineerReturnEstandard");
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

                controller = new C_Return_Of_Estandard();
                controller.registerReturnOfEstandard(returnOfEstandard, standarList);
                MessageBox.Show("Registro de devolucion de estandard terminado");
                this.Close();
            }
        }

    }
}
