using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface ILoginManager
    {
        bool EntryController(login EntryInformations);
        void CreateLogin(login user);
        void UpdateLogin(login user);
        void DeleteLogin(int id);
    }
}
