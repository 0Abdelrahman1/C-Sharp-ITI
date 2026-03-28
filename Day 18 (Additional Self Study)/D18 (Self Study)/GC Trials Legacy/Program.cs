using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GC_Trials_Legacy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TempFile T1 = new TempFile();

            T1.DoSomeFileWork();

            T1.Dispose();
            T1 = null;

            Console.WriteLine("Continue Program");

            GC.Collect();

            string Str = Console.ReadLine();

            Console.WriteLine(Str.ToLower());
        }
    }
}
