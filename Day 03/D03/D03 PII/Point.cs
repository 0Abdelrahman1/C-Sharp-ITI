using System;
using System.Collections.Generic;
using System.Text;

namespace D03_PII
{
    internal struct Point
    {
        int x;
        int y;

        public void SetX ( int _X) { x = _X; }
        public void SetY(int _Y) { y = _Y; }

        #region User Defined Ctor
        public Point(int _X, int _Y)
        {
            x = _X;
            y = _Y;
        }
        ///Compiler will ensure that aLL members are initialized before exiting any 
        ///User defined Ctor

        public Point(int N)
        {
            x = y = N;
        }

        ///Compiler will Generate Default Parameterless ctor ,
        ///Initializing ALL members to Default Value 
        ///define explicit Parameterless Ctor
        public Point()
        {
            x = y = -1;
        }
        #endregion

        public override string ToString()
        {
            return $"({x},{y})";
        }

        public void Show ()
        {
            Console.WriteLine($"({x},{y})");
        }
    }
}
