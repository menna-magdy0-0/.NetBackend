using Microsoft.AspNetCore.Mvc;
using testMVC.Models;

namespace testMVC.Controllers
{
    public class BindController : Controller
    {
        //Request HTML (data)
        //Binding Primitive (int,string ...)
        //Bind/TestPrmitive?name=ahmed&age=12&id=10&color=red&color=blue
        //Bind/TestPrmitive/10?name=ahmed&age=12  [RouteValues]
        //<form action= "/Bind/TestPrmitive" method="get">
        //    <input type="text" name="name">
        //    <input type="text" name="age">
        public IActionResult TestPrmitive(string name,int age,int id,string[] color)
        {
            return Content($"{name}\t {age}");
        }

        //Bind Collection
        //Bind/TestDic?name=alaa&Phones["Ahmed"]=123&Phones["chris"]=456
        public IActionResult TestDic(Dictionary<string, string> Phones, string name)
        {
            return Content("OK");
        }
        //common used
        //Bind/TestObj?id=1&name=Sd&ManagerName=Khaled
        public IActionResult testObj(Department deptObj)
        {
            return Content("Obj");
        }
    }
}
