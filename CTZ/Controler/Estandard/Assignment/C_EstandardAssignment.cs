using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard.Assignment
{
    public abstract class C_EstandardAssignment
    {
        public EstandardAssignment_Repository assignmentRepository;
        public Estandards_Repository estandardsRepository;
        public C_EstandardAssignment() {
            assignmentRepository = new EstandardAssignment_Repository();
            estandardsRepository = new Estandards_Repository();
        }

        public void updateEstatusLoanEstandard(string estatus, List<string> estandardInformation)
        {
            foreach (string estandard in estandardInformation)
            {
                estandardsRepository.updateEstatusLoanEstandard(estatus, estandard);
            }
        }

        public DataTable selectInformationOfMoreRecentLoan(string estEstandard)
        {
            return assignmentRepository.selectInformationOfMoreRecentLoan(estEstandard);
        }
    }
}
