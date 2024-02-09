using CTZ.Controler.Instruments;
using MaterialSkin.Controls;
using Model;
using Model.Trazabilidad.Instruments;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Instruments
{
    public partial class Add_Accessory : MaterialForm
    {
        private readonly string instrument;
        private C_Add_Accessory controller;
        public Add_Accessory(string instrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = instrument;
            controller = new C_Add_Accessory();

            this.instrument = instrument;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Accesorios_Instrumento accessory = new Accesorios_Instrumento();

            accessory.Id_Instrumento = instrument;
            accessory.Instrumento = TxtBox_Description.Text;
            accessory.Marca = TxtBox_Brand.Text;
            accessory.Modelo = TxtBox_Model.Text;
            accessory.NS = TxtBox_Ns.Text;
            accessory.Ubicacion = ComboBox_Ubication.SelectedItem.ToString();
            accessory.Magnitud = TxtBox_Magnitud.Text;
            accessory.Uso = TxtBox_USE.Text;
            accessory.Observacion = TxtBox_Observation.Text;
            accessory.Id_Accesorio = TxtBox_Id_Accessory.Text;
            
            controller.controll(accessory);
            MessageBox.Show("Accesorio "+ TxtBox_Id_Accessory.Text+" agregado correctamente");
            this.Close();
        }
    }
}
