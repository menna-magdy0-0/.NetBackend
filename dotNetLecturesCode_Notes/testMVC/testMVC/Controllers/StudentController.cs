using Microsoft.AspNetCore.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class StudentController : Controller
    {
        //Student/ShowAll
        public IActionResult ShowAll()
        {
            StudentBL studentBL = new StudentBL();
            List<Student> StudentListModel = studentBL.GetAll();
            return View("ShowAll",StudentListModel);//model list<student>
        }
        public IActionResult Details(int id)
        {
            StudentBL studentBL = new StudentBL();
            Student studentModel = studentBL.GetById(id);
            return View("ShowDetails", studentModel);//View ShowDetails == Model Student
        }
    }
}
