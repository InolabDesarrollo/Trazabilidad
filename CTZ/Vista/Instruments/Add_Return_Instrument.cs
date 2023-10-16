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
    public partial class Add_Return_Instrument : MaterialForm
    {
        private  int idInstrument;
        private string equinoInstrument;
        Instrument_Assignments instrumentAssignments;
        C_Instrument_Assignments controler;
        public Add_Return_Instrument(int idInstrument, string equinoInstrument)
        {
            instrumentAssignments = new Instrument_Assignments();
            InitializeComponent();
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
            controler = new C_Instrument_Assignments();
            dataInstrument();
        }

        private void dataInstrument()
        {
            DataTable instrmentAssignmentInformation= controler.selectMoreRecentInformationInstrumenAssignment(idInstrument);
            Lbl_Estimate_Date_Return.Text = "Fecha de devolucion Registrada "+instrmentAssignmentInformation.Rows[0]["Fecha_Estimada_Devolucion"].ToString();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            instrumentAssignments.idInstrument = idInstrument;
            instrumentAssignments.equinoInstrument = equinoInstrument;  
            instrumentAssignments.dateOfReturn = DatePicker_DateOfReturn.Text;
            instrumentAssignments.observationsReturn=TxtBox_ObservationReturn.Text;
           
            controler.registerReturnInstrument(instrumentAssignments);
            RegistSignature signatureQualityAgent = new RegistSignature(idInstrument,equinoInstrument, "Quality");
            signatureQualityAgent.Show();
            this.Hide();
        }

    }
}
