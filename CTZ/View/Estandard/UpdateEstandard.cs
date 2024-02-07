using CTZ.Controler.Estandard;
using MaterialSkin.Controls;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Estandard
{
    public partial class UpdateEstandard : MaterialForm
    {
        private readonly string estEstandard;
        C_Estandard controler;
        private DataTable estandardInformation;
        private int idStandar;
        public UpdateEstandard(string estEstandard)
        {
            InitializeComponent();
            this.estEstandard = estEstandard;
            controler = new C_Estandard();
            estandardInformation = controler.selectEstandardByEST(estEstandard);
            Lbl_Est.Text = estEstandard;
            getInformationOfEstandard();
        }

        private void getInformationOfEstandard()
        {
            TxtBox_Estandard_Description.Text = estandardInformation.Rows[0]["Estandar"].ToString();
            TxtBox_Use.Text = estandardInformation.Rows[0]["Uso"].ToString();
            TxtBox_Brand.Text = estandardInformation.Rows[0]["Marca"].ToString();
            TxtBox_Presentation.Text = estandardInformation.Rows[0]["Presentacion"].ToString();
            TxtBox_Ubication.Text = estandardInformation.Rows[0]["Ubicacion"].ToString();
            TxtBox_Estatus.Text = estandardInformation.Rows[0]["Estatus"].ToString();
            TxtBox_Inventory.Text = estandardInformation.Rows[0]["Inventario"].ToString();

            idStandar = Convert.ToInt32(estandardInformation.Rows[0]["ID"].ToString());
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {   
            Estandares standar = new Estandares();

            standar.Id = this.idStandar;
            standar.Id_Estandares = estEstandard;
            standar.Estandar = TxtBox_Estandard_Description.Text;
            standar.Uso = TxtBox_Use.Text;
            standar.Marca = TxtBox_Brand.Text;
            standar.Presentacion = TxtBox_Presentation.Text;
            standar.Ubicacion = TxtBox_Ubication.Text;
            standar.Estatus = TxtBox_Estatus.Text;
            standar.Inventario = TxtBox_Inventory.Text;
            standar.FechaDeFabricacion = TimePicker_FabricationDate.Text;
            standar.FechaDeCaducidad = TimePicker_ExpirationDate.Text;
            
            C_UpdateEstandard controler = new C_UpdateEstandard();
            controler.update(standar);
            MessageBox.Show("Se actualizo el instrumento " + estEstandard);
            this.Close();
        }

    }
}
