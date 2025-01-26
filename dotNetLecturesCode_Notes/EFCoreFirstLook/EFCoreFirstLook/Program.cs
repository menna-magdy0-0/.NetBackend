using EFCoreFirstLook.Entities;
using EFCoreFirstLook.Model;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.Arm;

namespace EFCoreFirstLook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CompanyContext Db = new CompanyContext();
            #region EF V01
            ////EF Database Creation Strategy 
            ////create Db for First Time ONLY
            //Db.Database.EnsureDeleted();//applicable for deelopment only //Db.Database.DropCreateDatabaseAlways();
            //Db.Database.EnsureCreated();//LegacyEF6 Db.Database.CreateIfNotExists();

            ////Employee e1= new Employee() {Name="Menna", Age = 25, Salary = 10000 };
            //Department d1=new Department() { DeptName = "SD" };
            ////Add Employee object in local storage
            ////Db.Employees.Add(e1);
            //Db.Departments.Add(d1);
            ////Affect to database
            //Db.SaveChanges(); 
            #endregion

            #region EF V02
            //Db.Database.EnsureDeleted();
            //Db.Database.EnsureCreated();
            //Department d1 = new Department { DeptName = "SD" };
            //Employee e1 = new Employee { Name = "Khaled", Salary = 20000, Age = 22, DepartmentId = 1 };
            //Employee e2=new Employee { Name = "Mohamed", Salary = 10000, Age = 25, Department = d1};
            //Db.Departments.Add(d1);
            //Db.Employees.Add(e1);
            //Db.SaveChanges();
            #endregion

            #region EF V03
            //Db.Database.EnsureDeleted();
            Db.Database.EnsureCreated();

            #region Add Departments
            //Department d1 = new Department { DeptName = "SD" };
            //Department d2 = new Department { DeptName = "UI" };
            //Department d3 = new Department { DeptName = "OS" };
            ////1- applicable in legacy EF6 + EF Core
            //Db.Departments.Add(d1);
            ////2- ef core ONLY
            //Db.Add(d2);
            ////3- Both EF6 + EF Core
            //Db.Entry(d3).State = Microsoft.EntityFrameworkCore.EntityState.Added;
            //Db.SaveChanges();
            #endregion

            #region Add Employees
            //connect first to DB to get Department object
            //var d1 = Db.Departments.First();
            //Employee e1 = new Employee { Name = "Yossef", Age = 22, Salary = 1234, Department = d1 };
            //Db.Add(e1);
            //Db.SaveChanges();


            //Employee e2=new Employee { Name = "Hala", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Db.Add(e2);
            //Db.SaveChanges();

            //Employee e3 = new Employee { Name = "Hala", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Employee e4 = new Employee { Name = "Sara", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Employee e5 = new Employee { Name = "Ali", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Employee e6 = new Employee { Name = "Ahmed", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Employee e7 = new Employee { Name = "Osama", Age = 22, Salary = 5000, DepartmentId = 2 };
            //Db.Employees.AddRange(new Employee[] {e3,e4,e5,e6,e7});
            //Db.SaveChanges();
            #endregion

            #region GetAllEmployees
            //var q1=from item in Db.Employees
            //         select item;
            //var q2=(from item in Db.Employees
            //       select item).FirstOrDefault();
            //var q3 = Db.Employees.Where(ww => ww.Age > 22);
            //Eager loading
            //var q4 = Db.Employees.Include(ww=>ww.Department).Where(ww => ww.Id > 1);
            //foreach (var item in q4)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(q2);
            #endregion

            #region Update Employee
            ////catch to employee
            //var emp=Db.Employees.Find(1);
            ////Console.WriteLine(emp);
            //emp.Name = "Ibraheem";
            //Employee e2 = new Employee { Id=10,Name = "Yossef", Age = 2, Salary = 20000};
            //Db.Update(e2 );
            //Db.SaveChanges();

            #endregion

            #region Delete
            //Catch to delete
            //var emp1=Db.Employees.SingleOrDefault(ww=>ww.Id==3);
            //Db.Employees.Remove(emp1);
            //Db.SaveChanges();
            #endregion


            #endregion
        }
    }
}
