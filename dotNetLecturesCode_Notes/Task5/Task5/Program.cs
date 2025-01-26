using System;
using System.Collections;
using System.Collections.Generic;
namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Question> questions1 = new List<Question>()
            {
                new Question(){Mark=10,Questionbody="Test Question 1"},
                new Question(){Mark=20,Questionbody="Test Question 2"},
                new Question(){Mark=30,Questionbody="Test Question 3"}
            };

           
            foreach (var item in questions1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("_________________________________________________");

            List<Question> questions2 = new List<Question>()
            {
                new Question(){Mark=10,Questionbody="Test Question 1"},
                new Question(){Mark=20,Questionbody="Test Question 2"},
                new Question(){Mark=30,Questionbody="Test Question 3"}
            };

            foreach (var item in questions2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_________________________________________________");

            List<Answer> answersForQuestion1 = new List<Answer>()
            {
                new Answer(){Num=10,Choicetext="Test Answers 1 For Question 1"},
                new Answer(){Num=20,Choicetext="Test Answers 2 For Question 1"},
                new Answer(){Num=30,Choicetext="Test Answers 3 For Question 1"}
            };List<Answer> answersForQuestion2 = new List<Answer>()
            {
                new Answer(){Num=10,Choicetext="Test Answers 1 For Question 2"},
                new Answer(){Num=20,Choicetext="Test Answers 2 For Question 2"},
                new Answer(){Num=30,Choicetext="Test Answers 3 For Question 2"}
            };
            Dictionary<Question, List<Answer>> questionDict = new Dictionary<Question, List<Answer>>();
            // add to the dictionary a question with its list of answers
            questionDict.Add(new Question() { Mark = 10, Questionbody = "Test Question 1" }, answersForQuestion1);
            questionDict.Add(new Question() { Mark = 20, Questionbody = "Test Question 2" }, answersForQuestion2);

            // empdic.Add(new Emp() { Id = 1, Name = "Khaled" }, "e1");


            foreach (KeyValuePair<Question, List<Answer>> item in questionDict)
            {
                Console.WriteLine(item.Key);
                //Console.WriteLine(item.Value);
                foreach (var item2 in item.Value)
                {
                    Console.WriteLine(item2);
                }
            }


        }

    }
}
