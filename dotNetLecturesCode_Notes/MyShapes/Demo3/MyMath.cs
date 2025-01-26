using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    interface IMathAddOp
    {
        int Add(int x, int y);
    }
    interface IMathSubOp
    {
        int Sub(int x, int y);
    }
    internal class MyMath:IMathAddOp, IMathSubOp
    {
        public int Z { get; set; }
        public int Add(int x, int y) 
        {
            return x + y; 
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
    }
}
