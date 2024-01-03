using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.View.Estandard
{
    public class CertificateEstandard
    {
        public string ExpirationDate;

        public string Lot;

        public string NumberOfPart;

        public string RegisterDate;

        public string Link;

        public string Status;

        public int idEstandard;

        public string getCertificates(Dictionary<int, string> estandardInformation)
        {
            CTZ.Controler.Estandard.C_Certificate controller = new Controler.Estandard.C_Certificate();
            string linksCertificates = "";
            List<string> certificates = new List<string>();
            string link;
            for (int i=0; i<estandardInformation.Count; i++)
            {
                link = controller.getLinkCertificate(estandardInformation.Keys.ElementAt(i));
                if(link != "")
                {
                    certificates.Add(link);
                }
                else
                {
                    certificates.Add("Estandard "+estandardInformation.Values.ElementAt(i)+" Sin link");
                }
                
            }
            linksCertificates = String.Join(", ", certificates);
            return linksCertificates;
        }
    }
}
