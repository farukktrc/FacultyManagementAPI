using Business.Manager;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class LoginController : ApiController
    {
        LoginManager manager;
        
        [HttpPut]
        public void CreateLogin(login user)
        {
            manager = new LoginManager();
            manager.CreateLogin(user);
           
        }
        [HttpPut]
        public void UpdateLogin(login user)
        {
            manager = new LoginManager();
            manager.UpdateLogin(user);
        }
        public void DeleteLogin(int id)
        {
            manager=new LoginManager();
            manager.DeleteLogin(id);
        }
        [HttpPost]
        public bool EntryController(login EntryInformations)
        {
            manager = new LoginManager();
            bool isTrue = manager.EntryController(EntryInformations);
            return isTrue;
        }
    }
}
