using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLinq
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public Decimal Salary { get; set; }

        public int DeptId { get; set; }
        public Department Department { get; set; } //Navigation property  //association
        public override string ToString()
        {
            return $"{Id}:{Name}:{Age}:{Salary}:{DeptId}";
        }
    }
}
