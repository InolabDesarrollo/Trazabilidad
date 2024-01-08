using CTZ.Controler.Estandard.Assignment;
using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using CTZ.TrazabilidadTestDataSet4TableAdapters;
using CTZ.View.Estandard;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_ReturnOfEstandard: C_Estandard_Assignment
    {
        public void registerReturnOfEstandard(Estandard_Assignment assignment, List<string> estandards)
        {
            DateForReport date = new DateForReport();
            assignment.DateOfReturn = date.convertToValidDateDatePicker(assignment.DateOfReturn);

            foreach (string estandar in estandards)
            {
                assignmentRepository.registerReturnOfEstandard(assignment, estandar);
            }
        }

        
    }
}
