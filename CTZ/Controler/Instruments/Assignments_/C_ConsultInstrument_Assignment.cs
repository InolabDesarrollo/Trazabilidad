using CTZ.Controlador;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controler.Instruments.Assignments_
{
    public  class C_ConsultInstrument_Assignment: C_Instrument_Assignments
    {

        public DataTable selectAllInformationInstrumentAssignment(string EquinoInstrument)
        {
            return repository.selectAllByEquino(EquinoInstrument);
        }

        public DataTable selectAllByNumberEnterprise(string numberEnterprise)
        {
            return repository.selectAllByNumberEnterprise(numberEnterprise);
        }

        public DataTable selectAllByEquinoAndDates(string EquinoInstrument, DateForReport dates)
        {
            return repository.selectAllByEquinoAndDates(EquinoInstrument, dates);
        }

        public DataTable selectAllByNumberEnterpriseAndDates(string numberEnterprise, DateForReport dates)
        {
            return repository.selectAllByNumberEnterpriseAndDates(numberEnterprise, dates);
        }

        public DataTable selectAllByEngineer(string engineer, DateForReport dates)
        {
            return repository.selectAllByEngineer(engineer, dates);
        }

        public bool checkIfEngineerHasAssignment(string engineer)
        {
            return repository.checkIfEngineerHasAssignment(engineer);
        }

        public DataTable selectAllByEngineer(string engineer)
        {
            return repository.selectAllByEngineer(engineer);
        }

        public bool checkInformationWidthNumberEnterprise(string numberEnterprise)
        {
            return repository.checkInformationWidthNumberEnterprise(numberEnterprise);
        }

        public DataTable selectAllById(int id)
        {
            return repository.selectAllById(id);
        }

    }
}
