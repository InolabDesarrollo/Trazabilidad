using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Traceability;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_ExternTraceabilityRepository
    {
        ExternalTraceability_Repository repository;
        public C_ExternTraceabilityRepository() {
            repository = new ExternalTraceability_Repository();
        }
        public void add(ExternalTraceability_Letter traceability_Letter)
        {
            repository.add(traceability_Letter);
        }

        public DataTable selectExternalTrazabilityLetters(int idInternTrazabilityLetter)
        {
            return repository.selectExternalTrazabilityLetters(idInternTrazabilityLetter);
        }


    }
}
