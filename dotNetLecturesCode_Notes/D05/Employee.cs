using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D05
{
    struct Employee
    {
        int id;
        public int ID
        {
            get { return id; }
            internal set { id = value; }
        }

        public string Name { get => name; internal set => name = value; }

        string name;
        //automatic property 
        public decimal Salary { get; internal set; }
        //compiler will generate a hidden (private) attribute and encapsulate it with public property
        public decimal TaxRate { get; }
        public override string ToString()
        {
            return $"{id}::{name}:::{Salary}";
        }


       


    }
}
