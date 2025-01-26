using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShapes
{
    internal class Triangle:Shape
    {
        public Triangle() { }
        public Triangle(int _x, int _y) : base(_x, _y)
        {

        }
        public override float CalArea()
        {
            return 0.5f*getDim1()*getDim2();
        }
    }
}
