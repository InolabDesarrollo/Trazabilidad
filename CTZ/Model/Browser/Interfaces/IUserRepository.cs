using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTZ.Model.Browser.Interfaces
{
    public interface IUserRepository
    {
        DataTable loginUser(string user, string password);
        DataTable getEngineers();

        bool validateUser(string user, string password);

        bool checkIfExistEngineer(string engineerName);

    }
}
