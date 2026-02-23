using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    internal class GEngine
    {
        public int Data { get; }

        GEngine(int _Data)
        {
            Data = _Data;
            Console.WriteLine("Ctor");
        }

        public static GEngine SingleTon { get; } = new GEngine(1234);

        #region V1.0
        //static GEngine SingleObj = null;

        //static GEngine()
        //{
        //    SingleObj = new GEngine(123);
        //}

        //public static GEngine SingleTon { get { return SingleObj; } }

        #endregion


        public void DoSomeWork()
        {
            Console.WriteLine("Processing ...........");
        }
    }
}
