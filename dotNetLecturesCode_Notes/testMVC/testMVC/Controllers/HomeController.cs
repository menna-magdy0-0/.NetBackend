using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class HomeController : Controller
    {
        //create method to be called in url 
        //1- Method must be public 
        //2- Can't be static 
        //3- Can't be overload 
        //Home/ShowMsg
        //public string ShowMsg()
        //{
        //    return "Hello World";
        //}
        public ContentResult ShowMsg()
        {
            //declare 
            ContentResult result = new ContentResult();
            //initial 
            result.Content = "Hello World";
            //return
            return result;
        }
        //Home/ShowView
        public ViewResult ShowView()
        {
            //logic
            ViewResult result = new ViewResult();
            //declare 

            //initialize 
            result.ViewName = "View1";
            //return
            return result;
        }
        //Home/ShowMix?id=1&name=ahmed
        public IActionResult ShowMix(int id,string name)
        {

            if (id%2==0)
            {

                ////logic
                //ViewResult result = new ViewResult();
                ////declare 

                ////initialize 
                //result.ViewName = "View1";
                ////return
                //return result;

                return View("View1");
            }
            else
            {
                ////declare 
                //ContentResult result = new ContentResult();
                ////initial 
                //result.Content = "Hello World";
                ////return
                //return result;
                return Content("Hello");
            }
        }
        //Action type 
        //string --> ContentResult
        //view --> ViewResult 
        //Json --> JSonResult
        //File --> FileResult
        //notfound -->NotFoundResult
        //unauthorized -->UnAuthorizedResult


        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
