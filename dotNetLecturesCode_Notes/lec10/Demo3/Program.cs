namespace Demo3
{
    public delegate int opdel(int x,int y);
    internal class Program
    {
        public static int Add(int x, int y)
            { return x + y; }
        public static void Main(string[] args)
        {
            Person person = new Person();
            


            Emp e1 = new Emp() { Id=1,Name="Khaled",AbsenceDays=0};
            Emp e2 = new Emp() { Id=2,Name="Ahmed",AbsenceDays=4};
            Emp e3 = new Emp() { Id=3,Name="Mariam",AbsenceDays=5};
            Emp e4 = new Emp() { Id=4,Name="Amir",AbsenceDays=1};
            Emp e5 = new Emp() { Id=5,Name="Farah",AbsenceDays=9};
            Emp e6 = new Emp() { Id=6,Name="Sara",AbsenceDays=0};
            Company ibm = new Company() {Name ="ibm" };
            ibm.AddEmp(e1);
            ibm.AddEmp(e3);
            //Console.WriteLine(e1);
            e1.AbsenceDays = 15;
            e3.AbsenceDays = 60;
            ibm.PrintEmps();
        }
        static void Main1(string[] args)
        {
            List<string> arr = new List<string>() { "ahmed","mohamed","ali"};
            
            opdel o2 = Add;
            opdel o3 = (x, y) => x + y;
            o3 += Add;
            //invocation list 
            Console.WriteLine(o3?.Invoke(12, 30));
            
            //Console.WriteLine("Hello, World!");
        }
    }
}
