using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6
{
    internal class Emp:Person//explicit inherit from person 
    {
        int salary;
        public Emp():base ()
        {
            salary = 3000;
        }
        public Emp(string _name):base(_name)
        {
            salary = 3000;

        }
        public Emp(int _id, string _name) : base(_id, _name)
        {
            salary = 3000;

        }
        public Emp(int _id, string _name,int _age) : base(_id, _name,_age)
        {
            salary = 3000;

        }
        public Emp(int _id, string _name, int _age,int _salary) : base(_id, _name, _age)
        {
            salary = _salary;

        }

        //public int Salary { get => salary; set => salary = value; }
        public override string ToString()
        {
            return $"{base.ToString()}:{salary}";
        }
    }
}
