using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    internal class TypeY
    {
        public TypeY()
        {
            TypeX X = new TypeX();
            X.C = 3;
            X.D = 4;
            
            
        }

    }

    class TypeZ : TypeX
    {
        public TypeZ()
        {
            B = 2;
            C = 3;
            D = 4;
            E = 5;
        }
    }
}
