using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class Instrument_Assignment_Repository
    {
        ConexionTrazabilidad conexion;      
        public Instrument_Assignment_Repository() {
            conexion = new ConexionTrazabilidad();
        }


    }
}
