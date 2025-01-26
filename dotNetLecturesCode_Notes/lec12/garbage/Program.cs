using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace garbage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempFile t1 = new TempFile();
            t1.DoSomeThing();
            t1.Dispose();
            t1 = null;
            GC.Collect();
            Console.WriteLine("after collecting");
            Console.ReadLine();
        }
    }
}
