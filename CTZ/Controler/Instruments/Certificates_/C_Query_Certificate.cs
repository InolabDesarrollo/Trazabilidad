using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace CTZ.Controler.Instruments.Certificates_
{
    public class C_Query_Certificate : Certificate_Controller
    {
        public DataTable getAllActivesCertificate(string instrument )
        {
            return this.repository.getAllActivesCertificate(instrument);
        }

        public void updateStatusCertificate(string numberCertificate, string instrument)
        {
            this.repository.updateStatusCertificate(numberCertificate, instrument);
        }
    }
}
