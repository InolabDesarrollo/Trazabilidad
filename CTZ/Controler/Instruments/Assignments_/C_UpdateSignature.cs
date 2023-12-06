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

        public void updateSignatureEngineer(int idInstrument, string engineerSignature)
        {
            repository.updateSignatureEngineer(idInstrument, engineerSignature);
        }

        public void updateSignatureQuality(int idInstrument, string signature)
        {
            repository.updateSignatureQuality(idInstrument, signature);
        }

        public void registEngineerSignatureByGroup(string engineerSignature, Dictionary<int, string> informationId_Equino)
        {
            foreach (KeyValuePair<int, string> id in informationId_Equino)
            {
                updateSignatureEngineer(id.Key, engineerSignature);
            }
        }

        public void registQualitySignatureByGroup(string qualitySignature, List<int> idInstruments)
        {
            foreach (int id in idInstruments)
            {
                updateSignatureQuality(id, qualitySignature);
            }
        }

    }
}
