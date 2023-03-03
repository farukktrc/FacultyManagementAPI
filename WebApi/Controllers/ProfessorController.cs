using Business.Manager;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class ProfessorController : ApiController
    {
        ProfessorManager manager;

        [HttpGet]
        public List<Professor> GetProfessors()
        {
            manager = new ProfessorManager();
            return manager.BringProfessorsList();
        }

        [HttpPost]
        public void CreateProfessor(Professor professor)
        {
            manager = new ProfessorManager();
            manager.CreateProfessor(professor);
            
        }

        
        public void DeleteProfessor(int id)
        {
            manager = new ProfessorManager();
            manager.DeleteProfessor(id);
        }
        [HttpPut]
        public void UpdateProfessor(Professor professor)
        {
            manager = new ProfessorManager();
            manager.UpdateProfessor(professor);
        }

    }
}
