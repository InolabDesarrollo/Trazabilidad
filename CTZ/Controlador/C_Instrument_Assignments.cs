using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_Instrument_Assignments
    {
        Instrument_Assignment_Repository _repository;
        public C_Instrument_Assignments() {
            _repository = new Instrument_Assignment_Repository();
        }

        public bool registerDeliveryInstrument(Instrument_Assignments instrumentAssignments)
        {
            return _repository.registerDeliveryInstrument(instrumentAssignments);
        }

        public void updateSignatureEngineer(int idInstrument, Image engineerSignature)
        {
            string stringSignatureBase64 = converImageToStringBase64(engineerSignature);
            _repository.updateSignatureEngineer(idInstrument, stringSignatureBase64);
        }

        public void updateSignatureQuality(int idInstrument, Image engineerSignature)
        {
            string stringSignatureBase64 = converImageToStringBase64(engineerSignature);
            _repository.updateSignatureQuality(idInstrument, stringSignatureBase64);
        }
        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
           _repository.updateStatusInstrumentAssignment(idInstrument, status);
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
