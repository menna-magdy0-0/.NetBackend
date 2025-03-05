using Microsoft.AspNetCore.Authorization;
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
        IEmployeeRepository EmployeeRepository;
        public DepartmentController(IDepartmentRepository deptRepository, IEmployeeRepository employeeRepository)//inject 
        {
            DepartmentRepository = deptRepository;//new DepartmentRepository();
            EmployeeRepository = employeeRepository;
        }


        public IActionResult DeptEmps()
        {
            return View("DeptEmps", DepartmentRepository.GetAll());//list <department>
        }

        //Department/GetEmpsDeptById?deptId=1
        public IActionResult GetEmpsDeptById(int deptId)
        {
            List<Employee> empList = EmployeeRepository.GetByDeptId(deptId);
            return Json(empList);
        }



        [Authorize]
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
