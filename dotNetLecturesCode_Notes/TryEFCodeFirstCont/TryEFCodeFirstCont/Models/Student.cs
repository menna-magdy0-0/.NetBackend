using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//EF Model Creation
//1- EF Convensions
//2- Data Annotations
//3- Fluent API
//4- External Configuration
namespace TryEFCodeFirstCont.Models
{
    //4- External Configuration
    //configuration is done in external class
    public class Student
    {
        public int StdID { get; set; }
        public string? Name { get; set; }
        public int? Age { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //public byte[] Photo { get; set; }
        public string? Email { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        //public virtual ICollection<Course> Courses { get; set; }
        //= new HashSet<Course>();
        //public virtual ICollection<Instructor> Instructors { get; set; }
        //= new HashSet<Instructor>();

    }
}
