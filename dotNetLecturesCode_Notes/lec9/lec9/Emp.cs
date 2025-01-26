using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9
{
    internal class Emp:IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }
    }
}
