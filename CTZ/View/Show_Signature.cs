using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.View
{
    public partial class Show_Signature : Form
    {

        public Show_Signature(string signatureBase64)
        {
            InitializeComponent();
            PictureBoxSignature.Image = converStringToImage(signatureBase64);
        }

        public Image converStringToImage(string signatureBase64)
        {
            byte[] imageBytes = Convert.FromBase64String(signatureBase64);
            Image image;
            using (MemoryStream memoryStream = new MemoryStream(imageBytes))
            {
                image = Image.FromStream(memoryStream);
            }
            return image;
        }
    }
}
