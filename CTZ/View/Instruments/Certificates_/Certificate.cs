using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CTZ.Vista.Responsabilitis
{
    public class Certificate
    {
        public  string dateCalibration;

        public  string nextCalibration;

        public  string link;

        public  string number;

        public  string use;

        public  string laboratory;

        public  string dateOfRegist;

        public string instrument;

        public string status;

        public string uncertanty;

        public string numberTemperatureCertificate;

        public string numberCertificateHr;

        public string maximumError;

        public string hrInterval;

        public string maximumErrorHr;

        public string maximumErrorT;

        public string mediumInterval;

        C_Certificate controler = new C_Certificate();

        public Certificate()
        {
            controler = new C_Certificate();
        }      
        
        public void delete(string numberCertificate)
        {
            controler.delete(numberCertificate);
        }     
    }
}
