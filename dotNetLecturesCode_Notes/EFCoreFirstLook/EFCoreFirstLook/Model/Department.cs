using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFCoreFirstLook.Model
{
    //[Table("Depts")]
    public class Department
    {
        //[Key]
        public int DepartmentId { get; set; }
        //[Required]
        public string DeptName { get; set; }
        //Navigation Property => lazy loading
        public virtual  ICollection<Employee> Employees { get; set; }
        =new HashSet<Employee>();
    }
}
