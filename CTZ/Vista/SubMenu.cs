using CTZ.Vista.Responsabilitis;
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
    public partial class SubMenu : MaterialForm
    {
        public SubMenu()
        {
            InitializeComponent();
        }

        private void Btn_Accesorios_Click(object sender, EventArgs e)
        {
            MenuAccesorios accesorios = new MenuAccesorios();
            accesorios.Show();
        }

        private void Btn_Herramientas_Click(object sender, EventArgs e)
        {
            MenuHerramientas menuHerramientas = new MenuHerramientas();
            menuHerramientas.Show();
        }

        private void Btn_DataLogger_Click(object sender, EventArgs e)
        {
            MenuDataLogger dataLogger = new MenuDataLogger();
            dataLogger.Show();
        }

        private void Btn_Estandares_Click(object sender, EventArgs e)
        {
            MenuEstandares estandares = new MenuEstandares();
            estandares.Show();
        }

        private void Btn_Instrumentos_Click(object sender, EventArgs e)
        {
            MenuInstrumentos instrumentos = new MenuInstrumentos();
            instrumentos.Show();    
        }
    }
}
