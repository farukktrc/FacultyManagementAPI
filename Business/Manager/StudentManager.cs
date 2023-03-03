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
    public class StudentManager : IStudentManager
    {
        public List<Student> BringStudentList()
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                List<Student> students =db.Students.ToList();
                return students;
            }
        }

        public void CreateStudent(Student student)
        {
            using (ApiDatabase db = new ApiDatabase())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int id)
        {
            using (ApiDatabase db=new ApiDatabase())
            {
                var deletedStudent = db.Students.Find(id);
                db.Students.Remove(deletedStudent);
                db.SaveChanges();
            }
        }

        public void UpdateStudent(Student student)
        {
            using(ApiDatabase db=new ApiDatabase())
            {
                db.Entry(student).State=EntityState.Modified;
                db.SaveChanges();
            }
        }
    }
}
    
