using CTZ.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard.Assignment
{
    public class C_Query_Estandard_Assignment : C_Estandard_Assignment
    {
        public DataTable selectAllByEnginner(string engineerName)
        {
            return assignmentRepository.selectAllByEnginner(engineerName);
        }

        public DataTable selectAllByEstandard(string estEstandard)
        {
            return assignmentRepository.selectAllByEstandard(estEstandard);
        }

        public DataTable selectAllByBrand(string nameEnterprise)
        {
            return assignmentRepository.selectAllByBrand(nameEnterprise);
        }


    }
}
