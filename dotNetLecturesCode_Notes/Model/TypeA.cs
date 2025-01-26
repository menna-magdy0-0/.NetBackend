using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //default inside namespace is -> internal-> is to make the access modifier of the data to be limitit to the assimbly file 
    public class TypeA
    {
        //default access modifier inside the class is private -> can be accessed inside the class only
        int X;
        private protected int M;//accessed only in the assembly files inside the classes that inherit 
        protected int Y;//any class can inhirit it (either in assembly file or outside it )
        internal int Z;//either I inherit or not as long as I'm inside the namespace I can get to it 
        protected internal int L;//protectedinternal -> can access in the assimbly file and accessed outside the assimbly only in the inherited 
        public int K;//available from the any where
        public override string ToString()
        {
            return $"{X}::{Y}::{Z}::{K}::{L}::{M}";
        }
    }
}
