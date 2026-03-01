using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI
{
    sealed class TypeA
    {
    }

    //class TypeB : TypeA { }

    class TypeC { }

    sealed class TypeD:TypeC { } //Valid 

    class MyType
    {
        public int MyValue { get; set;  }

        public virtual void DoSomeWork () { }
    }
    class MyType02 : MyType 
    {
        public sealed override void DoSomeWork()
        {
        }
    }
    class MyType03 : MyType02
    {
        public new void DoSomeWork ()
        {

        }
    }

    abstract class TypeX
    {
        public abstract void DoSomeWork ();
    }

    class TypeX01 : TypeX
    {
        public sealed override void DoSomeWork()
        {
        }
    }

}
