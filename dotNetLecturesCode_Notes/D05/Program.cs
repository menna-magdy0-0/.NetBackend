using Model;
namespace D05
{
    //class TypeD:TypeA
    //{
    //    public TypeD()
    //    {
    //        Y = K = 4;
    //        L = 5;
    //    }
    //}

    internal class Program
    {
        static void Main(string[] args)
        {
            //#region Object Initializer
            ////Employee E=new Employee();
            ////E.ID = 101;
            ////E.Name = "Aly";
            ////E.Salary = 7000;
            ////object Initializer
            ////Employee E = new Employee() { ID = 101,Name="Aly" ,Salary=7000};
            ////Console.WriteLine("Hello, World!");
            //#endregion
            //TypeA O3=new TypeA();
            //O3.K = 3;

            ////Car C1;//ZERO byte allocated in heap
            ////C1=new Car();
            /////1. new allocate object in heap 
            /////2. new crossout (initialize) allocated
            /////3. new call userdefined Ctor if exists 
            /////4. new assign reference to newly allocated object 
            //Car C2 = new Car(101, "BMW", 120);
            //Car C3 = new Car(202, "BYD");
            //Console.WriteLine(C2);
            //Console.WriteLine(C3);

            //Console.WriteLine($"C2 {C2.GetHashCode()}");
            //Console.WriteLine($"C3 {C3.GetHashCode()}");

            ////C3 = C2;
            //Console.WriteLine($"C2 {C2.GetHashCode()}");
            //Console.WriteLine($"C3 {C3.GetHashCode()}");
            /////C3 new object with new Identity , same state as C2
            ////C3 = new Car(C2);//copy constructor 
            ////Console.WriteLine("Copy Constructor");
            //C3 = (Car)C2.Clone();
            //Console.WriteLine("Clone");
            //Console.WriteLine($"C2 {C2.GetHashCode()}");
            //Console.WriteLine($"C3 {C3.GetHashCode()}");

        }
    }
}
