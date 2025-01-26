using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    //1. define a new datatype of type delegate
    //public delegate void empfireddel(Emp e);
    //publisher
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //1. reference of type empfired del
        public event Action<Emp> empfired;//take emp and return void
        int absenceDays;
        public int AbsenceDays
        {
            get => absenceDays;
            set
            {
                absenceDays = value;
                //2. fire event
                if (absenceDays > 30)
                {
                    empfired?.Invoke(this);
                }
                
                //absencedays > 30 remove emp from company
            }
        }
        public override string ToString()
        {
            return $"{Id}:{Name}:{absenceDays}";
        }



    }
}
