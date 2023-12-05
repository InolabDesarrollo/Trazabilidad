using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View.Responsabilitis
{
    public class Signature
    {
        private Image imageSignature;
        public Signature() {

        }

        public string createStringOfSignature(Panel Pnl_Signature)
        {
            imageSignature = new Bitmap(Pnl_Signature.Width, Pnl_Signature.Height);
            var graphic = Graphics.FromImage(imageSignature);
            var rectangle = Pnl_Signature.RectangleToScreen(Pnl_Signature.ClientRectangle);

            graphic.CopyFromScreen(rectangle.Location, System.Drawing.Point.Empty, Pnl_Signature.Size);
            imageSignature.Save("Firma.jpg", ImageFormat.Jpeg);

            string signatureString = converImageToStringBase64(imageSignature);
            return signatureString;
        }

        private string converImageToStringBase64(Image image)
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
