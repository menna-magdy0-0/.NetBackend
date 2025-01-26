using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo3
{
    internal class Point3D:IComparable
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D(int x=0,int y=0,int z=0)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"({X}:{Y}:{Z})";
        }
        public int CompareTo(object? obj)
        {
            //casting 
            Point3D point = obj as Point3D;
            if (point == null) 
                return 1;
            if (X == point.X)
                return 0;
            else if (X > point.X)
                return 1;
            else 
                return -1;
            //returns 0 if  objects ==
            //returns 1 if  object1 > object2
            //returns -1 if object1 < object2
            //throw new NotImplementedException();
        }
    }
}
