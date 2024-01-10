
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Certificates_
{
    public class C_Add_Certificate
    {
        Certificate_Repository repository;
        public C_Add_Certificate() {
            repository = new Certificate_Repository();
        }

        public void add(Certificate certificate)
        {
            repository.add(certificate);
        }

        public bool checkIfNumberExist(string number)
        {
            return repository.checkIfNumberExist(number);
        }
    }
}
