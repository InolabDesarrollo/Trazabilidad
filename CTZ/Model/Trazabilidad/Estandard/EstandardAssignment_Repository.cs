using CTZ.Modelo.Documentacion;
using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CTZ.Model.Trazabilidad.Estandard
{
    public class EstandardAssignment_Repository
    {
        private readonly ConexionTrazability conexion;
        public EstandardAssignment_Repository() {
            conexion = new ConexionTrazability();
        }
   
        public void registerDeliveryEstandard(Estandard_Assignment assignment,int idEstandard, string EST)
        {
            conexion.executeQuery("INSERT INTO AsignacionEstandares(Id_Estandar,Fecha_Entrega,Ingeniero,Folio_Empresa,Nombre_Empresa, \r\n " +
                " Observaciones_Entrega,Firma_Ingeniero,Fecha_Estimada_Devolucion,EST_Estandard,Correo_Ingeniero) " +
                " values("+idEstandard+",'"+assignment.DateDelivery+"','"+assignment.Engineer+"','"+assignment.NumberEnterprise+"','"+assignment.NameEnterprise+"','"+assignment.DeliveryObservations+"',\r\n'"+assignment.EngineerSignature+"','"+assignment.EstimateDateReturn+"','"+EST+"','"+assignment.EngineerEmail+"');");
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



    }
}
