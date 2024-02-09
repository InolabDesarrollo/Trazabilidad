using Model.Trazabilidad.Instruments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CTZ.Controler.Instruments.Accessory
{
    public class C_Regist_Delivery_Accessories
    {
        Instrument_Accessories_Repository repository;
        public C_Regist_Delivery_Accessories()
        {
            repository = new Instrument_Accessories_Repository();
        }

        public void updateStatusAssignment(List<string> accessoriesList, string statusAssignment)
        {
            foreach (string accessory in accessoriesList)
            {
                repository.updateStatusAssignment(accessory, statusAssignment);
            }
        }

        public void updateStatusAssignment(string idInstrument, string statusOfAssignment)
        {
            List<string> accessoriesOfInstrument =
                repository.selectAccessoriesOfInstrument(idInstrument);

            foreach (string accessory in accessoriesOfInstrument)
            {
                repository.updateStatusAssignment(accessory, statusOfAssignment);
            }
        }

    }
}
