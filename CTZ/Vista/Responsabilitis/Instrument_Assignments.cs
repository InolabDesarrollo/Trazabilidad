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
        C_Instrument_Assignments controler;

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

        public Instrument_Assignments(int idInstrument,string equinoInstrument,string dateDelivery,string engineer,
            string numberEnterprise,string nameEnterprise,string observationDelivery,string mailEngineer,string approximateDateOfReturn) {
            this.idInstrument = idInstrument;
            this.equinoInstrument = equinoInstrument;
            this.dateDelivery = dateDelivery;
            this.engineer = engineer;
            this.numberEnterprise = numberEnterprise;
            this.nameEnterprise = nameEnterprise;
            this.observationDelivery = observationDelivery;
            this.mailEngineer = mailEngineer;
            this.approximateDateOfReturn = approximateDateOfReturn;
            controler = new C_Instrument_Assignments();
            
        }
        public Instrument_Assignments()
        {
            controler = new C_Instrument_Assignments();
        }

        public void addDeliveryInstrument()
        {
            Instrument_Assignments instrumentDelivery =
                new Instrument_Assignments(this.idInstrument, this.equinoInstrument, this.dateDelivery,
                 this.engineer, this.numberEnterprise, this.nameEnterprise, this.observationDelivery,
                this.mailEngineer, this.approximateDateOfReturn);

            controler.registerDeliveryInstrument(instrumentDelivery);
        }

        public void updateStatus(string status)
        {
            controler.updateStatusInstrumentAssignment(idInstrument, status);
        }

        public void updateInstrumentAssignments()
        {
            Instrument_Assignments instrument_Assignments = new Instrument_Assignments();
            instrument_Assignments.idInstrument = this.idInstrument;
            instrument_Assignments.numberEnterprise = this.numberEnterprise;
            instrument_Assignments.nameEnterprise = this.nameEnterprise;
            instrument_Assignments.observationDelivery = this.observationDelivery;
            instrument_Assignments.observationsReturn = this.observationsReturn;

            controler.updateInstrumentAssignment(instrument_Assignments);
        }

    }
}
