using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public class Instrument_Assignments
    {

        public int idInstrument; 

        public string dateDelivery;

        public string engineer;

        public string numberEnterprise;

        public string nameEnterprise;

        public string observationDelivery;

        public string engineerSignature;

        public string mailEngineer;

        public string approximateDateOfReturn;

        public string dateOfReturn { get; set; }

        public string observationsReturn;

        public string qualitySignature;

        public string equinoInstrument;

        public Instrument_Assignments()
        {
        }

    }
}
