using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Traceability
{
    public class ExternalTraceability_Letter: TraceabilityLetter
    {
        public int idTraceabilityLetter;
        public readonly string calibrateBy;
        public  string title;
        public  string organization;
        C_ExternTraceabilityRepository controller;

        public ExternalTraceability_Letter(int idTraceabilityLetter,string calibrateBy ,string title, string organization,string enterprise,string equipment
            ,string brand,string model, string numberOfSerie, string ununcertainty) {
            this.idTraceabilityLetter = idTraceabilityLetter;
            this.calibrateBy = calibrateBy;
            this.title = title;
            this.organization = organization;
            this.enterprise = enterprise;
            this.equipment = equipment;
            this.brand = brand;
            this.model = model;
            this.numberOfSerie = numberOfSerie;
            this.uncertainty = ununcertainty;            
        }

       
    }
}
