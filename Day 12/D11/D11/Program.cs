using D11;
using System.Diagnostics.CodeAnalysis;
using System.Text.RegularExpressions;
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

//var DiscountedProducts = new List<Product>();

#region Single Element Operators - Immediate


//var Result = ProductList.First(); ///return First element in Seq

/////Empty Seq
////Result = DiscountedProducts.First(); ///Throw Exception if input Seq is Empty 

//Result = DiscountedProducts.FirstOrDefault(); //return Null if Input Seq is Empty , no Exception will be thrown

//Result = ProductList.First(P => P.UnitsInStock == 0);

////Result = ProductList.First(P => P.UnitPrice > 300); ///throw exception if no element matching Predicate in Input Seq

//Result = ProductList.FirstOrDefault(P => P.UnitPrice > 300); ///return null if no element matching Predicate in Input Seq , No Exception will be thrown


//Result = ProductList.Last();

//Result = ProductList.Last(P=> P.UnitsInStock==0);

//Result = DiscountedProducts.LastOrDefault();

//Result = ProductList.LastOrDefault(P => P.UnitPrice > 600);

//Result = ProductList.ElementAt(3);
//Result = ProductList.ElementAt(^3);

////Result = ProductList.ElementAt(80); ///Exception 

//Result = ProductList.ElementAtOrDefault(80); ///return null if no element at this index exists , no Exceptions 



////Result = DiscountedProducts.Single(); //exception
////Result = ProductList.Single(); //exception
//Result = DiscountedProducts.SingleOrDefault(); //if empty seq return null 
////Result = ProductList.SingleOrDefault(); //exception

//Result = ProductList.SingleOrDefault(P => P.ProductID == 5);
//Result = ProductList.SingleOrDefault(P => P.ProductID == 500);

/////return null if no element match Predicate
/////return Object if Only one Element match Predicate
/////throw Exception if more than one element mathcing Predicate
////Result = ProductList.SingleOrDefault(P => P.ProductID > 50); ///Exception , wrong Using for Single Operator


////DiscountedProducts.Add(ProductList[0]);

////Result = DiscountedProducts.Single(); ///return Only element in Input Seq


//Console.WriteLine(Result);
//Console.WriteLine(Result?.ProductName ?? "NA");


#endregion

#region Aggregation 
///count , Max , Min , Sum , AVG , Aggregate

//var Result = ProductList.Where(P => P.Category == "Beverages").Count();

//Result = ProductList.Count(P => P.UnitsInStock <= 5);

//var CountByResult = ProductList.CountBy(P => P.Category);

//foreach (var item in CountByResult)
//    Console.WriteLine($"Category {item.Key} have {item.Value} Product");

//Console.WriteLine(Result);

//var Prd = ProductList.Max();

//Prd = ProductList.Min();

//Console.WriteLine(Prd);

//Console.WriteLine(ProductList.Max(P => P.UnitsInStock));

//var Prod = (from P in ProductList
//           where P.UnitsInStock == ProductList.Max(P => P.UnitsInStock)
//           select P).FirstOrDefault();

//var Prod = ProductList.MaxBy(P => P.UnitsInStock);
//Prod = ProductList.MinBy(P => P.UnitsInStock);

//Console.WriteLine(Prod);

//var R = ProductList.Sum(P => P.UnitsInStock);

//var PrdAvg = ProductList.Average(P=>P.UnitsInStock);

//Console.WriteLine(PrdAvg);

//var Result = Lst.Aggregate(0, (Sum, N) => N % 2 == 1 ? Sum + N : Sum);

//Console.WriteLine(Result);

#endregion

#region Index
//var Result = ProductList.Where(P => P.UnitsInStock < 5);

//var IndexedResult = Result.Index(); //C# 13

//foreach (var i in IndexedResult)
//    Console.WriteLine($"Index:{i.Index} Product {i.Item}");


//for ( int i=0; i < Result.Count(); i++ )
//    Console.WriteLine(Result.ElementAtOrDefault(i));


#endregion

#region Casting

////var Result = (from P in ProductList
////              where P.UnitPrice > 25
////              orderby P.UnitPrice descending, P.UnitsInStock descending
////              select new { P.ProductName, P.UnitPrice, P.UnitsInStock });

////var PrdLst = Result.ToList();

////var Result = ProductList.Select(P => P.ProductName).ToArray();

////var PrdDictionary = ProductList.Where(P => P.UnitsInStock > 35).ToDictionary(P => P.ProductID);///Key Selector , TValue:Product

////var PrdDictionary = ProductList.Where(P => P.UnitsInStock > 35)
////    .ToDictionary(

//Department D01 = new() { ID = 7, Name = "HR", OpenDate = new DateTime(2000, 1, 1) };
//Department D02 = new() { ID = 8, Name = "Engineering", OpenDate = new DateTime(2003, 1, 1) };
//Department D03 = new() { ID = 9, Name = "Finance", OpenDate = new DateTime(2005, 1, 1) };

//List<Employee> empList = new()
//{
//    new() { ID = 107 , Name = "Zyad" , Salary = 13_000 , Department = D02 },
//    new() { ID = 103 , Name = "Mina" , Salary = 17_000 , Department = D01 },
//    new() { ID = 105 , Name = "Ali" , Salary = 12_000 , Department = D03 },
//    new() { ID = 104 , Name = "Sara" , Salary = 20_000 , Department = new Department() { ID = 7 } },
//};

////var PrdDictionary = empList.ToDictionary(E => E.Department,new DepartmentEqualityComparer());
//var PrdDictionary = empList.ToDictionary(E=>E.ID , E=>E.Department.Name);

//foreach (var kvp in PrdDictionary)
//    Console.WriteLine($"{kvp.Key}:::{kvp.Value}");

#endregion

#region Generation Operators
var Lst01 = Enumerable.Range(0, 100); //0..99
var Lst02 = Enumerable.Range(50, 100); //50..149

var DiscountedProducts = Enumerable.Empty<Product>();

var Temp = Enumerable.Repeat(5, 30);
var TempPrds = Enumerable.Repeat(ProductList.First(), 10); ///Repeat Identity 

#endregion

#region Set

//var Result = Lst01.Concat(Lst02);
//var Result = Lst01.Concat(Lst02).Distinct();
//var Result = Lst01.Union(Lst02);

var PrdLst02 = new List<Product>() { 
    //new() { ProductID = 7, ProductName = "NA" }
    new Product{ ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce",
                UnitPrice = 30.0000M, UnitsInStock = 15 }
, new() { ProductID = 9, ProductName = "NA" } };

//var Results = ProductList.Union(PrdLst02, new ProductEqualityComparer());

//Results = ProductList.UnionBy(PrdLst02, P => P.ProductID);

//Console.WriteLine(Results.Count());

//var Result = Lst01.Except(Lst02);

//Result = Lst01.Intersect(Lst02);

//var Result = ProductList.Intersect(PrdLst02, new ProductEqualityComparer());

//Result = ProductList.IntersectBy( PrdLst02.Select(P=> P.ProductID), P => P.ProductID);

//foreach (var i in Result)
//    Console.Write($"{i} , ");
//Console.WriteLine();

#endregion

#region Quantifiers

//Console.WriteLine(
//DiscountedProducts.Any() 
//ProductList.Any(P => P.UnitsInStock ==0)
//ProductList.All( P=> P.UnitPrice > 20)
//);

//var Depts = new List<Department>()
//{
//    new() { ID = 7, Name = "HR", OpenDate = new DateTime(2000, 1, 1) },
//    new() { ID = 8, Name = "Engineering", OpenDate = new DateTime(2003, 1, 1) },
//    new() { ID = 9, Name = "Finance", OpenDate = new DateTime(2005, 1, 1) }
//};

//var EmpDepts = new List<Department>() { new() { ID = 7 }, new() { ID = 8 }, new() { ID = 9 } };

//Console.WriteLine(Depts.SequenceEqual(EmpDepts));
//Console.WriteLine(Depts.SequenceEqual(EmpDepts , new DepartmentEqualityComparer()));


#endregion

#region Partitioning (Slicing)- Deferred Execution

//var PrdList = ProductList.Where(P => P.UnitsInStock > 0);
//var Result = PrdList.Take(5); ///Take First 5 elements in Input Sequance

//Result = PrdList.Skip(50); //Skip First 50 element , Take the rest into output Sequence

//Result = PrdList.TakeLast(10); ///take last 10 elements 

//Result = PrdList.SkipLast(20); ///Skip the last 20 Elements

//Result = PrdList.Take(..^10);

//Result = ProductList.SkipWhile (P=> P.UnitsInStock > 0); 
/////Skip all elements as long as Predicate return true , Take aLL remanining Elements after FIRST Predicate return false

//Result=  ProductList.TakeWhile(P => P.UnitsInStock > 0);
/////Take all elements as long as Predicate return true , Skip aLL remanining Elements after FIRST Predicate return false


//for (int i = 0; i < (ProductList.Count / 10)+1; i++)
//{
//    Console.Clear();
//    var PrdList = ProductList.Skip(i * 10).Take(10);

//    foreach (var Prd in PrdList)
//        Console.WriteLine(Prd);

//    Console.ReadLine();
//}

//var Page = ProductList.Chunk(10);


//foreach (var Prds in Page)
//{
//    Console.Clear();
//    foreach (var Prd in Prds)
//        Console.WriteLine(Prd);
//    Console.ReadLine();
//}

#endregion

#region Zip

//List<int> iLSt = new() { 1, 2, 3, 4, 5, 6, 7 };
//List<string> Cities = new() { "Cairo", "Giza", "Alex" };

//var Result = iLSt.Zip(Cities, (i, N) => new { Index = i, City = N });

#endregion

#region SelectMany
///Transform Every element in Input Seq to Sequence 
List<string> Names = new() { "Ahmed Ali", "Sayed Samir", "Mai Farouk" };

//var Result = from FullName in Names
//             from SingleName in FullName.Split(' ') //introduce new Range Variable
//             where SingleName.Length >= 4
//             //select SingleName;
//             select new { FullName, SingleName }; ///Access for Both Range Variables 

//Result = Names.SelectMany(FN =>FN.Split(' '))
//                .Where (SN => SN.Length > 4);

//var Result = ProductList.SelectMany(P => P.ProductName.ToCharArray()).Distinct();

#endregion

#region Let , Into

string[] EmpNames =  { "Ahmed", "Sayed", "Mai", "Mina", "Sara", "Zyad", "Moemen" };


//var Results = from N in EmpNames
//              select Regex.Replace(N, "[AOIEUaoieu]", string.Empty)
//                  into NoVowelName ///Introduce New Range Variable , restart Query using only new Range Variable
//              where NoVowelName.Length >= 3
//              select NoVowelName;

//Results = EmpNames.Select(N => Regex.Replace(N, "[AOIEUaoieu]", string.Empty))
//                    .Where(NovowlName => NovowlName.Length >=3);

//var Results = from N in EmpNames
//          let NoVowelName = Regex.Replace(N, "[AOIEUaoieu]", string.Empty) //Continue Query with Both Range Variables
//          where NoVowelName.Length >= 3
//          orderby NoVowelName.Length, N.Length
//          select new { Original = N, NoVowelName = NoVowelName };

//foreach (var item in Results)
//    Console.WriteLine(item);

#endregion

#region GroupBy

//var PRdGroups = from P in ProductList
//                where P.UnitsInStock > 0
//                group P by P.Category;

//PRdGroups = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category);

var PRdGroups = from P in ProductList
                where P.UnitsInStock > 0
                group P by P.Category into PrdGps
                where PrdGps.Count() > 10 
                select new { Category = PrdGps.Key , PRdCount = PrdGps.Count() };

PRdGroups = ProductList.Where(P => P.UnitsInStock > 0).GroupBy(P => P.Category).Where( PG => PG.Count() > 10)
                            .Select(PrdGps => new { Category = PrdGps.Key, PRdCount = PrdGps.Count() });


Console.WriteLine(PRdGroups.Count());

foreach (var item in PRdGroups)
{
    Console.WriteLine(item);
}

//foreach (var PrdGroup in PRdGroups)
//{
//    Console.WriteLine(PrdGroup.Key);
//    foreach (Product item in PrdGroup)
//        Console.WriteLine($"..{item.ProductName}");
//}

#endregion

//foreach (var item in Result)
//    Console.WriteLine(item);

class ProductEqualityComparer : IEqualityComparer<Product>
{
    public bool Equals(Product? x, Product? y) => x.ProductID.Equals(y.ProductID);

    public int GetHashCode(Product obj) => obj.ProductID.GetHashCode();
}