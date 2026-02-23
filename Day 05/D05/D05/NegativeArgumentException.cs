using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    internal class NegativeArgumentException : Exception
    {
        public NegativeArgumentException():base("Argument must be >= 0")
        {
            
        }
    }
}
