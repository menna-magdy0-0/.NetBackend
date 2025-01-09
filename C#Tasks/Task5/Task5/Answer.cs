using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Answer
    {
        int num;
        string choicetext;
        public Answer()
        {
            Num = 1;
            Choicetext = "Object-Oriented Programming";
        }
        public Answer(int _num)
        {
            Num = _num;
            Choicetext = "Object-Oriented Programming";
        }
        public Answer(string _choicetext)
        {
            Num = 1;
            Choicetext = _choicetext;
        }
        public Answer(int _num, string _choicetext)
        {
            Num = _num;
            Choicetext = _choicetext;
        }

        public int Num { get => num; set => num = value; }
        public string Choicetext { get => choicetext; set => choicetext = value; }

        public override string ToString()
        {
            return $"{Num}::{Choicetext}";
        }
    }
}
