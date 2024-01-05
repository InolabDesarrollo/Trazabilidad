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
        ConexionTrazability conexion;      
        public Instrument_Assignment_Repository() {
            conexion = new ConexionTrazability();
        }

        public void registerDeliveryInstrument(Instrument_Assignments instrumentAssignments,int idInstrument, string equino )
        {
            conexion.executeQuery("INSERT INTO AsignacionInstrumentos(ID_Instrumento,Fecha_Entrega,Fecha_Estimada_Devolucion,Ingeniero,Folio_Empresa,Nombre_Empresa,Observaciones_Entrega," +
                "\r\n Equino_Instrumento,Correo_Ingeniero,Firma_Ingeniero)\r\n" +
                "VALUES(" + idInstrument + ",'" + instrumentAssignments.DateDelivery + "','" + instrumentAssignments.EstimateDateReturn + "','" + instrumentAssignments.Engineer + "','" + instrumentAssignments.NumberEnterprise + "','" + instrumentAssignments.NameEnterprise
                + "','" + instrumentAssignments.DeliveryObservations + "','" + equino + "','" + instrumentAssignments.EngineerEmail + "','"+instrumentAssignments.EngineerSignature+"')");
        }

        public bool registerReturnInstrument(Instrument_Assignments instrumentAssignments, int idInstrument)
        {
            return conexion.executeQuery("UPDATE AsignacionInstrumentos SET Fecha_Devolucion  = '" + instrumentAssignments.DateOfReturn + "', \r\nObservaciones_Devolucion ='" + instrumentAssignments.ReturnObservations + "',  \r\n" +
                " Firma_Ingeniero_Devolucion = '"+instrumentAssignments.EngineerSignatureReturn+"',  Firma_Calidad = '"+instrumentAssignments.QualitySignature+"' WHERE ID_Instrumento = " + idInstrument + " AND Fecha_Entrega =(Select MAX(Fecha_Entrega) " +
                " FROM AsignacionInstrumentos WHERE ID_Instrumento =" + idInstrument + ");");
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
                " Like '%" + engineer + "%' AND Fecha_Entrega BETWEEN '"+dates.dateBegan+"' AND '"+dates.dateFinal+"' ;");
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

        public DataTable selectMoreRecentInformationInstrumenAssignment(string equinoInstrument)
        {
            return conexion.getDataTable("SELECT * from AsignacionInstrumentos \r\n" +
                " WHERE Equino_Instrumento = '"+equinoInstrument+"' AND Fecha_Entrega =(Select MAX(Fecha_Entrega) " +
                " FROM AsignacionInstrumentos WHERE Equino_Instrumento = '" +equinoInstrument+"');");
        }


        public void updateInstrumentAssignment(Instrument_Assignments instrument_Assignments)
        {
            conexion.executeQuery(" UPDATE AsignacionInstrumentos SET Folio_Empresa = '"+ instrument_Assignments.NumberEnterprise+ "', Nombre_Empresa = '"+ instrument_Assignments.NameEnterprise + "', Observaciones_Entrega = '"+ instrument_Assignments .DeliveryObservations+ "', " +
                " Observaciones_Devolucion = '"+ instrument_Assignments.ReturnObservations + "'" +
                "\r\n WHERE ID = "+ instrument_Assignments.idInstrument + ";");
        }
    }
}
