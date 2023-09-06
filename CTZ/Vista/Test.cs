using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
using MaterialSkin;
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
    public partial class Test : MaterialForm 
    {
        readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Test()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            ConexionTrazabilidad conexion = new ConexionTrazabilidad();
            Dgv_Instrumentos.DataSource = conexion.getDataTable("SELECT * FROM TEST;");
        }

    }
}
