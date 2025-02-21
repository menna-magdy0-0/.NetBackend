using Microsoft.AspNetCore.Mvc;

namespace testMVC.Controllers
{
    public class ServiceController : Controller
    {
        private readonly IDepartmentRepository deptRepo;

        public ServiceController(IDepartmentRepository deptRepo)
        {
            this.deptRepo = deptRepo;
        }


        public IActionResult Index()//[FromServices]IDepartmentRepository deptRepo)
        {
            ViewBag.Id=deptRepo.Id;
            return View("Index");
        }
    }
}
