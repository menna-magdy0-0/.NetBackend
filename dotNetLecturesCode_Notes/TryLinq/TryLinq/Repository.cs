using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLinq
{
    public class Repository
    {
        public static List<Employee> GetEmployee()
        {
            return new List<Employee>
            {
                new Employee{Id=1,Name="Marioma",Age=22, Salary=1234,DeptId=1},
                new Employee{Id=2,Name="Omar",Age=23, Salary=5234,DeptId=2},
                new Employee{Id=3,Name="Khaled",Age=24, Salary=6234,DeptId=3},
                new Employee{Id=4,Name="Sara",Age=25, Salary=2234,DeptId=3},
                new Employee{Id=5,Name="Menna",Age=21, Salary=1234,DeptId=3},
                new Employee{Id=6,Name="Hani",Age=26, Salary=4234,DeptId=1},
                new Employee{Id=7,Name="Farah",Age=27, Salary=6234,DeptId=1},
                new Employee{Id=8,Name="Nada",Age=23, Salary=7234,DeptId=2},
                new Employee{Id=9,Name="Israa",Age=27, Salary=8234,DeptId=2},
                new Employee{Id=10,Name="Yossef",Age=28, Salary=9234,DeptId=1}
            };
        }
        public static List<Department> GetDepartments ()
        {
            return new List<Department>
            {
                new Department{DeptId=1,DeptName="SD"},
                new Department{DeptId=2,DeptName="UI"},
                new Department{DeptId=3,DeptName="OS"},
                new Department{DeptId=4,DeptName="Java"},
            };
        }
    }
}
