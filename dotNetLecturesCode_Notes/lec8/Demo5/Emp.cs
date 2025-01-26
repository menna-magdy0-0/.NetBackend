using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo5
{
    internal class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id}::{Name}";
        }
    }
    class emplist : List<string>
    { 
        public void Add(string str)
        {
            Console.WriteLine($"str ={str}");
            base.Add(str);
        }
    }

}
