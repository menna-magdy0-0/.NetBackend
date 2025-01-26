using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec9
{
    internal class MStack<T> where T:IComparable
    {
        T [] arr;
        int tos;
        int size;
        public MStack(int _size=5)
        {
            size = _size;
            tos = -1;
            arr = new T[size];
        }
        void myfun()
        {
            //declare variable of type t  T a1;
            //default statement
            //tostring 
            //gethashcode
            //gettype
            //equals
            //== assignment operator
            //boxing & unboxing
            //return value of type T
            //accept value of type T
            T a=default(T);
            object o;
            o = a;
            a=(T)o;
            T b;
            b = a;
            T r;
            r = a + b;
        }
        public void push(T d)
        {
            if (tos < size - 1)
            {
                tos++;
                arr[tos] = d;
              
            }
            else
            {
                Console.WriteLine("stack is full");
            }
        }
        public T Pop()
        {
            if(tos>-1)
            {
                T d = arr[tos];
                tos--;
                return d;
            }
            throw new InvalidOperationException("MStack is full");
        }
    }
}
