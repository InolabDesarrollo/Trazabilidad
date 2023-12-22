using CTZ.Controler.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;

namespace CTZ.View.Estandard.Assignment
{
    public partial class RegistSignature : Form
    {
        private float pointX = 0;
        private float pointY = 0;
        private float lastX = 0;
        private float lastY = 0;
        Image imageSignature;
        public string signatureBase64;
        private readonly Estandard_Assignment assignment;
        private readonly Dictionary<int, string> estandardInformation;
        private readonly string typeOfSignature;

        public RegistSignature(Estandard_Assignment assignment,Dictionary<int,string> estandardInformation)
        {
            InitializeComponent();
            this.assignment = assignment;
            this.estandardInformation = estandardInformation;
        }

        public RegistSignature(Estandard_Assignment assignment, string typeOfSignature)
        {
            InitializeComponent();
            this.assignment = assignment;
            this.typeOfSignature = typeOfSignature;
        }

        private void Pnl_Signature_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = Pnl_Signature.CreateGraphics();
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
                Pnl_Signature_Paint(this, null);
            }
        }

        private void Btn_Save_Signature_Click(object sender, EventArgs e)
        {
            CTZ.View.Responsabilitis.Signature signature = new Responsabilitis.Signature();
            switch (typeOfSignature)
            {
                case "Enginner":
                    assignment.EngineerSignature = signature.createStringOfSignature(Pnl_Signature);
                    break;
            }
            MessageBox.Show("La firma se registro correctamente");

            /*
            C_DeliveryOfEstandard controler = new C_DeliveryOfEstandard();
            controler.registerDeliveryEstandard(assignment, estandardInformation);
            controler.updateEstatusLoanEstandard("PRESTADO", estandardInformation);

            sendNotification();
            MessageBox.Show("Se creo la asignacion para los estandares ");
            this.Close(); */
            this.Close();
        }
 
    }
}
