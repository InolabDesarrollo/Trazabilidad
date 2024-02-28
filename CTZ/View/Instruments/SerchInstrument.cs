using CTZ.Controler.Instruments;
using CTZ.View.Instruments;
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
        private readonly string typeOfSerch;
        C_SerchInstrument controller;
        public SerchInstrument()
        {
            InitializeComponent();
            controller = new C_SerchInstrument();
            typeOfSerch = "Update";
        }

        public SerchInstrument(string typeOfSerch)
        {
            InitializeComponent();
            controller = new C_SerchInstrument();
            this.typeOfSerch = typeOfSerch;
        }

        private void Btn_Serch_Instrument_Click(object sender, EventArgs e)
        {
            if (controller.checkIfInstrumentExist(TxtBox_Instrument.Text))
            {
                switch(typeOfSerch)
                {
                    case "Update":
                        UpdateInstrument updateInstrument = new UpdateInstrument(TxtBox_Instrument.Text);
                        updateInstrument.Show();                      
                        break;
                    case "Accessory":
                        Add_Accessory add = new Add_Accessory(TxtBox_Instrument.Text);
                        add.Show();
                        break;
                }
                this.Close();   
            }
        }
    }
}
