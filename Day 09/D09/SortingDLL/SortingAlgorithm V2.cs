using System.Net.Http.Headers;

namespace SortingDLL
{

    public delegate bool CompFuncDelDt(int x, int y);
    /// new Class , Any Object from this class can stor address of Any Function 
    /// with the EXACT Signature bool(int,int)
    //public delegate bool CompFuncDelDt<T>(T x, T y);
    //public delegate TResult CompFuncDelDt<in T1,in T2,out TResult>(T1 x, T2 y);

    ///BCL Delegate Func , 17 Delegate
    ///public delegate Tresult Func<out TResult> ();
    ///public delegate Tresult Func<in T1 ,out TResult> (T1 x);


    public class SortingAlgorithm
    {

        public static void BSort<T>(T[] items, Func<T,T,bool> CompFunc)
        {
            bool SortedFlag = false;

            for (int i = 0; (i < items?.Length) && (!SortedFlag); i++)
            {
                SortedFlag = true;
                for (int j = 0; j < items.Length - i - 1; j++)
                    if (CompFunc(items[j], items[j + 1]))
                    {
                        SWAP(ref items[j], ref items[j + 1]);
                        SortedFlag = false;
                    }
            }
        }


        public static void BSort(int[] items)
        {
            bool SortedFlag = false;

            for (int i = 0; (i < items?.Length) && (!SortedFlag); i++)
            {
                SortedFlag = true;
                for (int j = 0; j < items.Length - i - 1; j++)
                    if (CompFunctions.CompGrt(items[j], items[j + 1]))
                    {
                        SWAP(ref items[j], ref items[j + 1]);
                        SortedFlag = false;
                    }
            }
        }

        public static void SWAP<T>(ref T x, ref T y)
        {
            T Temp = x;
            x = y;
            y = Temp;
        }


    }

    public class CompFunctions
    {
        public static bool CompGrt(int L, int R) { return L > R; }
        public static bool Complwr(int L, int R) { return L < R; }

        //public static int Demo(int x) { return x + 4; }
    }

}
