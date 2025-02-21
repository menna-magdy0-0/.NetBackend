using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testMVC.Models;
using testMVC.Repository;
using testMVC.ViewModel;

namespace testMVC.Controllers
{
    public class EmployeeController : Controller
    {
        IDepartmentRepository DepartmentRepository;
        IEmployeeRepository EmployeeRepository;
       // ITIContext context = new ITIContext();
        public EmployeeController(IDepartmentRepository deptRepository,IEmployeeRepository empRepository) 
        {
            DepartmentRepository = deptRepository;// new DepartmentRepository();
            EmployeeRepository = empRepository;//new EmployeeRepository();
        }
        [HttpGet]
        public IActionResult New()
        {
            ViewData["DeptList"]=DepartmentRepository.GetAll();
            return View("New");
        }
        [HttpPost]
        public IActionResult SaveNew(Employee EmpFromRequest)
        {
            if (EmpFromRequest.Name != null && EmpFromRequest.Salary>=6000)
            {
                //save
                EmployeeRepository.Add(EmpFromRequest);
                EmployeeRepository.Save();
                return RedirectToAction("Index");
            }
            ViewData["DeptList"] = DepartmentRepository.GetAll();
            return View("New",EmpFromRequest);
        }

        public IActionResult Index()
        {
            return View("Index",EmployeeRepository.GetAll());
        }

        //Handle Link
        public IActionResult Edit(int id,string name)
        {
            Employee EmpModel=EmployeeRepository.GetById(id);
            List<Department> DepartmentList = DepartmentRepository.GetAll();
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
                Employee EmpFromDB = EmployeeRepository.GetById(id);
                EmpFromDB.Address= EmpFromRequest.Address;
                EmpFromDB.Salary= EmpFromRequest.Salary;
                EmpFromDB.JobTitle= EmpFromRequest.JobTitle;
                EmpFromDB.ImageURL= EmpFromRequest.ImageURL;
                EmpFromDB.DepartmentId= EmpFromRequest.DepartmentId;
                EmpFromDB.Id=EmpFromRequest.Id;
                EmployeeRepository.Update(EmpFromDB);
                EmployeeRepository.Save();
                return RedirectToAction("Index");

            }
            EmpFromRequest.DeptList=DepartmentRepository.GetAll();
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
            Employee EmpModel = EmployeeRepository.GetById(id);
            if (EmpModel == null)
            {
                return NotFound(); // Avoid passing null to the view
            }
            //ViewData.Model = EmpModel;
            return View("Details", EmpModel);
        }
        public ActionResult DetailsVM(int id)
        {
            Employee empModel=EmployeeRepository.GetById(id);
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
