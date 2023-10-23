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
            return _repository.registerDeliveryInstrument(instrumentAssignments);
        }

        public bool registerReturnInstrument(Instrument_Assignments instrumentAssignments)
        {
            instrumentAssignments.dateOfReturn = _dateForReport.convertToValidDate(instrumentAssignments.dateOfReturn);
            return _repository.registerReturnInstrument(instrumentAssignments);
        }

        public void updateSignatureEngineer(int idInstrument, Image engineerSignature)
        {
            string stringSignatureBase64 = converImageToStringBase64(engineerSignature);
            _repository.updateSignatureEngineer(idInstrument, stringSignatureBase64);
        }

        public void updateSignatureQuality(int idInstrument, Image engineerSignature)
        {
            string stringSignatureBase64 = converImageToStringBase64(engineerSignature);
            _repository.updateSignatureQuality(idInstrument, stringSignatureBase64);
        }
        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
           _repository.updateStatusInstrumentAssignment(idInstrument, status);
        }

        public string converImageToStringBase64(Image image)
        {
            string imageBase64;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                image.Save(memoryStream, ImageFormat.Jpeg);
                byte[] bytes = memoryStream.ToArray();
                imageBase64 = Convert.ToBase64String(bytes);
            }
            return imageBase64;
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
    }
}
