using CTZ.Controlador;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Vista.Responsabilitis
{
    
    public class Engineer
    {
        C_Usuario controler;
        DataTable engineers;
        public Engineer() {
            controler = new C_Usuario();
            engineers= controler.getEngineers();
        }

        public DataTable getEngineers()
        {
            return engineers;
        }

        public string serchEmailEngineer(string name)
        {
            string emailEngineer = "";
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string nameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                if (nameEngineer.Equals(name))
                {
                    emailEngineer = engineers.Rows[i]["Mail"].ToString();
                }
            }
            return emailEngineer;
        }
    }
}
