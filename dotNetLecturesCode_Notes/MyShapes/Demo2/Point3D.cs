using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo2
{
    class XYZ
    {

    }
    internal class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        //indexer definition
        public int this[int i]
        {
            get
            {
                if (i == 0)
                    return X;
                else if (i == 1) 
                    return Y;
                else if (i == 2) 
                    return Z;
                throw new Exception();
            }
            set 
            {
                if (i==0)
                    X = value;
                else if(i==1)
                    Y = value;
                else if (i==2) 
                    Z = value;
            }
        }
        //overloading indexer 
        public int this[string n]
        {
            get 
            {
                if (n == "x")
                    return X;
                else if (n == "y")
                    return Y;
                else if (n == "z")
                    return Z;
                else throw new Exception();
            }
            set 
            {
                if (n == "x")
                    X = value;
                else if (n == "y")
                    Y = value;
                else if(n=="z") 
                    Z = value;
                else throw new Exception();
            }
        }
        public override string ToString()
        {
            return $"({X}:{Y}:{Z})";
        }
        public override bool Equals(object? obj)
        {
            //is , as -> reference data type 
            // class 
            Point3D p1 = obj as Point3D;

            if (p1 == null) return false;

            if (obj.GetType()!=this.GetType()) return false;

            if(p1.X==X&& p1.Y==Y&& p1.Z==Z) return true;
            else return false;



            //struct -> override on equals 
            //Point3D p1=(Point3D)obj;
            //if (p1.X == X && p1.Y == Y && p1.Z == Z) return true;
            //else return false;


            //if (obj == null) return false;
            ////as , is operator 
            //if (obj is Point3D)
            //{
            //    Point3D p1 = (Point3D) obj;
            //}
            ///*Point3D p1 = obj as Point3D;//cast object to point3d if it is applicable if not it returns null and not output exception 
            //if (p1 == null )  return false;*/
            //return base.Equals(obj);
        }
    }
    class point4d : Point3D
    {
        public int t { get; set; }
    }

}
