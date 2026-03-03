using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    class FibSeries : ISeries
    {
        int current;
        int prev;

        public FibSeries()
        {
            prev = 0;
            current = 1;
        }
        public int Current { get { return current; }  }
        
        public void MoveNext()
        {
            int Temp = current;
            current += prev;
            prev = Temp;
        }

        public void Reset()
        {
            prev = 0;
            current = 1;
        }
    }
}
