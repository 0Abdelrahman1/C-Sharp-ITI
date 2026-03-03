using System.Threading.Channels;

namespace D09_PII
{

    //public delegate bool ConditionFuncDelDt(int x);
    //public delegate bool ConditionFuncDelDt<in T>(T x);
    ///Already Existing BCL Delegate 
    ///public delegate bool Predicte<in T> (T x) ///no  need to redeclar IT


    internal class Program
    {
        #region V1.0
        //public static List<int> FindOdd(List<int> Lst)
        //{
        //    List<int> oLst = new();
        //    for (int i = 0; i < Lst?.Count; i++)
        //        if (Lst[i] % 2 == 1)
        //            oLst.Add(i);
        //    return oLst;
        //}

        //public static List<int> FindEven(List<int> Lst)
        //{
        //    List<int> oLst = new();
        //    for (int i = 0; i < Lst?.Count; i++)
        //        if (Lst[i] % 2 == 0)
        //            oLst.Add(i);
        //    return oLst;
        //}

        //public static List<int> FindDivBy7(List<int> Lst)
        //{
        //    List<int> oLst = new();
        //    for (int i = 0; i < Lst?.Count; i++)
        //        if (Lst[i] % 7 == 0)
        //            oLst.Add(i);
        //    return oLst;
        //} 
        #endregion

        #region V2.0
        //public static List<int> FindCondition(List<int> Lst, ConditionFuncDelDt conditionFunc)
        //{
        //    List<int> oLst = new();
        //    for (int i = 0; i < Lst?.Count; i++)
        //        if (conditionFunc?.Invoke(Lst[i]) == true)
        //            oLst.Add(i);
        //    return oLst;
        //} 
        #endregion

        public static List<T> FindCondition<T>(List<T> Lst, Predicate<T> conditionFunc )
        {
            List<T> oLst = new();
            for (int i = 0; i < Lst?.Count; i++)
                if (conditionFunc?.Invoke(Lst[i]) == true)
                    oLst.Add(Lst[i]);
            return oLst;
        }

        static void Main(string[] args)
        {
            List<int> iLst = Enumerable.Range(0, 100).ToList();

            List<int> Lst2;

            //ConditionFuncDelDt<int> fPtr = new ConditionFuncDelDt<int>(ConditionFunctions.IsOdd);
            //Predicate<int> fPtr = new Predicate<int>(ConditionFunctions.IsOdd);

            //Lst2 = FindCondition(iLst, fPtr);

            //fPtr = ConditionFunctions.IsEven;
            //Lst2 = FindCondition(iLst, fPtr);

            //Lst2 = FindCondition(iLst, ConditionFunctions.IsDivBy07);

            //Predicate<int> fPtr = ConditionFunctions.IsGrt50;

            ///C# 2.0 : Anonymous Method
            //Predicate<int> fPtr = delegate (int X) { return X > 50; };

            ///C# 3.0
            ///Lambda Expression , Function
            ///=> : Fat Arrow , Reads as Goes To 
            Predicate<int> fPtr = X => X > 50;

            Lst2 = FindCondition(iLst, fPtr);

            Lst2 = FindCondition(iLst , X => X%13 ==0);

            Action Fptr2 = () => Console.WriteLine("Demo");

            int Z = 20;

            Func<int, int, int> fPTr03 = (X, Y) => X + Y + Z;
            
            Z = 100;

            Console.WriteLine($"Capturing Outer Variable {fPTr03(1,2)}");

            //Predicate<int> fPtr05 = x => Console.WriteLine(x); //Compilation Error

            foreach (var item in Lst2)
                Console.Write($"{item} , ");
            Console.WriteLine();


            //List<string> Names = ["Ahmed", "Ali", "Sally", "Samir", "Sayed", "Mai"];


            //foreach (var item in FindCondition(Names, ConditionFunctions.StrLengthGrt))
            //    Console.WriteLine(item);

        }
    }

    public class ConditionFunctions
    {
        

        public static bool IsOdd(int X) { return X % 2 == 1; }
        public static bool IsEven(int X) { return X % 2 == 0; }
        public static bool IsDivBy07(int x) { return x % 7 == 0; }

        public static bool StrLengthGrt(string Str) { return Str.Length > 4; }
    }
}
