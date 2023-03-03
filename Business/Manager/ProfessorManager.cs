using Business.Interface;
using DataAccess;
using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Manager
{
    public class ProfessorManager : IProfessorManagercs
    {
        public List<Professor> BringProfessorsList()
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                List<Professor> professors = db.Professors.ToList();
                return professors;
            }
        }

        public void CreateProfessor(Professor professor)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                db.Professors.Add(professor);
                db.SaveChanges();
            }
        }

        public void DeleteProfessor(int id)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                var deletedProfessor = db.Professors.Find(id);
                db.Professors.Remove(deletedProfessor);
                db.SaveChanges();
            }
        }

        public void UpdateProfessor(Professor professor)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                db.Entry(professor).State = EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
