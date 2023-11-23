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

namespace CTZ.View.Instruments.Schedule
{
    public partial class Schedule_SubMenu : MaterialForm
    {
        public Schedule_SubMenu()
        {
            InitializeComponent();
        }

        private void Btn_CalibrationShedule_Click(object sender, EventArgs e)
        {
            Report report = new Report("Calendario_Instrumentos_General");
            report.Show();

        }

    }
}
