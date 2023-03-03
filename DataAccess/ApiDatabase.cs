using DataAccess.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{

    public class ApiDatabase : DbContext
    {
        public ApiDatabase()
        {
            Database.Connection.ConnectionString = "server=MSI;database=SolutionApi;Trusted_Connection=true;";
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<login> Logins { get; set; }
    }
}
