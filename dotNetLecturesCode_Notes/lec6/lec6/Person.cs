using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec6
{
    internal class Person//implicit inherit from object 
    {
        int id;
        string name;
        int age;
        public Person() 
        {
            id = 1;
            Name = "no name";
            age = 30;
        }
        public Person(string _name)
        {
            id = 1;
            Name = _name;
            age = 30;
        }
        public Person(int _id,string _name)
        {
            id = _id;
            Name = _name;
            age = 30;
        }
        public Person(int _id,string _name ,int _age)
        {
            id = _id;
            Name = _name;
            age = _age;
        }

        public int Id { get => id; set => id = value; }
        public string Name { 
            get => name;
            set
            { 
                if (value.Length>3)
                    name = value;
                else
                    Console.WriteLine("invalid provided value for name");
            } 
        }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            //represent the state of object values of the attribute fields
            return $"{name}:{id}:{age}";
        }
    }
}
