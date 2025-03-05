using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace testMVC.Controllers
{
    public class ServiceController : Controller
    {
        //Service/add
        [HttpGet]
        public IActionResult add()
        {
            return Content("add Get");
        }
        [HttpPost]
        public IActionResult add(string ss)
        {
            return Content("add Post");
        }


        private readonly IDepartmentRepository deptRepo;
        //[Authorize]
        public IActionResult TestAuth()
        {
            if(User.Identity.IsAuthenticated==true)
            {
                Claim IDClaim =User.Claims
                    .FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

                Claim AddressClaim = User.Claims.FirstOrDefault(c => c.Type == "UserAddress");

                string id = IDClaim.Value;

                string name = User.Identity.Name;
                return Content($"welcome {name} \t {id}");
            }
            return Content("Ay haga");
        }



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
