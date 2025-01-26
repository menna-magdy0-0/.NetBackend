using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA O1=new TypeA();
            O1.Z = O1.K = 1;
            //INSIDE the same assimbly file I can get to the inherited 
            O1.L = 1;

        }  
    }
    class TypeC : TypeA
    {
        public TypeC()
        {
            Y = Z = K = 2;
            L = 2;
            M = 1;
        }
    }
}
