using CTZ.Modelo;
using CTZ.Modelo.Browser;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Controlador
{
    public class C_Usuario
    {
        private readonly UserRepository repository;

        public C_Usuario(UserRepository repository)
        {
            this.repository = repository;
        }
        public C_Usuario()
        {
            repository = new UserRepository();
        }
        public DataTable loginUser(string user, string password)
        {
            return repository.loginUser(user, password);
        }

        public bool validateUser(string user, string password)
        {
            return repository.validateUser(user, password);
        }

        public DataTable getEngineers()
        {
            return repository.getEngineers();
        }

        public bool checkIfExistEngineer(string engineerName)
        {
            return repository.checkIfExistEngineer(engineerName);
        }
    }
}
