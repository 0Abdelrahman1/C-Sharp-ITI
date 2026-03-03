using System;
using System.Collections.Generic;
using System.Text;

namespace D07_PI.Interface
{
   interface ILogger
    {
        //int X; ///Not Valid
        public void Log (string message) { Console.WriteLine(Prefix+message); }

        internal static string Prefix = "Warning";

        public static virtual void SecureLog () { }
        public static abstract void DBLog();
    }
    class Logger : ILogger
    {
        public static void DBLog()
        {
            Console.WriteLine($"DB Logging ");
        }
    }

    interface IOne
    {
        void FunOne();
    }

    interface ITwo : IOne
    {
        void FunTwo();
    }

    class Type02 : ITwo
    {
        public void FunOne()
        {
            throw new NotImplementedException();
        }

        public void FunTwo()
        {
            throw new NotImplementedException();
        }
    }

}
