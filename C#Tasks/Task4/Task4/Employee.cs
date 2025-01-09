using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    //[Flags]
    enum SecurityPrivelages
    {
        Guest=1,Developer=2,Secretary=4,DBA=8
    }
    enum Gender
    {
        F,M
    }
    internal class Employee
    {
        int id;
        string name;
        int salary;
        DateTime hiredate;
        SecurityPrivelages sp;
        Gender g;
        public Employee()
        {
            id = 1;
            name = "No Name";
            salary = 1000;
            hiredate = DateTime.Now;
            Sp = SecurityPrivelages.Guest;
        }
        public Employee(int _id,string _name,int _salary,DateTime _hiredate,SecurityPrivelages _sp,Gender _g)
        {
           id= _id;
           name = _name;
           salary = _salary;
           hiredate = _hiredate;
           Sp = _sp;
           G = _g;
        }
        
        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        public DateTime Hiredate { get => hiredate; set => hiredate = value; }
        internal SecurityPrivelages Sp { get => sp; set => sp = value; }
        internal Gender G { get => g; set => g = value; }

        public override string ToString()
        {
            string sal = string.Format("{0}$", Salary);
            return $"{Id}::{Name}::{sal}::{Hiredate}::{Sp}::{G}";
        }
    }
}
