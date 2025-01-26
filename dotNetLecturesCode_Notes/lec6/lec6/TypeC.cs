using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6
{
    internal class TypeC:TypeA
    {
        public int S { get; set; }
        public override int Add()
        {
            Console.WriteLine("Add in TypeC class");
            return X+Y+S;
        }
    }
}
