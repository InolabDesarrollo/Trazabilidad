using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Traceability;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_TraceabilityRepository
    {
        TraceabilityLetter_Repository repository;
        public C_TraceabilityRepository()
        {
            repository = new TraceabilityLetter_Repository();
        }

        public void add(InternTraceability_Letter traceability)
        {
            repository.add(traceability);
        }

        public string selectColumn(string column, string numberOfCertificate)
        {
            return repository.selectColumn(column, numberOfCertificate);
        }

        public bool verifiIdTraceability(string numberCertificate)
        {
            return repository.verifiTraceability(numberCertificate);
        }
    }
}
