using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interface
{
    public interface IProfessorManagercs
    {
        List<Professor> BringProfessorsList();
        void CreateProfessor(Professor professor);
        void UpdateProfessor(Professor professor);
        void DeleteProfessor(int id);
    }
}
