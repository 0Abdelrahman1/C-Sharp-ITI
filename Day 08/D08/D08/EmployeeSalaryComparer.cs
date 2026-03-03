using System;
using System.Collections.Generic;
using System.Text;

namespace D08
{
    internal class EmployeeSalaryComparer : IComparer<Employee>
    {
        public int Compare(Employee? x, Employee? y)
        {
            if (x != null && y != null)
                return x.Salary.CompareTo(y.Salary);

            if (x != null) return 1;
            else if (y !=null) return -1;
            return 0; ///both Eq Null
        }
    }

    class Demo { }
    class Demo<T> { }

    class Demo<T1, T2> 
    {
        public T1 First { get; set; } 
        public T2 Second { get; set; }

        public void Process (T1 x , T1 y) { throw new NotImplementedException(); }
    }

    class  GenDerivedDemo <T> : Demo<T> /// Generic 
    {
        
    }

    class Derived02 : Demo<int> { } ///non Generic

    interface IMyType<in T>
    {
        void MyFun (T x); //valid

        //T MYFun02(); ///Not Valid
    }

    interface INewType<out T>
    {
        T MYFun();

        //T MyDemo(T x); ///Not Valid
    }

    class NewType : INewType<int>
    {
        public int MYFun()
        {
            throw new NotImplementedException();
        }
    }
}
