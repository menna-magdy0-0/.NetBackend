namespace lec6
{
    internal class Program //impicit inherit from object 
    {
        public static void myfun(TypeA b)
        {
            Console.WriteLine(b.Add());//depend on the passed object 
        }
        static void Main(string[] args)
        {
            object a1=new TypeA() { X=10,Y=20 };
            Console.WriteLine(a1.ToString());



            /*TypeA a1=new TypeA() { X=10,Y=20 };
            Console.WriteLine(a1);
            Console.WriteLine(a1.Add());
            Console.WriteLine(a1.Multiply());*/

            TypeB b1=new TypeB() { X=10,Y=20 ,Z=30};//
            Console.WriteLine(b1.ToString());
            Console.WriteLine(b1.Add());//early binding ,static 

            TypeC c1 = new TypeC() { S = 1, X = 2, Y = 3 };
            //reference of type a(parent)  -> reference object of type b (child)
            //static binding -> function of parent 
            //dynamic binding -> late binding for runtime 
            TypeA a2=new TypeB() { X=10,Y=20 , Z=30};
            Console.WriteLine(a2.Add());//static binding 
            a2 = new TypeC() { X = 20, Y = 30, S = 1 };
            Console.WriteLine(a2.Add());
        }
        static void Main1(string[] args)
        {
            Person P1= new Person(12,"ali ahmed",30);
            Console.WriteLine(P1);
            Emp e1 = new Emp();
            Console.WriteLine(e1);//display the constructor parameter less
            Emp e2 = new Emp("ahmed");//static and instant constructors can't be inherited 
            //constructors and finalizers can't be inherited 
            Console.WriteLine(e2.ToString());
            Emp e3 = new Emp(1234, "amir", 30, 5000) { Age = 60, Name = "Sara Ahmed", Id = 200 };
            Console.WriteLine(e3);

        }
    }
}
