//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace D07_PI
//{
//    public class Utility
//    {
//        #region Non Genertic Swap
//        //public static void SWAP ( ref int X , ref int Y)
//        //{
//        //    int Temp = X;
//        //    X = Y;
//        //    Y = Temp;
//        //}

//        //public static void SWAP(ref double X, ref double Y)
//        //{
//        //    double Temp = X;
//        //    X = Y;
//        //    Y = Temp;
//        //}

//        //public static void SWAP(ref string X, ref string Y)
//        //{
//        //    string Temp = X;
//        //    X = Y;
//        //    Y = Temp;
//        //} 
//        #endregion

//        public static void SWAP<T>(ref T X, ref T Y) ///T : Type Parameter
//        {
//            T Temp = X;
//            X = Y;
//            Y = Temp;
//        }

//        public int SeachArray(int[] Arr , int Value)
//        {
//            for (int i = 0; i < Arr?.Length; i++) 
//                if (Arr[i] == Value)
//                    return i;
//            return -1;
//        }

//        public static void BSort(int[] items)
//        {
//            for ( int i = 0; i < items?.Length; i++)
//                for ( int j = 0; j < items.Length-i - 1; j++)
//                    if (items[j] > items[j+1])
//                        SWAP ( ref items[j] , ref items[j+1] );
//        }

//        public static int Sum (int X , int Y) {  return X + Y; }

//    }
//}
