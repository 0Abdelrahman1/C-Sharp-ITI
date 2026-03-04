using D11;
using static D11.ListGenerators;

List<int> Lst = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

#region Implicit Typed Local Variable

//var X = 13.5;

//Console.WriteLine(X.GetType());

//X = "Hello";

#endregion

#region Extension Method
//int X = 12345;

//int Y = Int32Extensions.Mirror(X);

//Y = X.Mirror(); //Extension MEthod

//Console.WriteLine(Y); 
#endregion

#region Anonymous Types
/////Immutable Reference Type

////Employee E1 = new Employee() { ID = 101, Name = "Ahmed Ali", Salary = 5000 };
////Employee E2 = new () { ID = 102, Name = "Sally Ali", Salary = 4000 };
////var E3 = new Employee() { ID = 103, Name = "Tamer Ali", Salary = 7000 };

//var E4 = new { ID = 104, Name = "Mona Ali", Salary = 15000M };
/////Anonymous Type
//var E5 = new {ID = 202 , Name = "Sayed Ali" , Salary = 10000M};

//if (E4.GetType() == E5.GetType())
//    Console.WriteLine ("E4 , E5 Same DataType");
//else
//    Console.WriteLine("Diff Type");

//Console.WriteLine(E4.Salary);
////E4.Salary++;
////E4.Salary = 50000;
////Immutable : To change State , need new identity
//E4 = new { ID = 501, Name = "NA", Salary = 50000M };

//var E6 = E5; //Same Identity
//Console.WriteLine(E6.GetHashCode());
//Console.WriteLine(E5.GetHashCode());

//var E7 = E6 with { ID = 301 }; //new Identity
//Console.WriteLine(E6.GetHashCode());
//Console.WriteLine(E7.GetHashCode());

//Console.WriteLine(E4.GetType());

//Console.WriteLine(E4);
//Console.WriteLine(E6);
//Console.WriteLine(E7);

////object E8 = new { ID = 202, Name = "Sayed Ali", Salary = 10000M };
////E8.Name 
#endregion

//var Lst2 = Lst.FindAll(x => x % 2 == 1);
#region L2O Ex01

////foreach (var x in Lst2)
////    Console.WriteLine(x);
/////1. Call as Static Method in a Static Class
//var Result = Enumerable.Where(Lst, x => x % 2 == 1);

////2. Extension Method
////Fluent Syntax
//Result = Lst.Where(x => x % 2 == 1);

////3.Query Syntax (valid in Only 14* LINQ Function)
////Will compile to the SAME as Fluent Syntax
////Begin : from  
////End with Select or Group By
//Result = from x in Lst /// x: Range Variable , represent each and every element in Input Seq.
//         where x % 2 == 1
//         select x; 
#endregion

#region deferred Execution vs Immediate Execution
//Deferred Execution
//var Result = Lst.Where(x => x % 2 == 1); ///Decorate Query , 

//Console.WriteLine(Result.GetType().Name);

//Lst.AddRange([10, 11, 12, 13, 14, 15]);

//foreach (var x in Result) ///Enumerate Data
//    Console.WriteLine(x);

//Lst.Remove(1);
//Lst.Remove(3);

//Console.WriteLine("After Remove");

//foreach (var x in Result)
//    Console.WriteLine(x);

///Immediate Execution
///casting Operators , Single Value Operators : Immediate Execution
//var Result = Lst.Where(x => x % 2 == 1).ToList(); 

//Console.WriteLine(Result.GetType().Name);

//Lst.AddRange([10, 11, 12, 13, 14, 15]);

//foreach (var x in Result)
//    Console.WriteLine(x);

//Lst.Remove(1);
//Lst.Remove(3);

//Console.WriteLine("After Remove");

//foreach (var x in Result)
//    Console.WriteLine(x);
#endregion

#region Where Filteration

//var Result = ProductList.Where(P => P.UnitPrice > 50);

//Result = from P in ProductList
//         where P.UnitPrice > 50
//         select P;

///Indexed Where , Index of element in Input Sequence 
///Available only Fluent Sytax

//var Result = ProductList.Where((P, i) => (P.UnitsInStock==0)&& (i<10));

#endregion

#region Select , Transformation 
//var Result = ProductList.Where(P => P.UnitsInStock == 0)
//                            .Select(P => P.ProductName);

//Result = from P in ProductList
//         where P.UnitsInStock == 0
//         select P.ProductName;

///TResult : Annonymous Type
//var Result = ProductList.Where(P => P.UnitsInStock == 0)
//                            .Select(P => new { P.ProductID, Name = P.ProductName, Price = P.UnitPrice });

//Result = from P in ProductList
//         where P.UnitsInStock == 0
//         select new { P.ProductID, Name = P.ProductName, Price = P.UnitPrice };

///Indexed Select , Fluent Syntax Only 
//var Result = ProductList.Where(P => P.UnitsInStock == 0)
//    .Select((P, i) => new { Index = i, P.ProductName });

#endregion

#region Order Operator

//var Result = ProductList.OrderBy(P => P.UnitPrice);

//Result = from P in ProductList
//         orderby P.UnitPrice
//         select P;

//var Result = ProductList.OrderByDescending(P => P.UnitPrice);

//Result = from P in ProductList
//         orderby P.UnitPrice descending
//         select P;

//var Result = ProductList.OrderByDescending(P => P.UnitPrice)
//                        .ThenBy(P => P.UnitsInStock);

//Result = from P in ProductList
//         orderby P.UnitPrice descending , P.UnitsInStock
//         select P;

//var Result = ProductList.OrderByDescending(P => P.UnitPrice)
//                        .ThenByDescending(P => P.UnitsInStock);

//Result = from P in ProductList
//         orderby P.UnitPrice descending, P.UnitsInStock descending
//         select P;

//var Result = ProductList.OrderBy(


//Department D01 = new() { ID = 7, Name = "HR", OpenDate = new DateTime(2000, 1, 1) };
//Department D02 = new() { ID = 8, Name = "Engineering", OpenDate = new DateTime(2003, 1, 1) };
//Department D03 = new() { ID = 9, Name = "Finance", OpenDate = new DateTime(2005, 1, 1) };

//List<Employee> empList = new()
//{
//    new() { ID = 107 , Name = "Zyad" , Salary = 13_000 , Department = D02 },
//    new() { ID = 103 , Name = "Mina" , Salary = 17_000 , Department = D01 },
//    new() { ID = 105 , Name = "Ali" , Salary = 12_000 , Department = D03 },
//    new() { ID = 104 , Name = "Sara" , Salary = 20_000 , Department = D01 },
//};


//var Result = empList.OrderBy(E => E.Salary);

//Result = empList.OrderBy(E => E.Department); ///Department Defalut Comparer

//Result = empList.OrderBy(E => E.Department, new DepartmentCreationDateComparer());


#endregion

#region Single Element Operators - Immediate

var DiscountedProducts = new List<Product>();

var Result = ProductList.First(); ///return First element in Seq

///Empty Seq
//Result = DiscountedProducts.First(); ///Throw Exception if input Seq is Empty 

Result = DiscountedProducts.FirstOrDefault(); //return Null if Input Seq is Empty , no Exception will be thrown

Result = ProductList.First(P => P.UnitsInStock == 0);

//Result = ProductList.First(P => P.UnitPrice > 300); ///throw exception if no element matching Predicate in Input Seq

Result = ProductList.FirstOrDefault(P => P.UnitPrice > 300); ///return null if no element matching Predicate in Input Seq , No Exception will be thrown


Result = ProductList.Last();

Result = ProductList.Last(P=> P.UnitsInStock==0);

Result = DiscountedProducts.LastOrDefault();

Result = ProductList.LastOrDefault(P => P.UnitPrice > 600);

Result = ProductList.ElementAt(3);
Result = ProductList.ElementAt(^3);

//Result = ProductList.ElementAt(80); ///Exception 

Result = ProductList.ElementAtOrDefault(80); ///return null if no element at this index exists , no Exceptions 



//Result = DiscountedProducts.Single(); //exception
//Result = ProductList.Single(); //exception
Result = DiscountedProducts.SingleOrDefault(); //if empty seq return null 
//Result = ProductList.SingleOrDefault(); //exception

Result = ProductList.SingleOrDefault(P => P.ProductID == 5);
Result = ProductList.SingleOrDefault(P => P.ProductID == 500);

///return null if no element match Predicate
///return Object if Only one Element match Predicate
///throw Exception if more than one element mathcing Predicate
//Result = ProductList.SingleOrDefault(P => P.ProductID > 50); ///Exception , wrong Using for Single Operator


//DiscountedProducts.Add(ProductList[0]);

//Result = DiscountedProducts.Single(); ///return Only element in Input Seq


Console.WriteLine(Result);
Console.WriteLine(Result?.ProductName ?? "NA");


#endregion


//foreach (var item in Result)
//    Console.WriteLine(item);