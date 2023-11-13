using CTZ.Controlador;
using CTZ.Controler.Trazabilidad;
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

namespace CTZ.View.Calibration
{
    public partial class CalibrationRequest : MaterialForm
    {
        Instruments instrument;
        C_Laboratories controller;
        private string equinoInstrument;
        private int idInstrument;
        private static List<int> idInstruments;
        private DataTable laboratories;

        public CalibrationRequest()
        {
            InitializeComponent();
            instrument = new Instruments();
            idInstruments = new List<int>();
            fillMaterialComboBoxLaboratories();
        }

        private void fillMaterialComboBoxLaboratories()
        {
            controller = new C_Laboratories();
            laboratories = controller.selectLaboratories();

            for (int i = 0; i < laboratories.Rows.Count; i++)
            {
                ComboBox_Laboratory.Items.Add(laboratories.Rows[i]["Nombre_Abreviado"].ToString());
            }
        }

        private void Btn_Add_Equino_Click(object sender, EventArgs e)
        {
            instrument = new Instruments();
            if (instrument.serchInstrument(TxtBox_Instrumenst.Text))
            {
                DataTable instrumentInformation = instrument.selectAllFromInstrument(TxtBox_Instrumenst.Text);
                equinoInstrument = instrumentInformation.Rows[0]["ID_Instrumentos"].ToString();
                idInstrument = Convert.ToInt32(instrumentInformation.Rows[0]["ID"].ToString());
                idInstruments.Add(idInstrument);
                addEquino();
            }
            else
            {
                MessageBox.Show("Instrumento No existe");
                TxtBox_Instrumenst.Clear();
            }
        }

        private void addEquino()
        {
            ComboBox_Instruments.Items.Add(equinoInstrument);        
            MessageBox.Show("Se agrego Equino " + equinoInstrument);
            TxtBox_Instrumenst.Clear();
        }

        private void Btn_Delete_Instrument_Click(object sender, EventArgs e)
        {
            instrument.deleteEquinoFromComboBox(ComboBox_Instruments);
        }

        private void Btn_MakeRequest_Click(object sender, EventArgs e)
        {
            string shorNameLaboratory = ComboBox_Laboratory.SelectedItem.ToString();
            int idLaboratory;
            for (int i = 0; i < laboratories.Rows.Count; i++)
            {
                if (laboratories.Rows[i]["Nombre_Abreviado"].ToString().Equals(shorNameLaboratory) )
                {
                    idLaboratory = Convert.ToInt32(laboratories.Rows[i]["Nombre_Abreviado"].ToString());
                }
            }
        }
    }
}
