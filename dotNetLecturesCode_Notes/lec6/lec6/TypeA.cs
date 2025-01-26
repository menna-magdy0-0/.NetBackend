using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6
{
    //class implicit inherit from object 
    //struct implicit inherit from valutype -> object 
    //enum impicit inherit from enum -> value type -> object 
    internal class TypeA//object 
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            Console.WriteLine("tostring of type a");
            return $"{X}:{Y}";
        }
        public virtual int Add()
        {
            Console.WriteLine("add function type a");
            return X + Y;
        }
        public int Multiply()
        {
            Console.WriteLine("mul function type a");
            return Y * X;
        }




    }
}
