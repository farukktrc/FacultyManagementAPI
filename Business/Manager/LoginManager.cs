using Business.Interface;
using DataAccess;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class LoginManager : ILoginManager
    {
        public void CreateLogin(login user)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                db.Logins.Add(user);
                db.SaveChanges();
            }
        }

        public void DeleteLogin(int id)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                var deletedLogin = db.Logins.Find(id);
                db.Logins.Remove(deletedLogin);
                db.SaveChanges();
            }
        }

        public bool EntryController(login EntryInformations)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                foreach (var item in db.Logins.ToList())
                {
                    if (item.username == EntryInformations.username && item.password == EntryInformations.password)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public void UpdateLogin(login user)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                db.Entry(user).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
