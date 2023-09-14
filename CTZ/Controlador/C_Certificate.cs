using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_Certificate
    {
        Certificate_Repository repository;
        public C_Certificate() {
            repository = new Certificate_Repository();
        }

        public void add(Certificate certificate)
        {
            repository.add(certificate);
        }

        public string getColum(string column, string number)
        {
            return repository.getColumn(column, number);
        }

        public int lastCertificateRegistered()
        {
            return repository.lastCertificateRegistered();
        }

        public void delete(string number)
        {
            repository.delete(number);
        }

       public string getValueCell(int idSqlCertificate, string cell)
       {
            return repository.getValueCell(idSqlCertificate, cell);
       }


    }
}
