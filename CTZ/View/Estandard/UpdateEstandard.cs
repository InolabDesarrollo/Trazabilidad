using CTZ.Controler.Estandard;
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

namespace CTZ.View.Estandard
{
    public partial class UpdateEstandard : MaterialForm
    {
        private readonly string estEstandard;
        C_Estandard controler;
        private DataTable estandardInformation;

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
            TxtBox_Number.Text = estandardInformation.Rows[0]["NoLote"].ToString();
            TxtBox_Quantity.Text = estandardInformation.Rows[0]["Cantidad"].ToString();
            TxtBox_Ubication.Text = estandardInformation.Rows[0]["Ubicacion"].ToString();
            TxtBox_Estatus.Text = estandardInformation.Rows[0]["Estatus"].ToString();
            TxtBox_Inventory.Text = estandardInformation.Rows[0]["Inventario"].ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {   
            Responsabilitis.Estandard estandard = new Responsabilitis.Estandard();
            estandard.EstandardDescription = TxtBox_Estandard_Description.Text;
            estandard.Use = TxtBox_Use.Text;
            estandard.Brand = TxtBox_Brand.Text;
            estandard.Presentation = TxtBox_Presentation.Text;
            estandard.Number = TxtBox_Number.Text;
            estandard.Quantity = TxtBox_Quantity.Text;
            estandard.Ubication = TxtBox_Ubication.Text;
            estandard.Estatus= TxtBox_Estatus.Text;
            estandard.Inventory = TxtBox_Inventory.Text;

            estandard.FabricationDate = TimePicker_FabricationDate.Text;
            estandard.ExpirationDate = TimePicker_ExpirationDate.Text;
            estandard.EstEstandard = estEstandard;
            

            C_UpdateEstandard controler = new C_UpdateEstandard();
            controler.update(estandard);
            MessageBox.Show("Se actualizo el instrumento " + estEstandard);
            this.Close();
        }

    }
}
