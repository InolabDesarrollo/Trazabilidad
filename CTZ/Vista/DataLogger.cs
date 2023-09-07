﻿using CTZ.Modelo.Documentacion;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista
{
    public partial class DataLogger : MaterialForm
    {
        public DataLogger()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            ConexionTrazabilidad conexion = new ConexionTrazabilidad();
            Dgv_DataLogger.DataSource = conexion.getDataTable("SELECT * FROM DataLogger");
        }
    }
}
