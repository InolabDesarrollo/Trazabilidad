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

namespace CTZ.Vista
{
    public partial class DeleteInstrument : MaterialForm
    {
        C_Instruments controller;
        public DeleteInstrument()
        {
            InitializeComponent();
            controller = new C_Instruments();
        }

        private void BtnDelete_Instrument_Click(object sender, EventArgs e)
        {
            string message = controller.deleteInstrument(TxtBox_Id.Text);
            MessageBox.Show(message);
            TxtBox_Id.Clear();
        }
    }
}
