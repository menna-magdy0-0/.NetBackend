using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapes
{
    internal abstract class Shape
    {
        int dim1;
        int dim2;
        public void SetDim1(int _dim1)
        { 
            dim1 = _dim1; 
        }
        public void SetDim2(int _dim2)
        {
            dim2 = _dim2;
        }
        public int getDim1()
        {
            return dim1;
        }
        public int getDim2()
        {
            return dim2;
        }
        public Shape()
        {
            dim1 = dim2 = 1;
        }
        public Shape(int x)
        {
            dim1 = dim2=x;
        }
        public Shape(int x, int y)
        {
            dim1 = x;
            dim2 = y;
        }
        public abstract float CalArea();
        //abstract method must be in abstract class and to be inherited in childs classes 
        //can't be create objects from this abstracted class
        //Shape S -> reference 
        //S=new Shape(); -> object , and this not allowed on abstract classes
        //abstract class contains zero or more abstract methods 
    }
}
