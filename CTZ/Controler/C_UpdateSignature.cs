using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler
{
    public class C_UpdateSignature
    {
        Instrument_Assignment_Repository repository;
        public C_UpdateSignature() {
            repository = new Instrument_Assignment_Repository();
        }

        public void updateSignatureEngineer(int idInstrument, Image engineerSignature)
        {
            string stringSignatureBase64 = converImageToStringBase64(engineerSignature);
            repository.updateSignatureEngineer(idInstrument, stringSignatureBase64);
        }

        public void updateSignatureQuality(int idInstrument, Image signature)
        {
            string stringSignatureBase64 = converImageToStringBase64(signature);
            repository.updateSignatureQuality(idInstrument, stringSignatureBase64);
        }

        public void registEngineerSignatureByGroup(Image engineerSignature, Dictionary<int, string> informationId_Equino)
        {
            foreach (KeyValuePair<int, string> id in informationId_Equino)
            {
                updateSignatureEngineer(id.Key, engineerSignature);
            }
        }

        public void registQualitySignatureByGroup(Image qualitySignature, List<int> idInstruments)
        {
            foreach (int id in idInstruments)
            {
                updateSignatureQuality(id, qualitySignature);
            }
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
