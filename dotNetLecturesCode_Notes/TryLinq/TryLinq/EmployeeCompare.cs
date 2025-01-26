using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryLinq
{
    public class EmployeeCompare : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            //throw new NotImplementedException();
            return x.Id==y.Id && x.Name == y.Name && x.Age == y.Age && x.Salary == y.Salary && x.DeptId == y.DeptId;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Id;
        }
    }
}
