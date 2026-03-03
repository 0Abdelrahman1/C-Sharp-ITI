using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    internal interface ITypeOne
    {
        string Name { get; set; } //Abstract Property
        void DoSomeWork(); //Abstract Function
    }

    struct TypeOneA : ITypeOne
    {
        public decimal Salary { get; set;  }

        string name;
        public string Name { get { return name; } set { name = value; } }

        public void DoSomeWork()
        {
            Console.WriteLine($"{name} Doing Some Work");
        }
    }

    class TypeOneB : ITypeOne
    {
        string FullName;

        public string Name { get { return FullName; } set { FullName = value; } }

        public virtual void DoSomeWork() ///Default Implementation : Sealed
        {
            Console.WriteLine("Do Some Work");
        }
    }

    abstract class TypeOneC : ITypeOne
    {
        string name;
        public string Name { get => name; set => name = value; }

        public abstract void DoSomeWork();
    }
}
