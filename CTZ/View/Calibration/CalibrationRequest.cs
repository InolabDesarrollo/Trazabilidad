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
using System.Windows.Forms;

namespace CTZ.View.Calibration
{
    public partial class CalibrationRequest : MaterialForm
    {
        C_Instruments instrumentsControler;
        private string equinoInstrument;
        private int idInstrument;
        private static List<int> idInstruments;

        public CalibrationRequest()
        {
            InitializeComponent();
            instrumentsControler = new C_Instruments();
            idInstruments = new List<int>();
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrumentsControler = new C_Instruments();
            if (instrumentsControler.serchInstrumen(TxtBox_Instrumenst.Text))
            {
                DataTable instrumentInformation = instrumentsControler.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());
                
                addEquino();
            }
            else
            {
                MessageBox.Show("Instrumento No existe");
                TxtBox_Instrumenst.Clear();
            }
        }

        private void addEquino()
        {
            ComboBox_Instruments.Items.Add(equinoInstrument);
            idInstruments.Add(idInstrument);
            MessageBox.Show("Se agrego Equino " + equinoInstrument);
            TxtBox_Instrumenst.Clear();
        }
    }
}
