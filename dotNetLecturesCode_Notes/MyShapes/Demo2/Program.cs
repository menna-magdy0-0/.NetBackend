using System.ComponentModel.Design;

namespace Demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook ph1 = new PhoneBook();
            //ph1[0]=
            Console.WriteLine(ph1["ahmed"]);
        }
        static void Main2(string[] args)
        {
            Point3D p2 = new Point3D() { X = 20, Y = 30, Z = 40 };
            //indexer
            //p2[0] = 10;
            //p2[1] = 30;
            //p2[2] = 60;
            p2["x"] = 10;
            p2["y"] = 30;
            p2["z"] = 60;
            Console.WriteLine(p2["y"]);
        }
        static void Main1(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Point3D b1=new Point3D() { X=1,Y=2 ,Z=3};
            Point3D b2=new Point3D() {X=1,Y=2,Z=3};
            point4d t1 = new point4d() { X = 1, Y = 2, Z = 3, t = 4 };
            XYZ x1 = new XYZ();
            //b1 = b2;
            if (b1.Equals( t1))
            {
                Console.WriteLine("equal");
            }
            else
            {
                Console.WriteLine("not equal");
            }
            //b1 = b2;
            Console.WriteLine(b1.GetHashCode());
            Console.WriteLine(b2.GetHashCode());

            Console.WriteLine(b1);
            Console.WriteLine(b2);
        }
    }
}
