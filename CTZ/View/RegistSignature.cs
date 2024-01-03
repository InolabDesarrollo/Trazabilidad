using CTZ.Controlador;
using CTZ.Controler;
using CTZ.View.Estandard;
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

        public  Instrument_Assignments instrumentAssignments;
        private readonly Estandard_Assignment estandardAssignments;
        private readonly string typeOfSignature;
        
        public RegistSignature(Instrument_Assignments instrumentAssignments, string typeOfSignature)
        {
            InitializeComponent();
            this.instrumentAssignments = instrumentAssignments;
            this.typeOfSignature = typeOfSignature;
        }

        public RegistSignature(Estandard_Assignment estandardAssignments, string typeOfSignature)
        {
            InitializeComponent();
            this.estandardAssignments = estandardAssignments;
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
            switch (typeOfSignature)
            {
                case "Engineer":
                    instrumentAssignments.engineerSignature = signatureBase64;
                    break;
                case "Quality":
                    instrumentAssignments.qualitySignature = signatureBase64;
                    break;
                case "EnginnerEstandard":
                    estandardAssignments.EngineerSignature = signatureBase64;   
                    break;
                case "QualityEstandard":
                    estandardAssignments.QualitySignature = signatureBase64;
                    break;
                case "EnginnerReturnEstandard":
                    estandardAssignments.EngineerSignatureReturn = signatureBase64;
                    break;
            }
                
            System.Windows.MessageBox.Show("Firma agregada correctamente");
            this.Close();
        }
  
    }
}
