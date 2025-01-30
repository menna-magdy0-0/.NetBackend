namespace LinqTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //Q1:  Declare a List of numbers as shown :
            //List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            //Then write the following queries
            //Query1: Display numbers without any repeated Data and sorted
            List<int> list = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var q1 = list
                .OrderBy(n => n)
                .Distinct()
                .ToList();
            foreach (var item in q1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");

            //Query2: using Query1 result and show each number and it’s multiplication
            var q2 = q1
                .Select(n => new { Number = n, Multiply = n * n });

            foreach (var item in q2)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================================");
            #endregion

            #region Question 2
            //Q2: declare an array of names as shown :
            //string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            //Then write the following queries:
            //Query1: Select names with length equal 3

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            var q3 = names
                .Where(e => e.Length == 3)
                .Select(e => e);
            foreach (var item in q3)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");

            ////Query2: Select names that contains “a” letter(Capital or Small)then sort them by length

            var q4 = names
                .Where(e => e.ToLower().Contains("a"))
                .OrderBy(e => e.Length)
                .Select(e => e);
            foreach (var item in q4)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");

            ////Query3: Display the first 2 names
            var q5 = names.Take(2);
            foreach (var item in q5)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===================================");
            #endregion

            #region Question 3
            //Declare a class Subject 
            //that contains the following properties(Code, Name) 
            //and declare Student class that contains the following properties(ID, FirstName, LastName , Subject[]),
            //then define List of students As follow
            //List<Student> students= new List<Student>(){ 
            //    new Student(){ ID=1, FirstName="Ali", LastName="Mohammed", subjects=new Subjcet[]{ new Subjcet(){ Code=22,Name="EF"}, new Subjcet(){Code=33,Name="UML"}}}
            //    , new Student(){ ID=2,FirstName="Mona", LastName="Gala",subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}
            //    , new Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject[]{ new Subject (){ Code=22,Name="EF"}, new Subject (){Code=25,Name="JS"}}}
            //    , new Student(){ ID=1,FirstName="Ali", LastName="Ali",subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}},
            //};


            List<Student> students = new List<Student>()
            {
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                    subjects=new Subject[]{
                        new Subject(){ Code=22,Name="EF"},
                        new Subject(){Code=33,Name="UML"}
                    }
                },
                new Student(){ ID=2,FirstName="Mona", LastName="Gala",
                    subjects=new Subject[]{
                        new Subject(){ Code=22,Name="EF"},
                        new Subject(){Code=34,Name="XML"},
                        new Subject(){ Code=25, Name="JS"}
                    }
                },
                new Student(){ ID=3, FirstName="Yara", LastName="Yousf",
                    subjects=new Subject[]{
                        new Subject(){ Code=22,Name="EF"},
                        new Subject(){Code=25,Name="JS"}
                    }
                },
                new Student(){ ID=1,FirstName="Ali", LastName="Ali",
                    subjects=new Subject[]{
                        new Subject(){ Code=33,Name="UML"}
                    }
                },
            };

            //Query1: Display Full name and number of subjects for each student as follow {FullName= FirstName+LastName , NoOfSubjects= subjects.count}
            var q6 = students
                .Select(ww => new { FullName = ww.FirstName + " " + ww.LastName, NoOfSubjects = ww.subjects.Length });
            foreach (var item in q6)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================================");
            //Query2: Write a query which orders the elements in the list by FirstName
            //Descending then by LastName Ascending and result of query displays only first
            //names and last names for the elements in list as follow
            //function chaining
            var q7 = students.OrderByDescending(e => e.FirstName).OrderBy(e => e.LastName);
            foreach (var item in q7)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
            #endregion


        }
    }
}
