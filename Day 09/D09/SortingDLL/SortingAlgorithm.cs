//using System.Net.Http.Headers;

//namespace SortingDLL
//{

//    public delegate bool CompFuncDelDt(int x, int y);
//    /// new Class , Any Object from this class can stor address of Any Function 
//    /// with the EXACT Signature bool(int,int)


//    public class SortingAlgorithm
//    {

//        public static void BSort(int[] items, CompFuncDelDt CompFunc)
//        {
//            bool SortedFlag = false;

//            for (int i = 0; (i < items?.Length) && (!SortedFlag); i++)
//            {
//                SortedFlag = true;
//                for (int j = 0; j < items.Length - i - 1; j++)
//                    if (CompFunc(items[j], items[j + 1]))
//                    {
//                        SWAP(ref items[j], ref items[j + 1]);
//                        SortedFlag = false;
//                    }
//            }
//        }


//        public static void BSort(int[] items)
//        {
//            bool SortedFlag = false;

//            for (int i = 0; (i < items?.Length) && (!SortedFlag); i++)
//            {
//                SortedFlag = true;
//                for (int j = 0; j < items.Length - i - 1; j++)
//                    if (CompFunctions.CompGrt(items[j], items[j + 1]))
//                    {
//                        SWAP(ref items[j], ref items[j + 1]);
//                        SortedFlag = false;
//                    }
//            }
//        }

//        public static void SWAP (ref int x , ref int y )
//        {
//            int Temp = x;
//            x = y;
//            y = Temp;
//        }


//    }

//    public class CompFunctions
//    {
//        public static bool CompGrt (int L , int R) { return L > R; }
//        public static bool Complwr(int L, int R) { return L < R; }

//        //public static int Demo(int x) { return x + 4; }
//    }

//}
