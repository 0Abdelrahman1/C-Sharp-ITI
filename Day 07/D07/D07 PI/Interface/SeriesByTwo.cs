using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    struct SeriesByTwo : ISeries
    {
        int current;
        public int Current {  get { return current; } }

        public void MoveNext()
        {
            current += 2;
        }

        public void Reset()
        {
            current = 0;
        }
    }
}
