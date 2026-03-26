
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using NorthWindConsoleAPP;
using NorthWindConsoleAPP.Context;
using NorthWindConsoleAPP.Entites;
using System.Drawing;
//using Point2D = (int XPos, int YPos);


///IDisposable Pattern
using NorthwindContext Context = new();

#region Query Local , Find
//var Results = Context.Products.Take(20).ToList();

//////var Results = Context.Products.IgnoreQueryFilters().Take(10).ToList();

//int R = Context.Products.Count();

//Console.WriteLine($"Number of Products From DB {R}");

//R = Context.Products.Local.Count();
//Console.WriteLine($"Number of Products From Local {R}");

////var PRd = Context.Products.Local.FirstOrDefault(P => P.UnitPrice > 35);

////Console.WriteLine(PRd?.ProductName);

////bool Flag = Context.Products.Local.Any(P => P.UnitsInStock == 0); ///Query Local , no DB Trip
//////Console.WriteLine(Flag);
////if (Flag)
////    Console.WriteLine("Product Out of Stock");
////else
////{
////    Flag = Context.Products.Any(P => P.UnitsInStock == 0);
////    if (Flag)
////        Console.WriteLine("Product Out of Stock");
////    else
////        Console.WriteLine("All Products in Stock");
////}

////foreach (var result in Results)
////    Console.WriteLine(result?.ProductName);

//var Prd = Context.Products.Find(15);
/////Check Local First if Found return from Local , No Extra Trips to DB
//Prd = Context.Products.Find(50);
/////If Not Found in Local , Query DB , if found return Object from DB , then will be added to local 
//Prd = Context.Products.Find(150);
///// if no Object found in DB with this PK , return null , no Exceptions will be thrown

//Console.WriteLine(Prd?.ProductName??"NA");

#endregion

#region ASNoTracking
//var Result = Context.Products.AsNoTracking().Where(P => P.UnitsInStock == 0).ToList();

//foreach (var result in Result)
//    Console.WriteLine(result.ProductName);

//Result[0].UnitsInStock = 1000;

//Console.WriteLine(Context.Entry(Result[0]).State);

//int R = Context.SaveChanges();

//Console.WriteLine($"{R} Rows Affected"); 
#endregion

#region IQueryable vs IEnumerable
//var Results = Context.Products.Where( P => P.UnitPrice >50)
//                            .OrderByDescending( p => p.UnitPrice )
//                            .Take(3)
//                            .Select(P=> new {P.ProductName, P.UnitPrice})
//                            .ToList();


///Bad Performance
//var Results = Context.Products.AsEnumerable() ///Get All PRoduct from DB into Memory 
//                    .TakeLast(10).ToList();  ///Continue in Memory (Local Seq)

//foreach (var result in Results)
//    Console.WriteLine(result.ProductName);

#endregion

#region Tuple Ex01
//var Emp1 = ("Ahmed", 30);

//Console.WriteLine(Emp1);
//Console.WriteLine(Emp1.GetType());

//Emp1.Item2++;
//Console.WriteLine(Emp1.Item1.ToUpperInvariant());
//Console.WriteLine(Emp1);

//(string, int) Emp2 = ("Sally", 28);

//if (Emp1.GetType() == Emp2.GetType())
//    Console.WriteLine("Same Type");

////var Results = Context.Products
////                .Select(P => new { Name = P.ProductName , Price = P.UnitPrice});
////                //.Select(P => P.ProductName);
////                //.Select(P => P);

//(string, int) GetPerson() => ("Ali", 40);

//var Emp3 = GetPerson();
//Console.WriteLine(Emp3);

//List<(string, int, decimal)> EmpList = new() { ("Ahmed", 30, 10000), ("Sayed", 35, 70000) };
//IEnumerable<(int,int)> PointList = Enumerable.Empty<(int,int)>();
//Dictionary<(Product, int), decimal> PrdDictiolnary = new();
//Task<(string , int)> T01;

//(string Name, int Age) Emp4 = ("Mona", 17);

//Console.WriteLine(Emp4.GetType());

//Console.WriteLine(Emp4.Name);
//Emp4.Item2 = 22;

//var Emp5 = (Name: "Fady", Age: 25);
//Console.WriteLine(Emp5.Name);
//Console.WriteLine(Emp5.Age);

/////Names Can be Inferred
//var Date = (DateTime.Now.Year, DateTime.Now.Month , DateTime.Now.Day);

//Console.WriteLine(Date.Month);

//Point P1 = (50, 50);
//Console.WriteLine(P1.XPos);

////Console.WriteLine(Results.GetType()); 
#endregion

#region Tuple Ex02 & Deconstruct Pattern
////Tuple<int, int> T; ///Legacy Calss in BCL System.Tuple
////(int,int) => ValueTuple , Value Type

////List<(string,decimal?)> GetPrds() => Context.Products.Select(P => ValueTuple.Create(P.ProductName, P.UnitPrice)).ToList();

////var PrdLst = GetPrds();

////Console.WriteLine(PrdLst.GetType());

////Tuple Support DeConstructor Pattern

//Rect R = new Rect(40, 20);

//Console.WriteLine(R);

////R.Deconstruct(out double RectW, out double RectH);
////R.Deconstruct(out double RectW, out _);

////double RectW, RectH;
/////Implicit Call to Deconstruct Function
//var (RectW, RectH) = R;

////var (RectW, _) = R;

//Console.WriteLine($"Width {RectW}");
//Console.WriteLine($"Hieght {RectH}");

////(string, int) Emp15 = ("Ali Ahmed", 40);
//var Emp15 = ("Ali Ahmed", 40);


//var (_Name, _Age) = Emp15;
/////Deconstruct Pattern

//Console.WriteLine(_Name);
//Console.WriteLine(_Age); 
#endregion

#region Record , struct Record

//Point P1 = new Point(10, 15);
//Console.WriteLine(P1.X);
//Console.WriteLine(P1);

//P1.X++;

//Point P2 = new(10, 15);

//if (P1==P2)
//    Console.WriteLine("EQ");

//if (P1.Equals(P2))
//    Console.WriteLine("EQ");

//Console.WriteLine(P1.GetHashCode());
//Console.WriteLine(P2.GetHashCode());

//Point P3 = P1 with { X = 15 };


//record Point { } //class
//record struct Point { } //Struct

///Generate new Class , Protected Copy ctor , Clone 
///override ToString , Equality Function (== , != , Equals , GetHashCode)
///Immutable DataType
//record Point
//{
//    public double X { get; init; }
//    public double Y { get; init; }

//    public Point(double _X , double _Y)=>(X ,Y)= (_X,_Y); 
//}

///Record + Primary Ctor
///public Init Only Properties : X , Y , Primary Ctor (Double ,Double)
///All of the Above 
//record Point(double X, double Y);

//class GamePlay
//{
//    Point P1;

//    public static Point Process(List<Point> points) => throw new NotImplementedException();
//} 
#endregion

#region FromSql , FromSQLRaw
//var PrdLimit = 15;
////var PrdLimit = new SqlParameter("PrdLimit", 15);

////var PrdPrice = 30;

//var ColumnName = "UnitsInStock";
//var ColValue = new SqlParameter("@ColValue", 30);
/////return Mapped Entity
//var Results = Context.Products.
//                    //FromSql($"Select * from Products")
//                    //FromSql($"Exec SelectALLProducts")
//                    //FromSql($"Select * from Products where UnitsInStock > {PrdLimit}") ///Safe from SQL Injection
//                    //FromSql($"Exec SelectAllProductsAbovePrice @PrdUnitPrice={PrdPrice}")
//                    ///Dynamic Query
//                    //FromSqlRaw($"Select * from Products where {ColumnName}>@ColValue",ColValue)

//                    ///Compose LINQ Query on Top of FromSql
//                    // FromSql($"Select * from Products")
//                    //.Where(P => P.CategoryId ==3)
//                    //.OrderByDescending(P => P.UnitPrice)

//                    //  FromSql($"Exec SelectALLProducts") ///Not Valid in SQL Server , use SP name in From 
//                    //  .AsEnumerable() ///Get Output from FromSql into Memory
//                    //.Where(P => P.CategoryId == 3) ///Continue as Local Sequence
//                    //.OrderByDescending(P => P.UnitPrice)

//                    //Include Related Data
//                    //FromSql($"Select * from Products").Include(P=> P.Category).Include(P=> P.Supplier)

//                    .ToList();
/////aLL entities returned by FromSql , FromSqlInterploated , FromSqlRaw : Tracked Entities

//Results[0].ProductName += ",,";

//int R = Context.SaveChanges();
//Console.WriteLine(R);

//foreach ( var result in Results )
//    Console.WriteLine(result.ProductName); 
#endregion

///Return Scaler Value
//var PrdLimit = 0;
//var Result = Context.Database.SqlQuery<int>($"Select Count(*) as Value from Products where UnitsInStock ={PrdLimit}").First();

//Console.WriteLine(Result);

var NameList = Context.Database.SqlQuery<string>($"Select ProductName from Products").ToList();

Console.WriteLine(NameList.Count);

///Non Query
var PrdName = "New Prd";
var PrdID = 1;
int R = Context.Database.ExecuteSql($"UPDATE Products SET ProductName = {PrdName} WHERE  (ProductID = {PrdID}) ");


var Results = Context.Database.SqlQuery<TenMostExpensiveProductsResult>($"exec [Ten Most Expensive Products]").ToList();

foreach (var item in Results)
{
    Console.WriteLine(item);
}

record TenMostExpensiveProductsResult(string TenMostExpensiveProducts, decimal UnitPrice);