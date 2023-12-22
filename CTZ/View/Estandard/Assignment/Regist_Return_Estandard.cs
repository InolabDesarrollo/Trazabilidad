using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace CTZ.View.Estandard.Assignment
{
    public partial class Regist_Return_Estandard : MaterialForm
    {
        public Regist_Return_Estandard()
        {
            InitializeComponent();
        }

        private void Regist_Return_Estandard_Load(object sender, EventArgs e)
        {
            HttpContext.Current.Session["FirmaBase64"] = "test";
        }
    }
}
