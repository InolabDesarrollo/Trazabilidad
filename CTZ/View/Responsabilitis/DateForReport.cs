using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    public  class DateForReport
    {
        public string dateBegan;
        public string dateFinal;
        public DateForReport(string dateBegan, string dateFinal)
        {
            this.dateBegan = convertToValidDate(dateBegan);
            this.dateFinal = convertToValidDate(dateFinal);
        }
        public DateForReport()
        {
        }
        public string convertToValidDate(string date)
        {
            DateTime validDate = Convert.ToDateTime(date);
            return validDate.ToString("yyyy/MM/dd");
        }
    }
}
