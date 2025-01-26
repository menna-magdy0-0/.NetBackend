using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec12
{
    //subsriber
    internal class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id}:{Name}";
        }
        //event handler 

        public void GetNotified(string title,Group g)
        {
            Console.WriteLine($"I am notified {Name} : {title} : {g.Name}");
        }
    }
}
