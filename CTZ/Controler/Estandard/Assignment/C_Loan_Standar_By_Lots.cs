using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard.Assignment
{
    public class C_Loan_Standar_By_Lots : C_Loan
    {
        protected override void updateStatusStandar(Estandard_Assignment assignment, List<string> estEstandards)
        {
            foreach (string standar in estEstandards)
            {
                assignmentRepository.registerDeliveryEstandard(assignment, standar);
                updateAvailableLots(standar, assignment.NumberOfLots);
            }
            this.updateEstatusLoanEstandard("PRESTADO_POR_LOTES", estEstandards);
        }

        private void updateAvailableLots(string standar, int numberOfLotsToLoan)
        {
            C_Estandard controller = new C_Estandard();
            int numberOfLotsAvailable = controller.getNumberOfLotsAvailable(standar);
            numberOfLotsAvailable = numberOfLotsAvailable - numberOfLotsToLoan;

            estandardsRepository.updateAvailableLots(standar, numberOfLotsAvailable);
        }
    }
}
