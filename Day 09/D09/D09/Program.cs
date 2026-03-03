using D09;
using SortingDLL;
using System.Diagnostics;
using System.Diagnostics.Metrics;

//SomeAlgorithm.DoSomeWork(/*Pointer To Logger Function*/);

int[] Arr = { 5, 4, -2, 6, 1, -8, 3, 7 };

//SortingAlgorithm.BSort(Arr);

//CompFuncDelDt fPTr = CompFunctions.CompGrt;
//CompFuncDelDt<int,int,bool> fPTr = CompFunctions.CompGrt;
Func<int, int, bool> fPTr = CompFunctions.CompGrt;

SortingAlgorithm.BSort(Arr, fPTr);

SortingAlgorithm.BSort(Arr, CompFunctions.Complwr);

SortingAlgorithm.BSort(Arr, ModernCompFunction.CompABSGrt);

SortingAlgorithm.BSort(Arr, (L, R) => Math.Abs(L) < Math.Abs(R));


foreach (int i in Arr)
    Console.WriteLine(i);

string[] Names = ["Ahmed", "Ali", "Sally", "Samir", "Sayed", "Mai"];


SortingAlgorithm.BSort(Names, ModernCompFunction.CompLenghtGrt);

foreach (string N in Names)
    Console.WriteLine(N);


Employee[] empArr = [new () { ID = 201 , Name = "Sayed" , Salary = 5000},
    new () { ID = 101 , Name = "Sara" , Salary = 55000},
    new () { ID = 150 , Name = "Sally" , Salary = 25000}
    ];

SortingAlgorithm.BSort<Employee>(empArr, (L,R) => L.Salary > R.Salary);

foreach (var item in empArr)
{
    Console.WriteLine(item);
}



#region Delegate Ex01
/////Step 1 : Pointer to Function Declaration
/////Delegate Object Declaration
//StringFuncDelDT fPtr;

/////Step 2 : Delegate Object initialization
//fPtr = new StringFuncDelDT(StringFunctions.GetLenght);


/////Step 3 : Using Pointer call (invoke) Function
//int R = fPtr("ABC");
//R = fPtr.Invoke("Hello");

//fPtr = default;

//R = fPtr("ABC"); ///RunTimeError
//R = fPtr?.Invoke("ABC")??-1; //Safe



//StringFunctions stringFunctionsObj = new() { Ch = 'a' };

////fPtr = new StringFuncDelDT(stringFunctionsObj.GetCharCount);
//fPtr = stringFunctionsObj.GetCharCount;

//R = fPtr.Invoke("AaBbCc");

////fPtr = StringFunctions.GetLenghtSum;//Compiler Error
////int(string, string) 
#endregion

#region C++ Pointers
///int X = 5
///1. Pointer Declaration
///int* Ptr;
///2.Pointer Initialization
///Ptr = &X;
///3.Use Pointer
///*Ptr=7;
#endregion

///Step Zero 
///Delegate DataType Declaration
///Create New Class : System.MultiCastDelegate
//public delegate int StringFuncDelDT(string S);


//class StringFunctions
//{
//    public static int GetLenght(string Str) {  return Str.Length; }
//    public char Ch { get; set; }
//    internal int GetCharCount (string Str )
//    {
//        int Counter = 0;
//        foreach (char c in Str)
//            if (c == Ch)
//                Counter++;
//        return Counter;
//    }

//    internal protected static int GetUpperCharCount (string Str)
//    {
//        int Counter = 0;
//        foreach (char c in Str)
//            if (Char.IsUpper(c))
//                Counter++;
//        return Counter;
//    }

//    public static int GetLenghtSum ( string Str1 , string Str2) { return Str1.Length+Str2.Length; }
//}


class ModernCompFunction
{
    internal static bool CompABSGrt (int x , int y) {  return Math.Abs(x) > Math.Abs(y); }

    public static bool CompLenghtGrt ( string x , string y ) {  return x.Length >  y.Length; }
}