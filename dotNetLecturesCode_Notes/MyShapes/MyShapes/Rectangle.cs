using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapes
{
    internal class Rectangle:Shape
    {
        public Rectangle() { }
        public Rectangle(int _x, int _y) : base(_x, _y)
        {

        }
        public override float CalArea()
        {
            return getDim1() * getDim2();
        }
    }
}
