using CTZ.Modelo.Documentacion;
using CTZ.View.Estandard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace CTZ.Model.Trazabilidad.Estandard
{
    public class EstandardAssignment_Repository
    {
        ConexionTrazability conexion;
        public EstandardAssignment_Repository() {
            conexion = new ConexionTrazability();
        }
   
        public void registerDeliveryEstandard(Estandard_Assignment assignment,int idEstandard, string EST)
        {
            conexion.executeQuery("INSERT INTO AsignacionEstandares(Id_Estandar,Fecha_Entrega,Ingeniero,Folio_Empresa,Nombre_Empresa, \r\n " +
                " Observaciones_Entrega,Firma_Ingeniero,Fecha_Estimada_Devolucion,EST_Estandard) " +
                " values("+idEstandard+",'"+assignment.DateDelivery+"','"+assignment.Engineer+"','"+assignment.NumberEnterprise+"','"+assignment.NameEnterprise+"','"+assignment.DeliveryObservations+"',\r\n'"+assignment.EngineerSignature+"','"+assignment.EstimateDateReturn+"','"+EST+"')");
        }

    }
}
