namespace MyShapes
{
    internal class Program
    {
        static void PrintArea(Shape t)
        {
            Console.WriteLine(t.CalArea());
        }
        static void Main(string[] args)
        {
            Shape s;
            Triangle t1 = new Triangle(10,20);
            PrintArea(t1);
            //Console.WriteLine(t1.CalArea());
            //Console.WriteLine("Hello, World!");
            Rectangle r1 = new Rectangle(10,20);
            //Console.WriteLine(r1.CalArea());
            PrintArea(r1);
        }
    }
}
