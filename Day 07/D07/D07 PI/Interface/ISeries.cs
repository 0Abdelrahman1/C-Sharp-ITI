using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
    interface ISeries //Code Contract
    {
        int Current { get; }
        void MoveNext();
        void Reset();
    }

    class SeriesEngine
    {
        ///Develop against Abstraction (Base Type) not Concrete Implementation
        ///Open for Extenstion , Closed for Modifications
        public static void IterateSeries (ISeries series)
        {
            for  (int i = 0;i < 10; i++)
            {
                Console.Write($"{series.Current} , ");
                series.MoveNext();
            }
            Console.WriteLine();
            series.Reset();
        }
    }
}
