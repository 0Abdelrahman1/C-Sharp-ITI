using System;
using System.Collections.Generic;
using System.Text;

namespace D11
{
    internal static class Int32Extensions
    {
        public static int Mirror (this int i)
        {
            var Numbers =  i.ToString().ToCharArray();
            Array.Reverse (Numbers);
            if (int.TryParse(new string (Numbers) , out int Temp))
                return Temp;
            return 0;
        }
    }
}
