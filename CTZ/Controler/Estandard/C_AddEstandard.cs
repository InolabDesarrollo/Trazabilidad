using CTZ.Model.Trazabilidad.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTZ.View.Responsabilitis;
using CTZ.Vista.Responsabilitis;
using Model;
using Model.Trazabilidad.Standar;

namespace CTZ.Controler.Estandard
{
    public class C_AddEstandard
    {

        private readonly Estandards_Repository repository;
        private Standar_Repository_EFC repository_EFC;
        public C_AddEstandard() { 
            repository = new Estandards_Repository();
            repository_EFC = new Standar_Repository_EFC();
        }

        public void add(Estandares standar)
        {
            DateForReport date = new DateForReport();
            standar.FechaDeFabricacion = date.convertToValidDateDatePicker(standar.FechaDeFabricacion);
            standar.FechaDeCaducidad = date.convertToValidDateDatePicker(standar.FechaDeCaducidad);

            repository_EFC.create(standar);
            string estatusAssignment = "";

            if (standar.Estatus_Prestamo.Equals("Sin Asignar"))
            {
                estatusAssignment = "DISPONIBLE";
            }
            else
            {
                estatusAssignment = "ASIGNADO";
            }

            repository.updateEstatusLoanEstandard(estatusAssignment, standar.Id_Estandares);
        }

    }
}
