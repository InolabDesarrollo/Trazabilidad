using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
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
        C_Certificate controler = new C_Certificate();

        public Certificate(string dateCalibration,string nextCalibration,string link,
            string number,string use, string laboratory,string dateOfRegist) {

            this.dateCalibration = dateCalibration;
            this.nextCalibration = nextCalibration;
            this.link = link;
            this.number = number;
            this.use = use;
            this.laboratory = laboratory;
            this.dateOfRegist = dateOfRegist;
        }

        public Certificate()
        {
            controler = new C_Certificate();
        }
        
        public void add()
        {
            Certificate certificate = new Certificate(this.dateCalibration, this.nextCalibration, this.link,
                this.number, this.use, this.laboratory,this.dateOfRegist);
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

        public string getCelValue(int idSqlCertificate, string cell)
        {
            return controler.getValueCell(idSqlCertificate, cell);
        }

        public bool checkIfNumberExist()
        {
            return controler.checkIfNumberExist(number);
        }

       
    }
}
