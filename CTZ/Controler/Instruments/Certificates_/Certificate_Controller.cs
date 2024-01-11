using CTZ.Modelo.Trazabilidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Certificates_
{
    public abstract class Certificate_Controller
    {
        public Certificate_Repository repository;
        public Certificate_Controller() {
            repository = new Certificate_Repository();
        }
    }
}
