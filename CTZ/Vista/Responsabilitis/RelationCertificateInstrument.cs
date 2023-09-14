using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public class RelationCertificateInstrument
    {
        private  int idInstrument;
        private  int idCertificate;
        C_RelationCertificateInstrument controler;
        public RelationCertificateInstrument(int idInstrument, int idCertificate) {

            controler = new C_RelationCertificateInstrument();
            this.idInstrument = idInstrument;
            this.idCertificate = idCertificate;
        }
        
        public void create()
        {
            controler.create(idInstrument, idCertificate);
        }
    }
}
