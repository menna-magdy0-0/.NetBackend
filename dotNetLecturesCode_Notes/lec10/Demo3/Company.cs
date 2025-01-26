using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    //subscriber
    internal class Company
    {
        public string Name { get; set; }
        List<Emp> emps;
        public Company() 
        {
            emps= new List<Emp>();
        }
        public void AddEmp(Emp e)
        {
            emps.Add(e);
            //3. subscribe 
            e.empfired += RemEmp;
            e.empfired +=DisplayRemoveEmp;

        }
        public void RemEmp(Emp e)
        {
            emps.Remove(e);
        }
        public void DisplayRemoveEmp(Emp e)
        {
            Console.WriteLine($"{e} is removed");
        }
        public void PrintEmps()
        {
            foreach (var item in emps)
            {
                Console.WriteLine(item);

            }
        }
    }
}
