using System;
using System.Collections.Generic;
using System.Text;

namespace D06
{
    internal abstract class ClassOne
    {
        public int A { get; set;  }

        public ClassOne(int _A) {  A = _A; }

        public void DoSomeWork () { Console.WriteLine("Some Work"); }

        public override string ToString() { return $"{A}"; }
    }

    public abstract class Shape2D
    {
        public int Dim1 { get; set; }
        public int Dim2 { get; set; }

        public abstract double CalcArea();
    }

    public class Rect : Shape2D
    {
        public override double CalcArea()
        {
            return Dim1 * Dim2;
        }
    }

    public abstract class CircleBase : Shape2D
    {

    }
}
