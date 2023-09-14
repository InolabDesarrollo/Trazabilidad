using CTZ.Modelo.Documentacion;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CTZ.Vista
{
    public partial class MenuInstrumentos : Form
    {
        Instruments instrument = new Instruments();
        public MenuInstrumentos()
        {
            InitializeComponent();

        }
        private void Btn_See_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_See);
        }

        private void Btn_Regist_Click(object sender, EventArgs e)
        {
            showMenu(Pnl_Regist);
        }

        private void showMenu(System.Windows.Forms.Panel panel)
        {
            if (!panel.Visible)
            {
                panel.Visible = true;
            }
            else
            {
                panel.Visible = false;
            }
        }

        private void Btn_All_Click(object sender, EventArgs e)
        {
            Dgv_Instrumentos.DataSource = instrument.getAllRegister();         
        }

        private void Btn_Actives_Click(object sender, EventArgs e)
        {
            Dgv_Instrumentos.DataSource = instrument.getActiveRegist();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddInstrument instrument = new AddInstrument();
            instrument.Show();
        }

        private void BtnDelete_Instruments_Click(object sender, EventArgs e)
        {
            DeleteInstrument deleteInstrument = new DeleteInstrument();
            deleteInstrument.Show();
        }

        private void BtnUpdate_Instrument_Click(object sender, EventArgs e)
        {
            SerchInstrument serchInstrument = new SerchInstrument();    
            serchInstrument.Show();
        }
        private void Dgv_Instrumentos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int a = 10;
        }

        private void Dgv_Instrumentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 1:
                    string idSql = Dgv_Instrumentos[0, e.RowIndex].Value.ToString();
                    string idInstrument = Dgv_Instrumentos[1,e.RowIndex].Value.ToString();
                    UpdateInstrument instrument = new UpdateInstrument(idInstrument, idSql);
                    instrument.Show();
                    break;
                case 2:
                    int c = 0;
                    break;
            }
        }
    }
}
