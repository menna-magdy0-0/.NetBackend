using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Person() { }
        public override string ToString()
        {
            return $"{Name}:{Age}";
        }
    }
}
