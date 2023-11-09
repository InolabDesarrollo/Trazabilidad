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
    public partial class DeleteInstrument : MaterialForm
    {
        Responsabilitis.Instruments instrument;
        public DeleteInstrument()
        {
            InitializeComponent();
            instrument = new Responsabilitis.Instruments();
        }

        private void BtnDelete_Instrument_Click(object sender, EventArgs e)
        {
            instrument.deleteInstrument(TxtBox_Id.Text);
            TxtBox_Id.Clear();
            MessageBox.Show("Instrumento con eliminado");
        }
    }
}
