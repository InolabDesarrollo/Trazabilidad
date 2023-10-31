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
    public partial class ShowSignature : Form
    {
        C_Instrument_Assignments controler;
        DataTable instrumenAssignmentInformation;
        string base64StrigSignature;
        private const int engineerSignature = 7;
        private const int qualitySignature = 11;

        public ShowSignature(int id, int  columnToShow)
        {
            InitializeComponent();
            controler = new C_Instrument_Assignments();
            instrumenAssignmentInformation = controler.selectAllById(id);
            if (columnToShow.Equals(engineerSignature))
            {
                base64StrigSignature = instrumenAssignmentInformation.Rows[0]["Firma_Ingeniero"].ToString();
            }
            if (columnToShow.Equals(qualitySignature))
            {
                base64StrigSignature = instrumenAssignmentInformation.Rows[0]["Firma_Calidad"].ToString();
            }
            
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
