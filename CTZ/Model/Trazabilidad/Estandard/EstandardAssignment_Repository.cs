using CTZ.Modelo.Documentacion;
using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Markup;

namespace CTZ.Model.Trazabilidad.Estandard
{
    public class EstandardAssignment_Repository
    {
        private readonly ConexionTrazability conexion;
        public EstandardAssignment_Repository() {
            conexion = new ConexionTrazability();
        }
   
        public void registerDeliveryEstandard(Estandard_Assignment assignment, string EST)
        {
            string query = "INSERT INTO AsignacionEstandares(Fecha_Entrega,Ingeniero,Folio_Empresa,Nombre_Empresa, \r\n " +
                " Observaciones_Entrega,Firma_Ingeniero,Fecha_Estimada_Devolucion,EST_Estandard,Correo_Ingeniero) " +
                " values('"+assignment.DateDelivery + "','" + assignment.Engineer + "','" + assignment.NumberEnterprise + "','" + assignment.NameEnterprise + "','" + assignment.DeliveryObservations + "',\r\n'" + assignment.EngineerSignature + "','" + assignment.EstimateDateReturn + "','" + EST + "','" + assignment.EngineerEmail + "');";
            conexion.executeQuery(query);
        }

        public void registerPermanentlyDeliveryEstandard(Estandard_Assignment assignment, string estandard)
        {
            conexion.executeQuery("INSERT INTO AsignacionEstandares(Tipo,Fecha_Entrega, Ingeniero,Observaciones_Entrega, Firma_Ingeniero,EST_Estandard,Correo_Ingeniero) " +
                " \r\nVALUES('"+assignment.type+"','"+assignment.DateDelivery+"', '"+assignment.Engineer+"', '"+assignment.DeliveryObservations+"', '"+assignment.EngineerSignature+"', '"+estandard+"', '"+assignment.EngineerEmail+"')");
        }

        public void registerReturnOfEstandard(Estandard_Assignment assignment, string estEstandard)
        {
            conexion.executeQuery(" UPDATE AsignacionEstandares SET Observaciones_Devolucion = '"+assignment.ReturnObservations+"', Firma_Calidad = '"+assignment.QualitySignature+"', Firma_Ingeniero_Devolucion = '"+assignment.EngineerSignatureReturn+"',  Fecha_Devolucion = '"+assignment.DateOfReturn+"' " +
                "\r\n WHERE EST_Estandard = '" + estEstandard + "';");
        }

        public DataTable selectInformationOfMoreRecentLoan(string estEstandard)
        {
            return conexion.getDataTable("SELECT * from AsignacionEstandares  \r\n                 " + 
                " WHERE EST_Estandard  = '"+ estEstandard + "' AND Fecha_Entrega =(Select MAX(Fecha_Entrega) \r\n " +
                " FROM AsignacionEstandares WHERE EST_Estandard = '"+ estEstandard + "');");
        }

        public DataTable selectAllByEnginner(string engineerName)
        {
            return conexion.getDataTable("Select * from AsignacionEstandares WHERE Ingeniero like '%"+ engineerName + "%';");
        }

        public DataTable selectAllByEstandard(string estEstandard)
        {
            return conexion.getDataTable("Select * from AsignacionEstandares WHERE EST_Estandard = '"+ estEstandard + "';");
        }

        public DataTable selectAllByBrand(string nameEnterprise)
        {
            return conexion.getDataTable("Select * from AsignacionEstandares WHERE Nombre_Empresa like '%"+nameEnterprise+"%';");
        }

    }
}
