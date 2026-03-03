using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace D06
{
    internal class TypeBase
    {
        public int X { get; set; }

        public TypeBase(int _X =0) {  X = _X; }

        public void Show () { Console.WriteLine("I am Base"); }


        ///Dynamically , Late
        public virtual void DynShow() { Console.WriteLine("Base"); }
    }

    class TypeDerived : TypeBase
    {
        public int Y { get; set; }

        public TypeDerived(int _X = 0 , int _Y = 0):base(_X) {  Y = _Y; }

        public void Show () { Console.WriteLine("I am Derived"); }

        public override void DynShow() { Console.WriteLine("Derived"); }
    }

    class TypeDerived02 : TypeDerived
    {
        public override void DynShow()
        {
            Console.WriteLine("Derived 02");
        }
    }

    class TypeDerived03 : TypeDerived02
    {
        public new void DynShow() { Console.WriteLine("Derived 03 new Implementation"); }
    }
}
