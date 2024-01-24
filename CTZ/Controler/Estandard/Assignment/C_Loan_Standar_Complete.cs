using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard.Assignment
{
    public class C_Loan_Standar_Complete : C_Loan
    {

        protected override void updateStatusStandar(Estandard_Assignment assignment, List<string> estEstandards)
        {
            foreach (string estandar in estEstandards)
            {
                assignmentRepository.registerDeliveryEstandard(assignment, estandar);
            }
            this.updateEstatusLoanEstandard("PRESTADO", estEstandards);
        }
    }
}
