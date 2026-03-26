using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindConsoleAPP
{
    internal class Rect
    {
        readonly double W, H;

        //public Rect(int _W , int _H)
        //{
        //    W = _W;
        //    H = _H;
        //}

        public Rect(int _W, int _H) => (W,H) = (_W,_H);
        ///Deconstruct Pattern

        public void Deconstruct(out double _W, out double _H)
        {
            _W = W;
            _H = H;
        }

        public override string ToString() => $"Width:{W} , Height:{H}";
    }
}
