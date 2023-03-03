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
   
    public class StudentController : ApiController
    {
        StudentManager manager;

        [HttpGet]
        public List<Student> GetStudents()
        {
            manager = new StudentManager();
            return manager.BringStudentList();
        }

        [HttpPost]
        public void CreateStudent(Student student)
        {
            manager = new StudentManager();
            manager.CreateStudent(student);

        }
        public void DeleteStudent(int id)
        {
            manager=new StudentManager();
            manager.DeleteStudent(id);
        }
        [HttpPost]
        public void UpdateStudent(Student student)
        {
            manager = new StudentManager();
            manager.UpdateStudent(student);

        }
    }
}
