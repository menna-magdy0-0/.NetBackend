using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04
{
    interface ISeries
    {
        //dev1 decalre code contract to be implemented from other classes  
        int Current { get; }
        void GetNext();
        void Reset();
    }
}
