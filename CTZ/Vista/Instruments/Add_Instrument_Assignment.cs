using CTZ.Controlador;
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

namespace CTZ.Vista.Instruments
{
    public partial class Add_Instrument_Assignment : MaterialForm
    {
        C_Instruments instrumentControler;
        public Add_Instrument_Assignment()
        {
            instrumentControler = new C_Instruments();
            InitializeComponent();
        }

        private void Btn_Serch_Instrument_Click(object sender, EventArgs e)
        {
            if (instrumentControler.serchInstrumen(TxtBox_Instrument.Text))
            {
                DataTable instrumentInformation = instrumentControler.selectAllFromInstrument(TxtBox_Instrument.Text);
                if (instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString().Equals("DISPONIBLE"))
                {
                    MessageBox.Show("Instrumento Disponible");
                }
                else
                {
                    MessageBox.Show("El instrumento NO esta disponible, ha sido asiganado a un ingeniero");
                }
            }
            else
            {
                MessageBox.Show("Instrumento no existe");
            }
        }
    }
}
