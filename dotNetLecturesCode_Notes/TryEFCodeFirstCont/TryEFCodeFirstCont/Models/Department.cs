using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryEFCodeFirstCont.Models
{
    //EF Convensions
    public class Department
    {
        public int DepartmentId { get; set; }
        public string DeptName { get; set; }
        //public string DeptDesc { get; set; }

        public virtual ICollection<Student> Students { get; set; }
        =new HashSet<Student>();

        public virtual ICollection<Instructor> Instructors { get; set; }
        = new HashSet<Instructor>();


    }
}


///before C#8
///Reference type by default nullable 
///after C#8 
///Non -nullable reference type => fire warning
///string str;