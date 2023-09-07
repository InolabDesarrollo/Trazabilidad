using CTZ.Modelo;
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

namespace CTZ.Vista.Responsabilitis
{
    public partial class Accesorios : MaterialForm
    {
        public Accesorios()
        {
            InitializeComponent();
            cargarDatos();
        }

        private void cargarDatos()
        {
            ConexionTrazabilidad conexion = new ConexionTrazabilidad();
            Dgv_Accesorios.DataSource = conexion.getDataTable("SELECT * FROM Accesorios");
        }
    }
}
