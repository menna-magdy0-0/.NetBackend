using Microsoft.AspNetCore.Mvc;

namespace testMVC.Controllers
{
    public class StateController : Controller
    {
        public IActionResult SetSession(string name)
        {
            //logic 
            HttpContext.Session.SetString("Name", name);
            //logic
            HttpContext.Session.SetInt32("Age", 25);
            return Content("Session is set");
        }
        public IActionResult GetSession()
        {
            //logic
            var name1 = HttpContext.Session.GetString("Name");
            var age = HttpContext.Session.GetInt32("Age");
            return Content(name1 + " " + age);
        }
        public IActionResult SetCookie()
        {
            CookieOptions options = new CookieOptions();
            options.Expires = DateTime.Now.AddDays(1);
            //logic
            //session cookie
            HttpContext.Response.Cookies.Append("Name", "Ahmed");
            //presistent cookie
            HttpContext.Response.Cookies.Append("Age", "25");
            return Content("Cookie is set");


        }
        public IActionResult GetCookie()
        {
            var name1 = HttpContext.Request.Cookies["Name"];
            var age = HttpContext.Request.Cookies["Age"];
            return Content(name1 + " " + age);
        }
    }
}
