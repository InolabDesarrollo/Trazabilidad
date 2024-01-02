using CTZ.Model.Browser.Interfaces;
using CTZ.Modelo;
using CTZ.Modelo.Browser;
using CTZ.Vista.Responsabilitis;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_User
    {
        private IUserRepository userRepository;
        public C_User(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public DataTable loginUser(string user, string password)
        {
            return userRepository.loginUser(user, password);
        }

        public bool validateUser(string user, string password)
        {
            return userRepository.validateUser(user, password);
        }

        public DataTable getEngineers()
        {
            return userRepository.getEngineers();
        }

        public string serchEmailEngineer(string name)
        {
            DataTable engineers = getEngineers();
            string email = findEmailByName(engineers, name);
            return email;
        }

        public string findEmailByName(DataTable engineers, string name)
        {
            string emailEngineer = "";
            for (int i = 0; i < engineers.Rows.Count; i++)
            {
                string nameEngineer = engineers.Rows[i]["Nombre"].ToString() + " " + engineers.Rows[i]["Apellidos"].ToString();
                if (nameEngineer.Equals(name))
                {
                    emailEngineer = engineers.Rows[i]["Mail"].ToString();
                    break;
                }
            }
            return emailEngineer;
        }

        public bool checkIfExistEngineer(string engineerName)
        {
            return userRepository.checkIfExistEngineer(engineerName);
        }


    }
}
