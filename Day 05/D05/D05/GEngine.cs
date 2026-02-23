//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace D05
//{
//    internal class GEngine
//    {
//        public int Data { get;   }

//        GEngine(int _Data)
//        {
//            Data = _Data;
//            Console.WriteLine("Ctor");
//        }

//        static GEngine SingleObj = null;
//        public static GEngine GetObject ()
//        {
//            if ( SingleObj == null )
//             SingleObj = new GEngine(123456);
            
//            return SingleObj;
//        }

//        public void DoSomeWork ()
//        {
//            Console.WriteLine("Processing ...........");
//        }
//    }
//}
