using System.Diagnostics;

namespace D04
{
    internal class Program
    {

        #region Stack Frame , Stack Trace
        //public static void FunOne ()
        //{
        //    FunTwo(10);
        //}
        //public static void FunTwo ( int X)
        //{

        //    StackTrace sTrace = new StackTrace();

        //    var sFrames = sTrace.GetFrames();

        //    for ( int i=0; i < sFrames.Length; i++ )
        //        Console.WriteLine(sFrames[i].GetMethod().Name);


        //    int Y = 3;

        //    Console.WriteLine(X/Y);
        //} 
        #endregion

        #region Default Input Parameter
        ///Valid
        //public static void Sum (int X, int Y , int Z) { Console.WriteLine(X+ Y + Z); }
        //public static void Sum(int X= 1, int Y=2, int Z=3) { Console.WriteLine(X + Y + Z); }
        //public static void Sum(int X, int Y, int Z=3) { Console.WriteLine(X + Y + Z); }
        //public static void Sum(int X, int Y=2, int Z=3) { Console.WriteLine(X + Y + Z); }

        ///Not Valid
        //public static void Sum(int X, int Y=2, int Z) { Console.WriteLine(X + Y + Z); }
        //public static void Sum(int X=1, int Y = 2, int Z) { Console.WriteLine(X + Y + Z); }
        //public static void Sum(int X=1, int Y , int Z) { Console.WriteLine(X + Y + Z); }

        #endregion

        public static void PrintLine (int N =5, string Pattern = "#")
        {
            //  FunOne();
            int i;
            for ( i =0; i < N; i++)
                Console.Write(Pattern);
            Console.WriteLine("");
        }

        ///Reference Type , Pass By Value
        //public static int SumArray(int[] Arr)
        //{
        //    Console.WriteLine($"Arr {Arr.GetHashCode()}");
        //    int Sum = 0;

        //    for (int i = 0; i < Arr?.Length; i++)
        //        Sum += Arr[i]++;

        //    return Sum;
        //}


        public static int SumArray( params int[] Arr)
        {
            int Sum = 0;

            for (int i = 0; i < Arr?.Length; i++)
                Sum += Arr[i]++;

            return Sum;
        }


        ///Value Types , Pass By Value
        //public static void SWAP (int X , int Y)
        //{
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        //Value Types , Pass by Reference
        public static void SWAP(ref int X,ref int Y)
        {
            int Temp = X;
            X = Y;
            Y = Temp;
        }

        ///By Value : Read Only
        ///By Reference : Read , Write 
        ///By Out : Write First
        public static void SumMul ( int X , int Y ,out int S ,out int M)
        {
            S =  X + Y;
            M =  X * Y;
        }


        static void Main()
        {
            #region Names , Default Input Parameter
            //int X;
            //Console.WriteLine("Enter New Value : ");
            //PrintLine(8,"-_-");
            //X = int.Parse(Console.ReadLine());
            //++X;
            //PrintLine(7 , "*");
            //PrintLine(Pattern: "=", N: 10); ///Named Input Parameters
            //PrintLine();
            //PrintLine(15);
            //PrintLine(Pattern: "+");
            //Console.WriteLine(X); 
            #endregion

            #region Value Type Pass by Value , Reference , out
            ////int A = 7, B = 3;

            //////SWAP(A, B); ///Pass By Value
            ////SWAP(ref A , ref B);

            ////Console.WriteLine($"A = {A}");
            ////Console.WriteLine($"B = {B}");

            //int A = 20, B = 5;
            ////int SumResult, MulResult;
            ////SumMul(A, B, out SumResult, out MulResult);

            ////SumMul(A, B, out int SumResult, out int MulResult);

            ////Console.WriteLine($"Sum = {SumResult}");
            ////Console.WriteLine($"Mul = {MulResult}");

            //SumMul(A, B, out int SumResult, out _);

            //Console.WriteLine($"Sum = {SumResult}"); 
            #endregion

            int[] MyArr = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine($"MYArr {MyArr.GetHashCode()}");
            Console.WriteLine(
                //SumArray(MyArr)
                $"{ SumArray(7, 8, 9)} {SumArray(1,2,3,4,5)}"
                );

            ///X : iteration variable , X represent MyArr[i] , X : readOnly
            //foreach ( var x in MyArr )
            //    Console.WriteLine(x);
        }
    }
}
