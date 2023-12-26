using CTZ.Controlador;
using CTZ.Controler;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class RegistSignature : Form
    {
        private float pointX = 0;
        private float pointY = 0;
        private float lastX = 0;
        private float lastY = 0;

        private readonly int idInstrument;
        private readonly string equinoInstrument;
        private readonly Dictionary<int, string> informationId_Equino;
        private readonly List<int> idInstruments;
        private readonly Instrument_Assignments instrumentAssignments;
        private readonly string typeOfSignature;
        private  string emailEngineer;
        private readonly List<string> instrumentsWithCertificates;
        Image imageSignature;
        

        C_Instrument_Assignments controler;
        private DataTable instrumentAssignmentsInformation;
        public RegistSignature(int idInstrument, string equinoInstrument, string typeOfSignature,string emailEngineer)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;

            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(idInstrument);
        }

        public RegistSignature(Dictionary<int, string> informationId_Equino,string typeOfSignature, string emailEngineer, List<string> instrumentsWithCertificates)
        {
            InitializeComponent();
            this.informationId_Equino = informationId_Equino;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;
            this.instrumentsWithCertificates = instrumentsWithCertificates;

            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(informationId_Equino.Keys.First());
        }

        public RegistSignature(List<int> idInstruments, string typeOfSignature, string emailEngineer)
        {
            InitializeComponent();
            this.idInstruments = idInstruments;
            this.typeOfSignature = typeOfSignature;
            this.emailEngineer = emailEngineer;

            controler = new C_Instrument_Assignments();
            instrumentAssignmentsInformation = controler.selectMoreRecentInformationInstrumenAssignment(Convert.ToInt32(idInstruments[0].ToString()));
        }

        public RegistSignature(Instrument_Assignments instrumentAssignments, string typeOfSignature)
        {
            InitializeComponent();
            this.instrumentAssignments = instrumentAssignments;
            this.typeOfSignature = typeOfSignature;
        }

        private void Pnl_Signature_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics= Pnl_Signature.CreateGraphics();
            graphics.DrawLine(Pens.Black, pointX, pointY, lastX, lastY);
            lastX = pointX;
            lastY = pointY;
        }
        private void Pnl_Signature_MouseDown(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
        }

        private void Pnl_Signature_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pointX = e.X;
                pointY = e.Y;
                Pnl_Signature_Paint(this,null);
            }
        }

        private void Btn_Save_Signature_Click(object sender, EventArgs e)
        {

            Signature signature = new Signature();
            string signatureBase64= signature.createStringOfSignature(Pnl_Signature);

            instrumentAssignments.engineerSignature = signatureBase64;
            System.Windows.MessageBox.Show("Firma agregada correctamente");
            this.Close();
        }
  

    }
}
