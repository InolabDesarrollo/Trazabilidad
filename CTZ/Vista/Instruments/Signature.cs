using CTZ.Controlador;
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

namespace CTZ.Vista.Instruments
{
    public partial class Signature : Form
    {
        private int id;
        C_Instrument_Assignments controler;
        DataTable instrumenAssignmentInformation;
        string base64StrigSignature;
        public Signature(int id)
        {
            this.id = id;
            InitializeComponent();
            controler = new C_Instrument_Assignments();
            instrumenAssignmentInformation = controler.selectAllById(id);
            base64StrigSignature = instrumenAssignmentInformation.Rows[0]["Firma_Ingeniero"].ToString();
            PictureBoxSignature.Image =converStringToImage(base64StrigSignature);
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
