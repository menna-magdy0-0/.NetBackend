using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//How to write Model Classes with EF Runtime?
//1- EF Convensions
//2- Data Annotations => system.componentModel.DataAnnotations
//3- Fluent API       => onmodelcreating   POCO Class => plain old clr object
//4- External Configuration class

// EF Convensions
//1- PK => premptive int   Id  or classNameId
//2- PK => identity column
//3- any valuetype column => not null
//4- any reference type column => allow null
//5- string => nvarchar(max) => 5GB
namespace EFCoreFirstLook.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public decimal Salary { get; set; }
        //EF Runtime aware that this prop in FK for Department class
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString() => $"{Id}:{Name}:{Age}:{Salary}:{DepartmentId}:///{Department}///";
    }
}
