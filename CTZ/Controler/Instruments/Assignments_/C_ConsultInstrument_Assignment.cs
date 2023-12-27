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
    public  class C_ConsultInstrument_Assignment
    {
        Instrument_Assignment_Repository _repository;
        DateForReport _dateForReport;
        public C_ConsultInstrument_Assignment() {
            _repository = new Instrument_Assignment_Repository();
            _dateForReport = new DateForReport();
        }

        public DataTable selectAllInformationInstrumentAssignment(string EquinoInstrument)
        {
            return _repository.selectAllByEquino(EquinoInstrument);
        }

        public DataTable selectAllByNumberEnterprise(string numberEnterprise)
        {
            return _repository.selectAllByNumberEnterprise(numberEnterprise);
        }

        public DataTable selectAllByEquinoAndDates(string EquinoInstrument, DateForReport dates)
        {
            return _repository.selectAllByEquinoAndDates(EquinoInstrument, dates);
        }

        public DataTable selectAllByNumberEnterpriseAndDates(string numberEnterprise, DateForReport dates)
        {
            return _repository.selectAllByNumberEnterpriseAndDates(numberEnterprise, dates);
        }

        public DataTable selectAllByEngineer(string engineer, DateForReport dates)
        {
            return _repository.selectAllByEngineer(engineer, dates);
        }


    }
}
