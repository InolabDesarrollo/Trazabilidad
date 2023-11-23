using CTZ.View.Calibration;
using CTZ.View.Instruments.Assignment;
using CTZ.View.Instruments.Schedule;
using CTZ.View.Instruments.Trazability;
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

namespace CTZ.View.Instruments
{
    public partial class Instruments_Menu : MaterialForm

    {
        public Instruments_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Calibration_Click(object sender, EventArgs e)
        {
            SeeCalibrationRequest seeCalibrationRequest = new SeeCalibrationRequest();
            seeCalibrationRequest.Show();
        }

        private void Btn_Instruments_Click(object sender, EventArgs e)
        {
            Instruments_SubMenu menu = new Instruments_SubMenu();
            menu.Show();
            this.Close();
        }

        private void Btn_Schedule_Click(object sender, EventArgs e)
        {
            Schedule_SubMenu menu = new Schedule_SubMenu();
            menu.Show();
            this.Close();
        }

        private void Btn_Trazability_Click(object sender, EventArgs e)
        {
            Trazability_SubMenu menu = new Trazability_SubMenu();
            menu.Show();    
        }

        private void Btn_Assignment_Click(object sender, EventArgs e)
        {
            Assignment_SubMenu menu = new Assignment_SubMenu();
            menu.Show();
        }
    }
}
