using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company
{
    [Flags]
    enum Security
    {
        Guest,Developer,Secretary,DBA
    }
    enum Gender
    {
        F,M
    }
    internal class Emp
    {
        private int id;
        private string name;
        private int salary;
        private DateTime hiringdate;
        

    }
}
