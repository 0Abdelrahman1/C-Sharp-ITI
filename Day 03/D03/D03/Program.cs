#region Type Casting - Numeric Built in Data Types
//float D = 13.5f;

//Console.WriteLine(D);

//decimal Salary = 15000.23M;

//Console.WriteLine(Salary);

//Int32 X = 5000;

//Int64 Y = 50_000;

////Y = X;
////Int64 = Int32
/////Implicit , Safe

//Y = long.MaxValue / 230;

/////by Default , CLR will not Throw Overflow Exception
//X = (int)Y;
////Int32 = Int64
////UnSafe , Explicit 


/////Instruct CLR To Throw Overflow Exception when overflow occures 
//checked
//{
//    X = (int)Y;
//}

////unchecked { }

//Console.WriteLine($"X = {X}");
//Console.WriteLine($"Y = {Y}");
#endregion

#region Implicit Typed Local Variable

//double D = 13.5;

//Console.WriteLine(D.GetType().Name);

////D = "Hello";

//Console.WriteLine(D);

var D = 13.5;

Console.WriteLine(D.GetType().Name);

//D = "Hello"; //Error

Console.WriteLine(D);


#endregion

#region Nullable Types
//bool Flag = default(bool);
//bool Flag = default;

//int X = 20;

//X = null; ///Not Allowed

////Nullable int
//int? Y = 50;

//Y = null;


//Y = X; ///Safe , implicit 

//X = (int)Y; //UnSafe , Explicit
//X = Y.Value;


//if (Y != null)
//    X = (int)Y;
//else
//    X = -1;

//if (Y.HasValue)
//    X = Y.Value;
//else
//    X = -1;

//X = Y.HasValue ? Y.Value : -1;

//X = Y ?? -1; ///Null coalsing Operating

//Console.WriteLine($"X = {X}");
//Console.WriteLine($"Y = {Y}");
#endregion

#region Null Operators
//int[] Arr = default;

////if (Arr != null)
////for (int i = 0; (Arr != null)&&(i < Arr.Length); i++)
////    Console.WriteLine(Arr[i]);

//for (int i = 0; i < Arr?.Length; i++)
//Console.WriteLine(Arr[i]);

///// Arr.Lenght : int , Not Protective
///// Arr?.lenght : int?,  Protective
///// Arr?.Lenght??-1 : int

////int R = Arr?.Length??-1;

/////Null Propagation Operator 

////Employee Emp = default;

////Employee Emp = new Employee();

//Employee Emp = new Employee() { Department = new() };


//Console.WriteLine(Emp?.Department?.Name?.Length ?? -1);

//class Employee
//{
//    public Department Department;
//}

//class Department
//{
//    public string Name = null;
//}
#endregion

#region Boxing , UnBoxing

//int X = 50;

//object O1;

//O1 = X;
////ref to Base = Derived
////Safe , Implicit 
////Boxing


//O1 = "Hello";

//int Y;

//Y = (int)O1;
////Derived = Base
////UnSafe , Explicit 
////UnBoxing

Console.WriteLine(Y);
#endregion

#region VERY VERY Large Number of Objects , use String Builder instead

//string Str = "";
//for (int i = 0; i < 100_000_000; i++)
//    Str += i.ToString();

//int Counter = 0;
//for (int i = 0; i < Str.Length; i++)
//    if (Str[i] == '1')
//        Counter++;
#endregion

Console.WriteLine("Demo");