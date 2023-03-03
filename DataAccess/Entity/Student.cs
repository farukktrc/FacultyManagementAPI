using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Student:Base
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public string Department { get; set; }
        
    }
}
