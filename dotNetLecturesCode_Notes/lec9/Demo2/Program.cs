using System;
using System.Collections.Generic;
namespace Demo2
{
    //class , struct , enum , interface ,delegate 
    //1. create new data type of type delegate 
    delegate void Del1();
    //reference take void and return void 
    delegate void Del2(int x);
    //reference take int and return void 
    delegate int Del3(int x,int y);
    delegate bool Del4(Emp e);
    internal class Program
    {
        public static bool checkemp(Emp e1)
        {
            if(e1.Salary>=2000&&e1.Salary<=4000)
            {
                return true;
            }
            return false;
        }
        public static List<Emp> GetEmployee(List<Emp> emps,Predicate<Emp> o5)
        {
            List<Emp> res = new List<Emp>();
            foreach (var item in emps)
            {
                if(o5.Invoke(item))
                {
                    res.Add(item);
                }
            }
            return res;
        }
        public static void Main(string[] args)
        {
            Predicate<Emp> o3=checkemp;
            List<Emp> e1 = new List<Emp>()
            {
                new Emp(){Id=1,Name="Khaled",Age=30,Salary=7000},
                new Emp(){Id=2,Name="Ahmed",Age=33,Salary=6000},
                new Emp(){Id=3,Name="Ali",Age=32,Salary=9000},
                new Emp(){Id=4,Name="Amir",Age=31,Salary=2000},
                new Emp(){Id=5,Name="Menna",Age=35,Salary=5000}
            };
            e1.RemoveAll((e) => e.Id < 3);
            foreach (var item in e1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("========================");
            List<Emp> r=GetEmployee(e1,checkemp);
            r=GetEmployee(e1,(e)=>e.Age>=33);
            r=GetEmployee(e1,(e)=>e.Id>3);
            foreach (var item in r)
            {
                Console.WriteLine(item);
            }
        }

        //2. create function 
        public static void Fun1()
        {
        //    Console.WriteLine("fun1");
        }
        public static void Fun3()
        {
        //    Console.WriteLine("fun3");
        }
        public static void Fun2(int x)
        {
        //    Console.WriteLine("fun2 "+ x);
        }

        
        static void Main1(string[] args)
        {
        //    //Program p1 = new Program();
        //    //3.create reference 
        //    Del1 o1 = new Del1(Fun1);
        //    o1?.Invoke();
        //    Del3 o4 = (x, y) =>
        //    {
        //        return x + y;
        //    };
            
            
        //    o4 += (x, y) =>
        //    {
        //        return x - y;
        //    };
        //    Console.WriteLine(o4.Invoke(10, 20));
        //    //anonymous function
        //    Del1 o3 = () =>
        //    {
        //        Console.WriteLine("hello world");
        //        Console.WriteLine("lampda exp");
        //    };
        //    o3.Invoke();
        //    //o1 += Fun3;
        //    //o1 -= Fun3;
        //    Del2 o2 = new Del2(Fun2);
        //    //4. invoke function through del 
        //    //o1.Invoke();
        //    //o2.Invoke(10);
        //    //Console.WriteLine("Hello, World!");
        }
    }
}
