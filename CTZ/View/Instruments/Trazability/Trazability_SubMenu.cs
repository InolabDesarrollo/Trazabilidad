using CTZ.Vista.Certificates;
using CTZ.Vista.Traceability;
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

namespace CTZ.View.Instruments.Trazability
{
    public partial class Trazability_SubMenu : MaterialForm
    {
        public Trazability_SubMenu()
        {
            InitializeComponent();

        }

        private void Btn_Serch_Traceability_Click(object sender, EventArgs e)
        {
            SerchTraceabilityLetter traceabilityLetter = new SerchTraceabilityLetter();
            traceabilityLetter.Show();
        }

        private void Btn_AddTraceability_Click(object sender, EventArgs e)
        {
            SerchCertificate serchCertificate = new SerchCertificate();
            serchCertificate.Show();
        }
    }
}
