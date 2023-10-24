using CTZ.Modelo.Documentacion;
using CTZ.Vista.Instruments;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class Instrument_Assignment_Repository
    {
        ConexionTrazabilidad conexion;      
        public Instrument_Assignment_Repository() {
            conexion = new ConexionTrazabilidad();
        }

        public bool registerDeliveryInstrument(Instrument_Assignments instrumentAssignments)
        {
            return conexion.executeQuery("INSERT INTO AsignacionInstrumentos(ID_Instrumento,Fecha_Entrega,Fecha_Estimada_Devolucion,Ingeniero,Folio_Empresa,Nombre_Empresa,Observaciones_Entrega," +
                "\r\n Equino_Instrumento,Correo_Ingeniero)\r\n" +
                "VALUES("+instrumentAssignments.idInstrument+",'"+instrumentAssignments.dateDelivery+"','"+instrumentAssignments.approximateDateOfReturn+"','" +instrumentAssignments.engineer+"','"+instrumentAssignments.numberEnterprise+"','"+instrumentAssignments.nameEnterprise
                +"','"+instrumentAssignments.observationDelivery+"','"+instrumentAssignments.equinoInstrument+"','"+instrumentAssignments.mailEngineer+"')");
        }

        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments,int idInstrument, string equino )
        {
            conexion.executeQuery("INSERT INTO AsignacionInstrumentos(ID_Instrumento,Fecha_Entrega,Fecha_Estimada_Devolucion,Ingeniero,Folio_Empresa,Nombre_Empresa,Observaciones_Entrega," +
                "\r\n Equino_Instrumento,Correo_Ingeniero)\r\n" +
                "VALUES(" + idInstrument + ",'" + instrumentAssignments.dateDelivery + "','" + instrumentAssignments.approximateDateOfReturn + "','" + instrumentAssignments.engineer + "','" + instrumentAssignments.numberEnterprise + "','" + instrumentAssignments.nameEnterprise
                + "','" + instrumentAssignments.observationDelivery + "','" + equino + "','" + instrumentAssignments.mailEngineer + "')");
        }

        public bool registerReturnInstrument(Instrument_Assignments instrumentAssignments)
        {
            return conexion.executeQuery("UPDATE AsignacionInstrumentos SET Fecha_Devolucion  = '"+instrumentAssignments.dateOfReturn+"', \r\nObservaciones_Devolucion ='"+instrumentAssignments.observationsReturn+"' \r\n" +
                " WHERE ID_Instrumento = "+instrumentAssignments.idInstrument+" AND Fecha_Entrega =(Select MAX(Fecha_Entrega) " +
                " FROM AsignacionInstrumentos WHERE ID_Instrumento ="+instrumentAssignments.idInstrument+");");
        }
        
        public void updateSignatureEngineer(int idInstrument, string engineerSignature)
        {
            conexion.executeQuery("UPDATE AsignacionInstrumentos SET Firma_Ingeniero = '"+engineerSignature+"' where ID_Instrumento = " + idInstrument + ";");
        }

        public void updateSignatureQuality(int idInstrument, string engineerSignature)
        {
            conexion.executeQuery("UPDATE AsignacionInstrumentos SET Firma_Calidad  = '"+ engineerSignature + "' WHERE ID_Instrumento = "+idInstrument+ " " +
                " AND Fecha_Entrega =(Select MAX(Fecha_Entrega) FROM AsignacionInstrumentos WHERE ID_Instrumento ="+ idInstrument + ");");
        }
        
        public void updateStatusInstrumentAssignment(int idInstrument, string status)
        {
            conexion.executeQuery("UPDATE Instrumentos SET ESTATUS_ASIGNACION = '"+status+"' WHERE ID = "+idInstrument+";");
        }

        public DataTable selectAllByEquino(string EquinoInstrument)
        {
            return conexion.getDataTable("SELECT * FROM AsignacionInstrumentos " +
                " WHERE Equino_Instrumento = '"+ EquinoInstrument + "';");
        }
        public DataTable selectAllByEquinoAndDates(string EquinoInstrument, DateForReport dates)
        {
            return conexion.getDataTable("SELECT * FROM AsignacionInstrumentos  WHERE Fecha_Entrega BETWEEN '"+dates.dateBegan+"' AND '"+dates.dateFinal+"' " +
                " AND Equino_Instrumento = '"+ EquinoInstrument + "' ");
        }

        public DataTable selectAllById(int id)
        {
            return conexion.getDataTable("Select * from AsignacionInstrumentos where ID = " + id + ";");
        }

        public DataTable selectAllByNumberEnterprise(string numberEnterprise)
        {
            return conexion.getDataTable("Select * from AsignacionInstrumentos " +
                " WHERE Folio_Empresa = '"+ numberEnterprise + "';");
        }

        public DataTable selectAllByNumberEnterpriseAndDates(string numberEnterprise,DateForReport dates)
        {
            return conexion.getDataTable("SELECT * FROM AsignacionInstrumentos  WHERE Fecha_Entrega " +
                " BETWEEN '"+dates.dateBegan+"' AND '"+dates.dateFinal+"' AND Folio_Empresa = '"+numberEnterprise+"';");
        }

        public DataTable selectAllByEngineer(string engineer)
        {
            return conexion.getDataTable("Select  * from AsignacionInstrumentos Where Ingeniero " +
                " Like '%"+engineer+"%';");
        }

        public DataTable selectAllByEngineer(string engineer, DateForReport dates)
        {
            return conexion.getDataTable("Select  * from AsignacionInstrumentos Where Ingeniero " +
                " Like '%" + engineer + "%';");
        }

        public bool checkIfEngineerHasAssignment(string engineer)
        {
            return conexion.isThereSomeInformation("Select  * from AsignacionInstrumentos Where Ingeniero " +
                " Like '%" + engineer + "%';");
        }

        public bool checkInformationWidthNumberEnterprise(string numberEnterprise)
        {
            return conexion.isThereSomeInformation("Select * from AsignacionInstrumentos " +
                " WHERE Folio_Empresa = '" + numberEnterprise + "';");
        }

        public DataTable selectMoreRecentInformationInstrumenAssignment(int idInstrument)
        {
            return conexion.getDataTable("SELECT * from AsignacionInstrumentos \r\n" +
                " WHERE ID_Instrumento = "+ idInstrument + " AND Fecha_Entrega =(Select MAX(Fecha_Entrega) " +
                " FROM AsignacionInstrumentos WHERE ID_Instrumento ="+ idInstrument + ");");
        }

        
        
    }
}
