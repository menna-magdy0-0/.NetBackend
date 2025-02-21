using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testMVC.Models;
using testMVC.Repository;

namespace testMVC.Controllers
{
    public class DepartmentController : Controller
    {
        //ITIContext context = new ITIContext();
        IDepartmentRepository DepartmentRepository;
        public DepartmentController(IDepartmentRepository deptRepository)//inject 
        {
            DepartmentRepository = deptRepository;//new DepartmentRepository();
        }
        public IActionResult Index()
        {
            List<Department> departmentList = DepartmentRepository.GetAll();
            //context.Departments
            //.Include(d=>d.Employees).ToList();//to list for immediate execution and it is lazy loading can't get related table data of employee and to avoid it we use Include keyword
            return View("Index",departmentList);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }
        //Department/SaveAdd?Name=Sd&ManagerName=Ahmed
        //Get Handel
        //Post Handel
        [HttpPost]//Filtter //limit to post only 
        public IActionResult SaveAdd(Department newDeptFromRequest)
        {
            // print newDept.Name  ?? ""
            // print newDept.ManagerName ?? "Menna2"
            if(newDeptFromRequest.Name!=null)
            {
                DepartmentRepository.Add(newDeptFromRequest);
                DepartmentRepository.Save();
                //context.Departments.Add(newDeptFromRequest);
                //context.SaveChanges();
                //return View("Index");
                //call action from another action 
                return RedirectToAction("Index");
            }
            return View("Add",newDeptFromRequest);//Model Department 
            //if i add data in textbox and the other i didn't return the filled boxes 
        }

    }
}
