using CTZ.Controlador;
using CTZ.Modelo;
using CTZ.Modelo.Documentacion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTZ.Vista.Responsabilitis
{
    public class Instruments
    {
        public string id;
        public  string instrument;
        public string brand;
        public  string numberOfSerie;
        public  string ubication;
        public  string observation;
        public  string status;
        public string model;

        C_Instruments controler = new C_Instruments();

        public Instruments() { }

        public Instruments(string id,string instrument, string brand,string model, string numberOfSerie,string ubication,
            string observation, string status)
        {
            this.id = id;
            this.instrument = instrument;
            this.brand = brand;
            this.model = model;
            this.numberOfSerie = numberOfSerie;
            this.ubication = ubication;
            this.observation = observation;
            this.status = status;
        }

        public DataTable getActiveRegist()
        {
            return controler.consultarRegistrosActivos();
        }

        public DataTable getAllRegister()
        {
            return controler.consultarTodosLosRegistros();
        }

        public void addNewInstrument()
        {
            Instruments instruments = new Instruments();
            instruments.id = id;    
            instruments.instrument = instrument;
            instruments.brand = brand;
            instruments.model = model;
            instruments.numberOfSerie = numberOfSerie;
            instruments.ubication = ubication;
            instruments.observation = observation;  
            instruments.status = status;

            controler.addNewInstrument(instruments);
        }

        public void deleteInstrument(string idInstrument)
        {
            controler.deleteInstrument(idInstrument);
        }

        public void updateInstrument()
        {
            Instruments instruments = new Instruments();

            instruments.id = id;
            instruments.instrument = instrument;
            instruments.brand = brand;
            instruments.model = model;
            instruments.numberOfSerie = numberOfSerie;
            instruments.ubication = ubication;
            instruments.observation = observation;
            instruments.status = status;
            controler.updateInstrument(instruments);
        }
        public bool serchInstrument(string id)
        {
            return controler.serchInstrumen(id);
        }
        public DataTable selectAllFromInstrument(string equino)
        {
            return controler.selectAllFromInstrument(equino);
        }

        public DataTable selectAllRegistAndCertificates()
        {
            return controler.selectAllRegistAndCertificates();
        }



    }
}
