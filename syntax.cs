#region Day 1
console.writeline(/* T */);
#endregion

#region Day 2

int x;
Int32 Y;

Object O = new Object();
object O1 = new object();
object O2 = new(); // syntax sugar
O1.GetHashCode();

Console.ReadLine();

int.Parse(/*string*/); // string to int

Convert.ToInt32(/* T */); // any type to int

string.Format("{0} + {1} = {2}", x, y, x + y);

string.Format($"{x} + {y} = {x + y}");
string.Format($"{x} + {y} = {x + y:X}"); // :X -> hexa, there is more ":_"

int[] Arr;
Arr = new int[5];
Arr = new int[5]{1,2,3,4,5};
Arr = new int[]{1,2,3,4,5};

int[] Arr2 = {1,2,3,4,5};
Arr2.Length;
Arr2.Rank; // number of dimentions
Arr = (int[])Arr2.Clone(); // clone bttrgga3 object fa lazem a3mel explicit casting
Arr[^1]; // = Arr[Arr.Length - 1]

Index i = ^7;
Arr[i];
int j = 5;
Arr[^j];

Arr2.CopyTo(Arr, 0, 3);
Array.Copy(Arr, 4, Arr2, 0, 3); // (sourceArray, sourceStartIndex, destinationArray, destinationStartIndex, length)

Arr = Arr2[0..3]; // arr[included..excluded] // slicing
Arr = Arr2[..3]; // Arr2[0..3]
Arr = Arr2[3..^2];
Arr = Arr2[5..]; // Arr2[5..^0]
Range r = 1..^3;
Arr = Arr2[r];

int[,] arr2d = new int[3, 2] = {{1, 2}, {3, 4}, {5, 6}}; // 2d array defination // arr2d.Length = 3 * 2 = 6, arr2d.GetLength(0) = 3, arr2d.GetLength(1) = 2
arr2d.GetLength(0) // (dimention index)
arr2d[2, 0] // same as arr2d[2][0] in c++

// jagged array
int[][] jarr = new int[3][];
jarr[0] = new int[10];
jarr[1] = new int[7];
jarr[2] = new int[3];
jarr[0][0] = 11;

#endregion


#region Day 3

float D = 13.5f;
decimal Salary = 15000.23M;
Int32 X = 5000;
Int64 Y = 50_000;
Y = X;      // Int64 = Int32   Implicit, Safe
X = (int)Y; // Int32 = Int64   Explicit, unsafe

checked // Without this it will be like c++ int overflow "silent"
{
    X = (int)Y;
} ///Instruct CLR To Throw Overflow Exception when overflow occures

unchecked { } // to Explicitly overflow exception "silent"

var D = 13.5; // like auto in c++

bool Flag = default; // it gives it the default value or call the parameter-less constructor like declaring global variable in c++ (bool) can be any other type

// Nullable Types // Null Operators
int? Z = 50;
Z = null; // int? can take all values of int + null
Z.value; // return int value of int? // same as "(int)Z";
int I = (int)Z; // must be "explicit" "unsafe" because int? greater than int // error in Z = null
Z.HasValue; // boolean if Z is int value (true) or null (false)
I = Z ?? -1; ///Null coalsing Operating // same as "I = Z.HasValue ? Z.Value : -1"; 

int[] arr = default; // null
arr?.Length; // this return type is (int?) not (int) as if arr == null it returns null else it returns arr.Length
for (int i = 0; i < (arr?.Length??0); i++); // we can get benefit from this in for loops like this  // "T? ?? v" return type is T
/// Arr.Lenght : int , Not Protective
/// Arr?.Lenght : int?,  Protective
/// Arr?.Lenght??-1 : int

Console.WriteLine(Emp?.Department?.Name?.Length ?? -1); //Null Propagation Operator 


/// Boxing , UnBoxing
int X = 50;
object O1;
O1 = X;
//ref to Base = Derived // by3mel mkan gded fel heap bnos5a mn el derived
//Safe , Implicit
//Boxing

O1 = "Hello";
int Y;
Y = (int)O1;
//Derived = Base
//UnSafe , Explicit 
//UnBoxing

/// string immutable
string str = "";
for (int i = 0; i < 100_000_000; i++) str += i.ToString(); // take so long time O(n^2) // there is string builder will be discussed later 

/// Enums
enum Grades
{ A , B , C , D , F}
enum Branches:byte // can take values of size byte only
{
    SV = 101 , Mansoura , Ismailia = 204 , Assuit , Alex 
}

[Flags] // when u console.write(12) it will output: "Write, Read" because of [Flags]
enum Permissions:byte 
{ Read = 0x08 , Write = 4, Execute = 0b_0000_0010 , Delete = 1 , Root = 15 , 
    SuperUser=0b_0000_1110}

// some more in D03 PII
#endregion