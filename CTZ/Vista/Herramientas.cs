using CTZ.Modelo.Documentacion;
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
    public partial class Herramientas : MaterialForm
    {
        public Herramientas()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            ConexionTrazabilidad conexion = new ConexionTrazabilidad();
            Dgv_Herramientas.DataSource = conexion.getDataTable("SELECT * FROM Herramientas");
        }
    }
    
}
