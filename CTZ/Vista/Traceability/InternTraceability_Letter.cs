using CTZ.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CTZ.Vista.Traceability
{
    public class InternTraceability_Letter: TraceabilityLetter
    {
        public string numberCertificate;
        public string title;
        public string internEnterprise;

        C_TraceabilityRepository controller;
        public InternTraceability_Letter(string numberCertificate,string title,string enterprise,string internEnterprise, string equipment
            , string brand,string model,string numberOfSerie, string uncertainty) {

            this.numberCertificate = numberCertificate;
            this.title = title;
            this.enterprise = enterprise;
            this.internEnterprise = internEnterprise;
            this.equipment = equipment;
            this.brand = brand;
            this.model = model;
            this.numberOfSerie = numberOfSerie;
            this.uncertainty = uncertainty;
            controller = new C_TraceabilityRepository();
        }

        public InternTraceability_Letter(string numberCertificate)
        {
            this.numberCertificate=numberCertificate;
            controller = new C_TraceabilityRepository();
        }

        public void add()
        {
            InternTraceability_Letter letter = new InternTraceability_Letter(this.numberCertificate,this.title,"",this.enterprise
                ,this.equipment,this.brand,this.model,this.numberOfSerie,this.uncertainty);
            controller.add(letter);
        }
        public string selectColumn(string column,string numberOfCertificate)
        {
            return controller.selectColumn(column,numberOfCertificate);
        }

        public void verifiId(int idTraceabilityLetter,string numberOfCertificate)
        {
            if (idTraceabilityLetter != 0)
            {
                MessageBox.Show("Carta de trazabilidad interna agregada correctamente a " +
                    "Certificado con numero " + numberOfCertificate);
            }
        }

        public bool verifiTraceabilityIdLetter()
        {
            return controller.verifiIdTraceability(numberCertificate);
        }

       
    }
}
