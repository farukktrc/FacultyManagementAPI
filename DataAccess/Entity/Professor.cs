using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Professor:Base
    {
        public int ProfessorId { get; set; }
        public string ProfessorName { get; set; }   
        public string Department { get; set; }
        public double Salary { get; set; }
    }
}
