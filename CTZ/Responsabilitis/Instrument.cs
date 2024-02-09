using CTZ.Controlador;
using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public class Instrument
    {
        public string id;
        public  string instrument;
        public string brand;
        public  string numberOfSerie;
        public  string ubication;
        public  string observation;
        public  string status;
        public string model;
        public string magnitude;
        public string range;
        public string accessories;
        public string use;
        public string meanInterval;

        C_Instruments controler = new C_Instruments();

        public Instrument() { }

        public bool serchInstrument(string id)
        {
            return controler.serchInstrument(id);
        }
        public DataTable selectAllFromInstrument(string equino)
        {
            return controler.selectAllFromInstrument(equino);
        }

        public void deleteEquinoFromComboBox(MaterialComboBox comboBox)
        {
            try
            {
                string equino = comboBox.SelectedItem.ToString();
                int index = comboBox.FindString(equino);
                comboBox.Items.RemoveAt(index);
                MessageBox.Show("Equino " + equino + " Eliminado");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
                MessageBox.Show("No seleccionaste un Equino");
            }
        }

    }
}
