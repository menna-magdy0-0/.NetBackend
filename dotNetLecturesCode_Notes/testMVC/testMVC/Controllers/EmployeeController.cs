using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testMVC.Models;
using testMVC.ViewModel;

namespace testMVC.Controllers
{
    public class EmployeeController : Controller
    {
        ITIContext context = new ITIContext();
        public EmployeeController() { }
        [HttpGet]
        public IActionResult New()
        {
            ViewData["DeptList"]=context.Departments.ToList();
            return View("New");
        }
        [HttpPost]
        public IActionResult SaveNew(Employee EmpFromRequest)
        {
            if (EmpFromRequest.Name != null && EmpFromRequest.Salary>=6000)
            {
                //save
                context.Employees.Add(EmpFromRequest);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewData["DeptList"] = context.Departments.ToList();
            return View("New",EmpFromRequest);
        }

        public IActionResult Index()
        {
            return View("Index",context.Employees.ToList());
        }

        //Handle Link
        public IActionResult Edit(int id,string name)
        {
            Employee EmpModel=context.Employees.FirstOrDefault(x => x.Id == id);
            List<Department> DepartmentList = context.Departments.ToList();
            //create view mode mapping
            EmpWithDeptListViewModel EmpViewModel=new EmpWithDeptListViewModel();
            EmpViewModel.Id = EmpModel.Id;
            EmpViewModel.Name = EmpModel.Name;
            EmpViewModel.Address = EmpModel.Address;
            EmpViewModel.ImageURL = EmpModel.ImageURL;
            EmpViewModel.JobTitle = EmpModel.JobTitle;
            EmpViewModel.Salary = EmpModel.Salary;
            EmpViewModel.DepartmentId = EmpModel.DepartmentId;
            EmpViewModel.DeptList = DepartmentList;
            return View("Edit", EmpViewModel);//Model EmpDeptListViewModel
        }
        [HttpPost]
        public IActionResult SaveEdit(EmpWithDeptListViewModel EmpFromRequest,int id)
        {
            if (EmpFromRequest.Name != null)
            {
                Employee EmpFromDB= context.Employees.FirstOrDefault(e => e.Id == id);
                EmpFromDB.Address= EmpFromRequest.Address;
                EmpFromDB.Salary= EmpFromRequest.Salary;
                EmpFromDB.JobTitle= EmpFromRequest.JobTitle;
                EmpFromDB.ImageURL= EmpFromRequest.ImageURL;
                EmpFromDB.DepartmentId= EmpFromRequest.DepartmentId;
                context.SaveChanges();
                return RedirectToAction("Index");

            }
            EmpFromRequest.DeptList=context.Departments.ToList();
            return View("Edit",EmpFromRequest);
        }



        public IActionResult Details(int id)
        {
            string msg = "Hello From Action";
            int temp = 50;
            List<string> branshes = new List<string>();
            branshes.Add("Assiut");
            branshes.Add("Alex");
            branshes.Add("Cairo");
            //Additional Info send to view from Action
            ViewData["Msg"] = msg;
            ViewData["Temp"] = temp;
            ViewData["brch"] = branshes;
            ViewBag.Color = "Red";
            //Employee EmpModel = context.Employees.FirstOrDefault(e => e.Id == id);
            Employee EmpModel = context.Employees.FirstOrDefault(e=>e.Id==id);
            if (EmpModel == null)
            {
                return NotFound(); // Avoid passing null to the view
            }
            //ViewData.Model = EmpModel;
            return View("Details", EmpModel);
        }
        public ActionResult DetailsVM(int id)
        {
            Employee empModel=context.Employees
                .Include(d=>d.Department)
                .FirstOrDefault(e=>e.Id == id);
            List<string> branshes = new List<string>();
            branshes.Add("Assiut");
            branshes.Add("Alex");
            branshes.Add("Cairo");

            //declare viewmodel
            EmpDeptColorTempMsgBrchViewModel EmpVM=
                new EmpDeptColorTempMsgBrchViewModel();
            //Mapping
            EmpVM.EmpName = empModel.Name;
            EmpVM.DeptName = empModel.Department.Name;
            EmpVM.Color = "Red";
            EmpVM.Temp = 12;
            EmpVM.Msg = "Hello From VM";
            EmpVM.Branches= branshes;


            return View("DetailsVM", EmpVM);//EmpDeptColorTempMsgBrchViewModel
        }
    }
}
