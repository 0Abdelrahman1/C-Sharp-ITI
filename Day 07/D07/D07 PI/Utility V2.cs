using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace D07_PI
{
    ///3 Types of Generic Constraints 
    public class Utility<T> where T :
        ///Primary Constraint 
        ///0 .. 1 
        ///Special Primary Constraint 
        ///class , ///T must be Class
        ///struct ,  ///T must be struct
        ///Enum , ///C# 7.3
        ///General Primary Constrint : Specific class
        ///Point2D ,
        /// not valid as Primary constrint
        ///Object, 
        ///System.ValueTuple,

        IComparable
        ///Secondary Constraint , Interface Constraint 
        ///T must be any class or Struct implementing IComparable interface
        ///can be 0 or Many 
        //,INumber<T> ///Generic Math 
        ,IAdditionOperators<T,T,T>


        ///Ctor Constraint 
        ///Only 1 available 
        ///,new() /// T must have accessable  parameterless ctor
        ///can't be used with special primary constraint struct
    {
        #region Non Genertic Swap
        //public static void SWAP ( ref int X , ref int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref double X, ref double Y)
        //{
        //    double Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //public static void SWAP(ref string X, ref string Y)
        //{
        //    string Temp = X;
        //    X = Y;
        //    Y = Temp;
        //} 
        #endregion

        public static void SWAP(ref T X, ref T Y) ///T : Type Parameter
        {
            T Temp = X;
            X = Y;
            Y = Temp;
        }

        public Utility()
        {
            ///Valid
            ///Declaration
            T x;
            T y;

            //Initialization
            x = default;

            //3. Assignment
            y = x;

            //4.return 
            // T MyFun () { T x = default ; return x;}

            //System.Object 5,6,7,8,9
            string Str = x?.ToString() ?? "";
            int R = x?.GetHashCode() ?? 0;
            if (x?.GetType() == y?.GetType()) ;
            if (x?.Equals(y)==true) ;
            object O1 = x;

            ///Where T : Icomprable
            //if (x.CompareTo(y) > 0) ;

            ///Where T : class
            //x = null;
            //if (x == y) ;

            ///where T : struct
            //x = new T();

            ///Not Valid
            //x = 0;
            //x = null;
            //x = new T();
            //if (x == y) ;
        }

        public int SeachArray(T[] Arr, T Value)
        {
            for (int i = 0; i < Arr?.Length; i++)
                if (Arr[i]?.Equals(Value) == true)
                    return i;
            return -1;
        }

        public static void BSort(T[] items)
        {
            for (int i = 0; i < items?.Length; i++)
                for (int j = 0; j < items.Length - i - 1; j++)
                    if (items[j]?.CompareTo(items[j + 1]) > 0)
                        SWAP(ref items[j], ref items[j + 1]);
        }

        public static T Sum(T X, T Y) { return X + Y; }

        #region Non Generic version


        //public int SeachArray(int[] Arr, int Value)
        //{
        //    for (int i = 0; i < Arr?.Length; i++)
        //        if (Arr[i] == Value)
        //            return i;
        //    return -1;
        //}

        //public static void BSort(int[] items)
        //{
        //    for (int i = 0; i < items?.Length; i++)
        //        for (int j = 0; j < items.Length - i - 1; j++)
        //            if (items[j] > items[j + 1])
        //                Utility<int>.SWAP(ref items[j], ref items[j + 1]);
        //}

        #endregion

    }
}