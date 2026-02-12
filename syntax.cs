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