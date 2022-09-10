using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StudentResources.Models;

namespace StudentResources.Controllers
{
    public class StudentController : Controller
    {
        List<StudentModel> student = new List<StudentModel>()
        {
               new StudentModel {StudentId = 0012, FirstName ="Sushil", LastName="Shakya", Email="email@gmail.com", Address="abc st nsw", Contact = "00123212"}
              
        };
        public ActionResult Index()
        {
            return View(student);
        }

        [HttpGet]
        public ActionResult Detail(int id)
        {
            StudentModel per = student.Find(res => res.StudentId == id);
            return View(per);
        }
    }
}