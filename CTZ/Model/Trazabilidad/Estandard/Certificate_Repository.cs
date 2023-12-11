using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Trazabilidad.Estandard
{
    public class Certificate_Repository
    {
        ConexionTrazability connection;
        public Certificate_Repository() {
            connection = new ConexionTrazability();
        } 

        public string selectCurrentCertificate(int idEstandard)
        {
            return connection.getText("Select * from Certificados_Estandares WHERE " +
                " Id_Estandard = "+ idEstandard + ";");
        }


    }
}
