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
    public partial class EngineerSignature : Form
    {
        float pointX = 0;
        float pointY = 0;

        float lastX = 0;
        float lastY = 0;
        private readonly int idInstrument;
        private readonly string equinoInstrument;
        C_Instrument_Assignments controler;
        public EngineerSignature(int idInstrument, string equinoInstrument)
        {
            InitializeComponent();
            Lbl_Instrument.Text = equinoInstrument;
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
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
            string signatureBase64 = converImageToStringBase64(signature);

            controler.updateSignatureEngineer(idInstrument, signatureBase64);
            MessageBox.Show("Firma agregada correctamente");
            this.Close();            
        }
        
        public string converImageToStringBase64(Image image)
        {
            string imageBase64;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                byte[] bytes = memoryStream.ToArray();
                imageBase64 = Convert.ToBase64String(bytes);
            }
            return imageBase64;
        }
    }
}
