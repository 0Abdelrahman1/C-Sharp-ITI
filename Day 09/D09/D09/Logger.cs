using System;
using System.Collections.Generic;
using System.Text;

namespace D09
{
    public class Logger
    {
        public string DBConnection { get;set;  }
        public void LogToDB (string Msg)
        {
            Console.WriteLine($"Logging {Msg} To DB:{DBConnection}");
        }

        public static void LogToAzure (string Msg)
        {
            Console.WriteLine($"Log {Msg}to The Cloud");
        }

        public static void LogTocsvLogger (string Msg)
        {
            Console.WriteLine("Logging to csv Log");
        }

        public void LogWithEnc (string Msg , string Key)
        {
            Console.WriteLine("Log using Encryption");
        }
    }
}
