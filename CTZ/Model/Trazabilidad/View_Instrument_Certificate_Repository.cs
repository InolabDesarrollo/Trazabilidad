﻿using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Modelo.Trazabilidad
{
    public class View_Instrument_Certificate_Repository
    {
        ConexionTrazabilidad conexion;
        public View_Instrument_Certificate_Repository() {
            conexion = new ConexionTrazabilidad();  
        }

        public DataTable getAllInstrumentCertificate(string equino)
        {
            return conexion.getDataTable("SELECT * FROM Instrumentos_Certificado WHERE ID_Instrumentos = '"+ equino + "';");
        }


    }
}