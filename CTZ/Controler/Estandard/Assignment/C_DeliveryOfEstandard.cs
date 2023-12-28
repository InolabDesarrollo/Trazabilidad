﻿using CTZ.Controler.Estandard.Assignment;
using CTZ.Model.Trazabilidad.Estandard;
using CTZ.Modelo;
using CTZ.View.Estandard;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Estandard
{
    public class C_DeliveryOfEstandard : C_EstandardAssignment
    {
 
        public void registerDeliveryEstandard(Estandard_Assignment assignment,Dictionary<int,string> estandardInformation)
        {
            DateForReport dates = new DateForReport();
            assignment.DateDelivery = dates.convertToValidDateDatePicker(assignment.DateDelivery);
            assignment.EstimateDateReturn = dates.convertToValidDateDatePicker(assignment.EstimateDateReturn);

            foreach (KeyValuePair<int, string> element in estandardInformation)
            {
                assignmentRepository.registerDeliveryEstandard(assignment, element.Key, element.Value);
            }
        }

        

    }
}
