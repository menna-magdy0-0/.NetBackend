using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    internal class FebSeries : ISeries
    {
        int current;
        int previous;
        public FebSeries()
        {
            previous = 0;
            current = 1;
        }
        public int Current { get { return current; } }
        //public int Current => throw new NotImplementedException();

        public void GetNext()
        {
            int Temp = Current;
            current += previous;
            previous = Temp;
        }

        public void Reset()
        {
            previous = 0;
            current = 1;
        }
    }
}
