using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Question
    {
        string questionbody;
        int mark;
        public Question()
        {
            Questionbody = "What does OOP stand for?";
            Mark = 10;
        }
        public Question(string _questionbody)
        {
            Questionbody = _questionbody;
            Mark = 10;
        }
        public Question(int _mark)
        {
            Questionbody = "What does OOP stand for?";
            Mark = _mark;
        }
        public Question(string _questionbody, int _mark)
        {
            Questionbody = _questionbody;
            Mark = _mark;
        }

        public string Questionbody { get => questionbody; set => questionbody = value; }
        public int Mark { get => mark; set => mark = value; }

        public override string ToString()
        {
            return $"{Questionbody}::{Mark}";
        }
    }
}
