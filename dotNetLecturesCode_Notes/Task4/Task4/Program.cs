namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            DateTime dt1 = new DateTime(); // this will initialze variable with a date(01/01/0001) and time(00:00:00).
            DateTime dt2 = new DateTime(2019, 05, 09, 9, 15, 0);// this will initialize variable with a specific date(09/05/2019) and time(9:15:00).

            Employee emp2 = new Employee(1, "Manoooosha", 100000, dt2, SecurityPrivelages.DBA, Gender.F);
            Console.WriteLine(emp1);
            Console.WriteLine(emp2);

            string name1 = Console.ReadLine();
            int age1 = int.Parse(Console.ReadLine());
            Person person1 = new Person() { Name = name1, Age = age1 };


            string name2 = Console.ReadLine();
            int age2 = int.Parse(Console.ReadLine());
            Person person2 = new Person() { Name = name2, Age = age2 };

            string name3 = Console.ReadLine();
            int age3 = int.Parse(Console.ReadLine());
            Person person3 = new Person() { Name = name3, Age = age3 };
            if (age1 > age2)
            {
                if (age1 > age3)
                {
                    Console.WriteLine(person1);
                }
                else
                {
                    Console.WriteLine(person3);
                }
            }
            else
            {
                if (age2 > age3)
                {
                    Console.WriteLine(person2);
                }
                else
                {
                    Console.WriteLine(person3);
                }
            }
        }
    
    //Console.WriteLine("Hello, World!");

    }
}
