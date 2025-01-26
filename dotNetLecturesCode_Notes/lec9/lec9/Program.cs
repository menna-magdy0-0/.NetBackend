namespace lec9
{
    internal class Program
    {
        //static void swap(ref int x, ref int y)
        //{
        //    int temp = x;
        //    x = y;
        //    y = temp;
        //}
        //static void swap(ref float x, ref float y)
        //{
        //    float temp = x;
        //    x = y;
        //    y = temp;
        //}
        //generic function
        static void swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            MStack<int> s1 = new MStack<int>();
            s1.push(10);
            s1.push(20);
            Console.WriteLine(s1.Pop());
            Console.WriteLine(s1.Pop());

            MStack<string> s2 = new MStack<string>();
            s2.push("ahmed");
            s2.push("amir");
            s2.push("khaled");
            s2.push("farah");
            s2.push("menna");
            Console.WriteLine(s2.Pop());

            MStack<Emp> s3 = new MStack<Emp>();
            s3.push(new Emp() {Id=1,Name="ali" });
            s3.push(new Emp() {Id=2,Name="amir" });
            s3.push(new Emp() {Id=3,Name="ahmed" });

        }
        static void Main1(string[] args)
        {
            int a = 10, b = 20;
            float f1 = 2.3f, f2 = 5.4f;
            double d1 = 2.3, d2 = 5.4;
            swap<int>(ref a, ref b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            swap<float>(ref f1, ref f2);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            swap<double>(ref d1, ref d2);
            Console.WriteLine(d1);
            Console.WriteLine(d2); 

            //Console.WriteLine("Hello, World!");
        }
    }
}
