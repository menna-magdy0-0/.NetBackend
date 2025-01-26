using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    struct SeriesByTwo : ISeries
    {
        int current;
        public int Current { get { return current; } }
        //public int Current => throw new NotImplementedException();

        public void GetNext()
        {
            current+=2;
        }

        public void Reset()
        {
            current=0;
        }
    }
}
