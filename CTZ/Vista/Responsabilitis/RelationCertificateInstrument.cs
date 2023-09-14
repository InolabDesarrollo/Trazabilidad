using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
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

        public RelationCertificateInstrument(int idInstrument)
        {
            controler = new C_RelationCertificateInstrument();
            this.idInstrument = idInstrument;
        }
        public void create()
        {
            controler.create(idInstrument, idCertificate);
        }

        public DataTable getAllCertificatesForInstrument()
        {
            return controler.getAllCertificatesForInstrument(idInstrument);
        }

        public void deleteRelation()
        {
            controler.deleteRelation(idInstrument, idCertificate);
        }

    }
}
