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
                string statusAssignments = instrumentInformation.Rows[0]["ESTATUS_ASIGNACION"].ToString();
                int idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());

                registerAssignmentOfInstrument(statusAssignments,idInstrument);
            }
            else
            {
                MessageBox.Show("Instrumento no existe");
            }
        }

        private void registerAssignmentOfInstrument(string statusAssignments, int idInstrument)
        {
            if (statusAssignments.Equals("DISPONIBLE"))
            {
                Add_Delivery_Instrument deliveryInstrument = new Add_Delivery_Instrument(idInstrument, TxtBox_Instrument.Text);
                deliveryInstrument.Show();
                this.Close();
            }
            else if (statusAssignments.Equals("OCUPADO"))
            {
                Add_Return_Instrument returnInstrument = new Add_Return_Instrument(idInstrument, TxtBox_Instrument.Text);
                returnInstrument.Show();
                this.Close();
            }
        }
    }
}
