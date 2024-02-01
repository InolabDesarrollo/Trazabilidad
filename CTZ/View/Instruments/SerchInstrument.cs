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

namespace CTZ.Vista
{
    public partial class SerchInstrument : MaterialForm
    {
        Responsabilitis.Instrument instrument;
        public SerchInstrument()
        {
            InitializeComponent();
            instrument = new Responsabilitis.Instrument();
        }

        private void Btn_Serch_Instrument_Click(object sender, EventArgs e)
        {
            if (instrument.serchInstrument(TxtBox_Instrument.Text))
            {
                UpdateInstrument updateInstrument = new UpdateInstrument(TxtBox_Instrument.Text); 
                updateInstrument.Show();
                this.Close();
            }
        }
    }
}
