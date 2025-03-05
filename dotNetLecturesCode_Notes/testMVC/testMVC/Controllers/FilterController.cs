using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace testMVC.Controllers
{
    //[HandelError]
    [Authorize]
    public class FilterController : Controller
    {
        //[HandelError]
        [AllowAnonymous]
        public IActionResult Index()
        {
            throw new Exception("Exception fr index");
        }
        //[HandelError]
        public IActionResult Index2()
        {
            throw new Exception("Exception fr index");
        }
    }
}
