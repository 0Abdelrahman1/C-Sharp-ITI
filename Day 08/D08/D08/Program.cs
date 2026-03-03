//using System.Collections;

#region Non Generic Collection
//static int GetSum(ArrayList alst)
//{
//    int Sum = 0;

//    for (int i = 0; i < alst?.Count; i++)
//        Sum = (int)alst[i];

//    return Sum;
//}


//ArrayList lst = new ArrayList();

//lst.Add(1);
//lst.Add("2");
//lst.Add(3);
//lst.AddRange(new int[] { 4, 5, 6, 7 });

//Console.WriteLine(
//    GetSum(lst)
//    );

//for (int i = 0; i < lst.Count; i++)
//    Console.WriteLine(lst[i]); 
#endregion

#region Generic List
////List<int> lst = new List<int>() { 1, 2, 3, 4, 5, 6 };
////List<int> lst =  [ 1, 2, 3, 4, 5, 6 ];//C# 13

//List<int> Lst = new(6);

//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst.Add(1);
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst.Add(2);
////Lst.Add("3"); ///Type Safety Enforced @ Compilation
//Lst.Add(3);
//Lst.Add(4);
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst.Add(5);
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst.AddRange([ 6, 7 , 8 , 9]);
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");
//Lst.TrimExcess(); ///New Capacity = Count
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst.Add(10);
//Console.WriteLine($"Count : {Lst.Count} , Capacity {Lst.Capacity}");

//Lst[0] = 111; ///Update

//Lst.Remove(3);
//Lst.RemoveAt(5);

//for ( int i = 0; i < Lst?.Count; i++ )
//    Console.Write($"{Lst[i]} , "); //Get
//Console.WriteLine("");

////Lst[15] = 150; ///RunTime Error

//var Slice = Lst[..^2];

//Console.WriteLine(Lst[^1]); 
#endregion

using D08;
using System.Collections.Concurrent;
using System.Runtime;

#region IComparer
//List<Employee> EmpLst = [ new () {  ID = 10 , Name = "Mina" , Salary=30_000},
//    new () {  ID = 5 , Name = "Zyad" , Salary=70_000},
//    new () {  ID = 7 , Name = "Ahmed" , Salary=10_000}
//        ];
/////sort based on Salaries
//EmpLst.Sort(new EmployeeSalaryComparer());

/////Two Ways to Sort 
/////sort () ///Default Comparer :IComparable<T> 
/////{
/////    if (items[J].CompareTo(Items[J+1]) > 0) SWAP 
/////}
/////Sort (IComparer<T> Comparer)
/////{
///// if (Comparer.Compare(item[j],items[j+1])>0) Swap
/////}


//foreach (Employee emp in EmpLst)
//    Console.WriteLine(emp); 
#endregion

#region Dictionary Ex01
////Demo<int> O1 = new Demo<int>();

////Demo<int, string> O2 = new Demo<int, string>();

//Dictionary<string, long> PhoneBook = new Dictionary<string, long>();//{ ["ABC"] = 1 , ["XYZ"] = 201 };

//Console.WriteLine($"Capacity  {PhoneBook.Capacity}");

//PhoneBook.Add("XYZ", 123);
//PhoneBook.Add("ABC", 456);
//PhoneBook.Add("KLM", 789);
////PhoneBook.Add("ABC", 321); ///Exception , Key already exists 

//PhoneBook["ABC"] = 321; ///Update , Safa
//PhoneBook["DEF"] = 707;//Add

/////Search for Value using Key 
//Console.WriteLine(
//    PhoneBook["KLM"]
//    );

/////Not Safe 
////long R = PhoneBook["OOP"]; ///Run Time Error

//if (PhoneBook.ContainsKey("OOP"))
//    Console.WriteLine(PhoneBook["OOP"]);
//else
//    Console.WriteLine("Not Found");

//if (PhoneBook.TryGetValue("OOP" , out long Number))
//    Console.WriteLine(Number);
//else
//    Console.WriteLine("NA");

//foreach (KeyValuePair<string,long> item in PhoneBook)
//    Console.WriteLine($"{item.Key}:::{item.Value}");

#endregion

String Str = "Hello";
Console.WriteLine(Str.GetHashCode());

Str += ","; ///Immutable Type , any change in state result in change in Identity 
Console.WriteLine(Str.GetHashCode());


Point2D P1 = new Point2D() {  X = 10 , Y = 20 };
Point2D P2 = new Point2D() { X = 15, Y = 15 };
Point2D P3 = new Point2D() {  X = 10 , Y = 20 }; ///Same State as P1
Point2D P4 = P1; //Same Identity as P1

Console.WriteLine($"P1 {P1.GetHashCode()}");
Console.WriteLine($"P2 {P2.GetHashCode()}");
Console.WriteLine($"P3 {P3.GetHashCode()}");
Console.WriteLine($"P4 {P4.GetHashCode()}");

Dictionary<Point2D, string> Map = new Dictionary<Point2D, string>();

Console.WriteLine(Map.Count);

Map.Add(P1, "Upper Left Corner");
Map.Add(P2, "Lower Right Corner");

//
//Map.Add(P3, "Another Left Corner"); 

if (Map.TryGetValue(P4, out string Label))
    Console.WriteLine(Label);
else
    Console.WriteLine("Not Found");

if (Map.TryGetValue(P3 , out string LBL))
    Console.WriteLine(LBL);
else
    Console.WriteLine("P3 Not Found");

if ( P3.Equals(P1))
    Console.WriteLine("P3 EQ P1");
else
    Console.WriteLine("P3 NEQ P1");

Map.Remove(P2);
P2 = new Point2D() { X = 80, Y = 50 };
///P2 with new identity 
Map[P2] = "Right Corner";

//P2.X = 80; ///Not Valid after chaning Point To Immutable DataType

///Change in State
Console.WriteLine($"P2 {P2.GetHashCode()}");


if (Map.TryGetValue(P2,out LBL))
    Console.WriteLine(LBL);
else
    Console.WriteLine("P2 Not Found");

Employee E1 = new Employee() { ID = 1, Name = "Ahmed", Salary = 3000 };
Employee E2 = new Employee() { ID = 1, Name = "Ahmed", Salary = 3000 };

Dictionary<Employee, int> EmployeeLvl = new Dictionary<Employee, int>(new EmployeeEqualityComparer()) { [E1] = 10 };

Console.WriteLine(EmployeeLvl[E2]);



