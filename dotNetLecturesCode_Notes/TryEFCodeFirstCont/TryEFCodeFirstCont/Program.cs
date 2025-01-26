using Microsoft.EntityFrameworkCore;
using TryEFCodeFirstCont.Context;
using TryEFCodeFirstCont.Models;

namespace TryEFCodeFirstCont
{
    internal class Program
    {
        static void Main(string[] args)
        {
           CompanyContext Db = new CompanyContext();
           //Department d1= new Department { DeptName="SD"};
           //Department d2= new Department { DeptName="UI"};
           //Department d3= new Department { DeptName="OS"};
           // Db.Departments.AddRange(d1, d2, d3);
           // Db.SaveChanges();

            Instructor i1 = new() {Name="Osama" ,Age=99,Salary=100_000,Email="w",DepartmentId=1,Address="Ism"};
            Db.Add(i1 );
            Db.SaveChanges();
            //DataAnnotation [validation] is workable with legacy ef6
            //with ef core => will ignore validation in this level 
            //performance facter 
            //where validation is done ???????
            //in Frontend => javascript
            //in MVC 
           

        }
    }
}
