using CTZ.Modelo;
using CTZ.Modelo.Trazabilidad;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CTZ.Controlador
{
    public class C_Instrument_Assignments
    {
        Instrument_Assignment_Repository _repository;
        DateForReport _dateForReport;
        public C_Instrument_Assignments() {
            _repository = new Instrument_Assignment_Repository();
            _dateForReport = new DateForReport();
        }

        public bool registerDeliveryInstrument(Instrument_Assignments instrumentAssignments)
        {
            instrumentAssignments.dateDelivery = _dateForReport.convertToValidDate(instrumentAssignments.dateDelivery);
            instrumentAssignments.approximateDateOfReturn = _dateForReport.convertToValidDate(instrumentAssignments.approximateDateOfReturn);
            
            return _repository.registerDeliveryInstrument(instrumentAssignments);
        }

        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments, Dictionary<int,string> informationId_Equino)
        {
            instrumentAssignments.dateDelivery = _dateForReport.convertToValidDate(instrumentAssignments.dateDelivery);
            instrumentAssignments.approximateDateOfReturn = _dateForReport.convertToValidDate(instrumentAssignments.approximateDateOfReturn);
            
            foreach (KeyValuePair<int, string> id_Equino in informationId_Equino)
            {
                _repository.registerDeliveryInstrument(instrumentAssignments, id_Equino.Key,id_Equino.Value);
            }   
        }

        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
           _repository.updateStatusInstrumentAssignment(idInstrument, status);
        }

        public DataTable selectAllInformationInstrumentAssignment(string EquinoInstrument)
        {
            return _repository.selectAllByEquino(EquinoInstrument);
        }
        public DataTable selectAllByEquinoAndDates(string EquinoInstrument, DateForReport dates)
        {
            return _repository.selectAllByEquinoAndDates(EquinoInstrument,dates);
        }

        public DataTable selectAllByNumberEnterprise(string numberEnterprise)
        {
            return _repository.selectAllByNumberEnterprise(numberEnterprise);
        }

        public DataTable selectAllByNumberEnterpriseAndDates(string numberEnterprise, DateForReport dates)
        {
            return _repository.selectAllByNumberEnterpriseAndDates(numberEnterprise,dates);
        }

        public DataTable selectAllById(int id)
        {
            return _repository.selectAllById(id);
        }
        public DataTable selectAllByEngineer(string engineer)
        {
            return _repository.selectAllByEngineer(engineer);
        }

        public DataTable selectAllByEngineer(string engineer, DateForReport dates)
        {
            return _repository.selectAllByEngineer(engineer,dates);
        }
        public bool checkIfEngineerHasAssignment(string engineer)
        {
            return _repository.checkIfEngineerHasAssignment(engineer);
        }

        public bool checkInformationWidthNumberEnterprise(string numberEnterprise)
        {
            return _repository.checkInformationWidthNumberEnterprise(numberEnterprise);
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(int idInstrument)
        {
            return _repository.selectMoreRecentInformationInstrumenAssignment(idInstrument);
        }

        public void updateInstrumentAssignment(Instrument_Assignments instrument_Assignments)
        {
            _repository.updateInstrumentAssignment(instrument_Assignments);
        }
    }
}
