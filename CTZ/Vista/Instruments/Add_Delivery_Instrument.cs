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
    public partial class Add_Delivery_Instrument : MaterialForm
    {
        public Add_Delivery_Instrument(string idInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = idInstrument;
        }

        private void Btn_Enginner_Sign_Click(object sender, EventArgs e)
        {
            EngineerSignature signature = new EngineerSignature();
            signature.Show();
        }
    }
}
