using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6
{
    internal class TypeB:TypeA
    {
        public int Z { get; set; }
        public override int Add()//the same signature of parent //dynamic binding //late binding
        {
            Console.WriteLine("add function type b");
            return X + Y + Z;
        }
    }
}
