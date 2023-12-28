using CTZ.Controler.Estandard;
using CTZ.Vista.Instruments;
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
        private List<string> estEstandards;
        public static Estandard_Assignment returnOfEstandard;
        public Regist_Return_Estandard()
        {
            InitializeComponent();
            estEstandards = new List<string>();
            returnOfEstandard = new Estandard_Assignment();
            returnOfEstandard.QualitySignature = "";
        }
        private void Btn_AddEstandard_Click(object sender, EventArgs e)
        {
            controllerEstandard = new C_Estandard();
            if (controllerEstandard.check(TxtBox_Estandards.Text))
            {
                DataTable estandardInformation = controllerEstandard.selectEstandardByEST(TxtBox_Estandards.Text);
                if (estandardInformation.Rows[0]["Estatus_Prestamo"].ToString().Equals("PRESTADO") )
                {
                    try
                    {
                        addEstandard();
                        int idEstandard = Convert.ToInt32(estandardInformation.Rows[0]["Id"].ToString());                        
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

        private void addEstandard()
        {
            
            if (estEstandards.Contains(TxtBox_Estandards.Text))
            {
                MessageBox.Show("El estándar " + TxtBox_Estandards.Text + " ya fue agregado, no puedes repetirlo");
            }
            else
            {
                ComboBox_Estandards.Items.Add(TxtBox_Estandards.Text);
                estEstandards.Add(TxtBox_Estandards.Text);
                MessageBox.Show("Se agrego el Estandard " + TxtBox_Estandards.Text);
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

        private void Btn_Add_Return_Click(object sender, EventArgs e)
        {
            if (returnOfEstandard.QualitySignature.Equals(""))
            {
                MessageBox.Show("No puedes registrar la devolucion de estándar sin la firma del personal de " +
                    " calidad ");
            }
            else
            {
                returnOfEstandard.ReturnObservations = TxtBox_ObservationReturn.Text;
                returnOfEstandard.DateOfReturn = TimePicker_Date_Return.Text;

                C_ReturnOfEstandard controller = new C_ReturnOfEstandard();
                controller.registerReturnOfEstandard(returnOfEstandard, estEstandards);
                controller.updateEstatusLoanEstandard("DISPONIBLE", estEstandards);

                MessageBox.Show("Registro de devolucion de estandard terminado");
            }
            
        }
        
    }
}
