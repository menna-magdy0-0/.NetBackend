using System;
using System.Collections.Generic;
namespace Demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Emp,string> empdic = new Dictionary<Emp,string>();
            Emp e4=new Emp() { Id=10,Name="wael"};
            empdic.Add(new Emp() { Id = 1, Name = "Khaled" }, "e1");
            empdic.Add(new Emp() { Id = 2, Name = "Ahmed" }, "e2");
            empdic.Add(new Emp() { Id = 3, Name = "Amir" }, "e3");
            empdic.Add(new Emp() { Id = 4, Name = "Farah" }, "e4");
            empdic.Add(e4, "e4");
            foreach (KeyValuePair<Emp,string> item in empdic)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }
            Dictionary<int,string> dic = new Dictionary<int,string>();
            dic.Add(10, "ahmed");
            dic.Add(20, "soliman");
            dic.Add(30, "wael");
            dic[0] = "sara";
            dic[1] = "ali";
            //Console.WriteLine(dic[20]);
            foreach (KeyValuePair<int,string> item in dic)
            {
                Console.WriteLine($"{ item.Key}:{ item.Value}");
            }




            //emplist o1 = new emplist();
            //o1.Add("ali");
            //o1.Add("mohamed");
            //o1.Add("mahmoud");
            //Console.WriteLine(o1.Count);
            //foreach (var item in o1)
            //{
            //    Console.WriteLine(item);
            //}
            List<Emp> emps = new List<Emp>()
            {
                new Emp(){Id=100,Name="Mahmoud"},
                new Emp(){Id=200,Name="Sayed"},
                new Emp(){Id=300,Name="Soliman"}
            };

            emps.Add(new Emp() { Id = 1, Name = "Ali" });
            emps.Add(new Emp() { Id = 2, Name = "Ahmed" });
            emps.Add(new Emp() { Id = 3, Name = "Amir" });
            emps.Add(new Emp() { Id = 4, Name = "khaled" });
            emps.Add(new Emp() { Id = 5, Name = "sara" });
            emps.Add(new Emp() { Id = 6, Name = "Nada" });
            foreach (var item in emps)
            {
                Console.WriteLine(item);
            }
            //Stack<int> st = new Stack<int>();
            //Queue<int> q = new Queue<int>();

            //List<int> list = new List<int>();
            //Console.WriteLine(list.Capacity);
            //list.Add(10);
            //list.Add(20);
            //Console.WriteLine(list.Capacity);
            ////Console.WriteLine(list.Count());
            //list.Add(30);
            //list.AddRange(new int[] { 100, 200, 300 });
            //Console.WriteLine(list.Capacity);
            //// Console.WriteLine(list.Count());
            //int sum = 0;
            //foreach (int i in list)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //List<string> list2 = new List<string>();
            //list2.Add("ali");
            //list2.Add("ahmed");
            //foreach(string s in list2)
            //{
            //    Console.WriteLine(s);
            //}
        }
        static void Main1(string[] args)
        {
            //int[] arr1 = { 2, 3, 4 };
            //int[] arr2 = { 5, 6, 7, 8};
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr1 = (int [])arr2.Clone();
            //Console.WriteLine(arr1.GetHashCode());
            //Console.WriteLine(arr2.GetHashCode());
            //arr2[1] = 2000;
            //foreach (var item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //foreach (var item in arr2)
            //{
            //    Console.WriteLine(item);
            //}



            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(10);
            //arrayList.Add(20);
            //arrayList.AddRange(new int[] { 10, 2, 3 });
            //arrayList.Remove(10);
            ////problems of arraylist 
            ////function Add take object from any kind of data may happen exceptions
            ////boxing and unboxing is make the program slow , type safety and the performance
            ////Console.WriteLine(arrayList.Count);
            //int sum = 0;
            //foreach (int i in arrayList)
            //{
            //    Console.WriteLine(i);
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            //int[] arr = new int[3] { 1, 2, 3 };
            //arr = new int[10];
            //Console.WriteLine("Hello, World!");
        }
    }
}
