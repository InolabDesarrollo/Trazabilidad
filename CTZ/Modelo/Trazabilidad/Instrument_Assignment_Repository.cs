﻿using CTZ.Modelo.Documentacion;
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
            return conexion.executeQuery("INSERT INTO AsignacionInstrumentos(ID_Instrumento,Fecha_Entrega,Ingeniero,Folio_Empresa,Nombre_Empresa,Observaciones_Entrega," +
                "\r\n Equino_Instrumento)\r\n" +
                "VALUES("+instrumentAssignments.idInstrument+",'"+instrumentAssignments.dateDelivery+"','"+instrumentAssignments.engineer+"','"+instrumentAssignments.numberEnterprise+"','"+instrumentAssignments.nameEnterprise
                +"','"+instrumentAssignments.observationDelivery+"','"+instrumentAssignments.equinoInstrument+"')");
        }

        public bool registerReturnInstrument(Instrument_Assignments instrumentAssignments)
        {
            return conexion.executeQuery("UPDATE AsignacionInstrumentos SET Fecha_Devolucion  = '"+instrumentAssignments.dateOfReturn+"', \r\nObservaciones_Devolucion ='"+instrumentAssignments.observationsReturn+"' \r\n" +
                " WHERE ID_Instrumento = "+instrumentAssignments.idInstrument+" AND Fecha_Entrega =(Select MAX(Fecha_Entrega) " +
                " FROM AsignacionInstrumentos WHERE ID_Instrumento =18);");
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

        public DataTable selectInformationInstrumenAssignment(int idInstrument)
        {
            return conexion.getDataTable("");
        }
    }
}
