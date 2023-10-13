using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Instruments
{
    public partial class RegistSignature : Form
    {
        float pointX = 0;
        float pointY = 0;

        float lastX = 0;
        float lastY = 0;
        private readonly int idInstrument;
        private readonly string equinoInstrument;
        private readonly string typeOfSignature;
        C_Instrument_Assignments controler;
        public RegistSignature(int idInstrument, string equinoInstrument, string typeOfSignature)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
            this.typeOfSignature = typeOfSignature;
            controler = new C_Instrument_Assignments();
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
            Image signature = new Bitmap(Pnl_Signature.Width, Pnl_Signature.Height);
            var graphic = Graphics.FromImage(signature);
            var rectangle = Pnl_Signature.RectangleToScreen(Pnl_Signature.ClientRectangle);

            graphic.CopyFromScreen(rectangle.Location, Point.Empty, Pnl_Signature.Size);
            signature.Save("Firma.jpg", ImageFormat.Jpeg);

            if(typeOfSignature.Equals("Engineer"))
            {
                registEngineerSignature(signature);

            }else if (typeOfSignature.Equals("Quality"))
            {
                registQualitySignature(signature);
            }                      
        }
        
        private void registEngineerSignature(Image engineerSignature)
        {
            controler.updateSignatureEngineer(idInstrument, engineerSignature);
            MessageBox.Show("Firma de ingeniero agregada correctamente");
            this.Close();
        }

        private void registQualitySignature(Image qualitySignature)
        {
            controler.updateSignatureQuality(idInstrument, qualitySignature);
            MessageBox.Show("Firma de calidad agregada correctamente");
            this.Close();
        }
    }
}
