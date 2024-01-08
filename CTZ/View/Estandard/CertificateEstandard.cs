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

        public string Estandard;

        public string getCertificates(List<string> estandarList)
        {
            CTZ.Controler.Estandard.C_Certificate controller = new Controler.Estandard.C_Certificate();
            string certificateLinks= "";
            List<string> certificates = new List<string>();
            string link;
            foreach(string estandar in estandarList)
            {
                link = controller.getLinkCertificate(estandar);
                if(link != "")
                {
                    certificates.Add(link);
                }
                else
                {
                    certificates.Add("Estandard "+estandar+" Sin link");
                }
            }
            certificateLinks = String.Join(", ", certificates);
            return certificateLinks;
        }
    }
}
