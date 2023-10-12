using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public  class DateForReport
    {
     
        public string convertToValidDate(string date)
        {
            DateTime validDate = Convert.ToDateTime(date);
            return validDate.ToString("yyyy/MM/dd");
        }
    }
}
