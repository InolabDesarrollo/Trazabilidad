using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public class Signature
    {
        C_Instrument_Assignments controler;
        public Signature()
        {
            controler = new C_Instrument_Assignments();
        }

        public void registEngineerSignature(Image engineerSignature, int idInstrument)
        {
            controler.updateSignatureEngineer(idInstrument, engineerSignature);
        }

        public void registQualitySignature(Image qualitySignature, int idInstrument)
        {
            controler.updateSignatureQuality(idInstrument, qualitySignature);
        }

        public void registEngineerSignatureByGroup(Image engineerSignature, Dictionary<int,string> informationId_Equino)
        {
            foreach (KeyValuePair<int, string> id in informationId_Equino)
            {
                controler.updateSignatureEngineer(id.Key, engineerSignature);
            }
        }

        public void registQualitySignatureByGroup(Image qualitySignature,List<int> idInstruments)
        {
            foreach (int id in idInstruments)
            {
                controler.updateSignatureQuality(id, qualitySignature);
            }
        }
    }
}
