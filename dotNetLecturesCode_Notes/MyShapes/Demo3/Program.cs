namespace Demo3
{
    internal class Program
    {
        static void Main (string[] args)
        {
            MyMath o1= new MyMath();
            Console.WriteLine(o1.Add(10, 20));
            Console.WriteLine(o1.Sub(30,10));
            
        }
        static void Main1(string[] args)
        {
            //interface -> contract 
            //contain methods without implementation
            //class implement more than interface 
            //but can't inherit more than one class 
            //struct implement more than one interface 
            //interface as abstraction 
            Point3D[] points = {
                new Point3D(10,20,30),
                new Point3D(5,20,30),
                new Point3D(3,20,30),
                new Point3D(20,20,30),
                new Point3D(1,20,30),
                new Point3D(4,20,30)
            };
            Array.Sort(points);
            foreach (var item in points)
            {
                Console.WriteLine(item);
            }

            IComparable p1=new Point3D(10,20,30);
            IComparable p2 = new Point3D(10, 20, 30);
            Console.WriteLine(p1.CompareTo(p2));



            int[] arr = { 5, 8, 1, 6, 2 };
            Array.Sort(arr);
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
            //Console.WriteLine("Hello, World!");
        }
    }
}
