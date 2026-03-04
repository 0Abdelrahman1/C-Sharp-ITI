using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    ///Subsc.
    static class BlackList
    {
        static List<string> bLst = new List<string>();

        public static int Count { get=> bLst?.Count??-1; }

        public static void AddToBlackList(object sender, OverBalanceEventArgs e)
        {
            if ((sender is BankAccount BC) && (BC != null) && (bLst?.Contains(BC.CustomerName) == false))
                if (e.DiffAmount > 100)
                    bLst.Add(BC.CustomerName);
        }


        ///CallBackMethod
        //public static void AddToBlackList (object sender , EventArgs e)
        //{
        //    if ((sender is BankAccount BC) && (BC != null) && (bLst?.Contains(BC.CustomerName) == false))
        //        if (>100)
        //        bLst.Add(BC.CustomerName);

        //    //switch (sender)
        //    //{
        //    //    case BankAccount BC:
        //    //        if (bLst?.Contains(BC.CustomerName) == false)
        //    //            bLst.Add(BC.CustomerName);
        //    //        break;
        //    //}

        //}

        public static string Content
        {
            get
            {
                StringBuilder sb = new StringBuilder();

                for (int i = 0; i < bLst?.Count; i++)
                    sb.Append(bLst[i]).Append(" , ");
                
                return sb.ToString();

                //string Str = "";
                //foreach (string item in bLst)
                //    Str += item + " , ";
                //return Str;
            }
        }

    }
}
