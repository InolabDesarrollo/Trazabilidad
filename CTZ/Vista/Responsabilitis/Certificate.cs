using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        C_Certificate controler = new C_Certificate();

        public Certificate(string dateCalibration,string nextCalibration,string link,
            string number,string use, string laboratory) {

            this.dateCalibration = dateCalibration;
            this.nextCalibration = nextCalibration;
            this.link = link;
            this.number = number;
            this.use = use;
            this.laboratory = laboratory;            
        }

        public Certificate()
        {
            controler = new C_Certificate();
        }
        
        public void add()
        {
            Certificate certificate = new Certificate(this.dateCalibration, this.nextCalibration, this.link,
                this.number, this.use, this.laboratory);
            controler.add(certificate);
        }

        public int getLastCertificateRegistered()
        {
            return controler.lastCertificateRegistered();
        }

        public void delete(string numberCertificate)
        {
            controler.delete(numberCertificate);
        }


    }
}
