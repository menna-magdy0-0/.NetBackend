namespace lec8
{
    interface IXYZ
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
    }
    internal class Program:IXYZ
    {
        public static void Method1()
        {
            Console.WriteLine("method1");
            Method2();
        }
        public static void Method2()
        {
            Console.WriteLine("method2");
            Method3();
        }
        public static void Method3()
        {
            Console.WriteLine("method3");
        }
        public void MyFun()
        {
            Console.WriteLine("DSFG");
        }
        static void Main(string[] args)
        {
            Method1();
            //Program p1 = new Program();
            //p1.add(1, 2);
            //p1.MyFun();
            //Console.WriteLine("Hello, World!");
        }

        public void add(int x, int y)
        {
            Console.WriteLine(x + y);
            //throw new NotImplementedException();
        }
    }
}
