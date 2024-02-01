using CTZ.Controler.Estandard;
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

namespace CTZ.View.Estandard
{
    public partial class Estandars_SubMenu : MaterialForm
    {
        private C_Estandard controler;
        public Estandars_SubMenu()
        {
            controler = new C_Estandard();
            InitializeComponent();
        }

        private void Estandars_SubMenu_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Estandares' Puede moverla o quitarla según sea necesario.
            this.estandaresTableAdapter1.Fill(this.trazabilidadTestDataSet3.Estandares);

            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Estandares_Certificados' Puede moverla o quitarla según sea necesario.
            this.estandares_CertificadosTableAdapter.Fill(this.trazabilidadTestDataSet4.Estandares_Certificados);
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Estandares' Puede moverla o quitarla según sea necesario.
           // this.estandaresTableAdapter.Fill(this.trazabilidadTestDataSet4.Estandares);
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            AddStandar estandard = new AddStandar();
            estandard.Show();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DeleteStandard deleteEstandard = new DeleteStandard();
            deleteEstandard.Show();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            string kindOfSerch = "UpdateEstandard";
            SerchStandar estandard =  new SerchStandar(kindOfSerch);
            estandard.Show();
        }

        private void Dgv_Estandards_FilterStringChanged(object sender, EventArgs e)
        {
            this.estandaresBindingSource1.Filter = this.Dgv_Standards.FilterString;
        }

        private void Btn_SerchEST_Click(object sender, EventArgs e)
        {
            if (controler.checkIfEstandarExist(TxtBox_EST.Text))
            {
                Dgv_Standards.DataSource = controler.selectEstandardByEST(TxtBox_EST.Text);
            }
            else
            {
                MessageBox.Show("El estandard no existe ");
            }
        }

        private void Btn_CleanSerch_Click(object sender, EventArgs e)
        {
            Dgv_Standards.DataSource = estandaresBindingSource1;
        }

        private void Btn_SerchByEstandardName_Click(object sender, EventArgs e)
        {
            Dgv_Standards.DataSource = controler.selectByEstandard(TxtBox_EstandardName.Text);
        }

        private void Btn_Brand_Click(object sender, EventArgs e)
        {
            Dgv_Standards.DataSource = controler.selectByBrand(TxtBox_Brand.Text);
        }

        private void Btn_Add_Certificate_Click(object sender, EventArgs e)
        {
            string kindOfSerch = "AddCertificate";
            SerchStandar estandard = new SerchStandar(kindOfSerch);
            estandard.Show();
        }

        private void Dgv_Estandard_Certificate_FilterStringChanged(object sender, EventArgs e)
        {
            this.estandaresCertificadosBindingSource.Filter = this.Dgv_Standard_Certificate.FilterString;
        }

        private void Btn_Serch_Certificate_Click(object sender, EventArgs e)
        {
            if (controler.checkIfEstandarExist(TxtBox_Certificate_Standar.Text))
            {
                Dgv_Standard_Certificate.DataSource = controler.getStandarCertificate(TxtBox_Certificate_Standar.Text);
            }
            else
            {
                MessageBox.Show("El estandard no existe ");
            }
        }

        private void Btn_Clean_Standar_Certificate_Click(object sender, EventArgs e)
        {
            Dgv_Standard_Certificate.DataSource = estandaresCertificadosBindingSource;
            TxtBox_Certificate_Standar.Clear();
        }

        private void Btn_Reload_Data_Click(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet3.Estandares' Puede moverla o quitarla según sea necesario.
            this.estandaresTableAdapter1.Fill(this.trazabilidadTestDataSet3.Estandares);

            // TODO: esta línea de código carga datos en la tabla 'trazabilidadTestDataSet4.Estandares_Certificados' Puede moverla o quitarla según sea necesario.
            this.estandares_CertificadosTableAdapter.Fill(this.trazabilidadTestDataSet4.Estandares_Certificados);
        }
    }
}
