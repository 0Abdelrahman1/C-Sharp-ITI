using Microsoft.EntityFrameworkCore;
using NorthWindConsole;
using NorthWindConsole.Context;

using NorthwindContext Context = new();

var Procs = new NorthwindContextProcedures(Context);

var ResultsTask =  Procs.TenMostExpensiveProductsAsync(); ///Non Blocking

Console.WriteLine("Doing Something Else");

var Result = ResultsTask.Result; ///Blocking


foreach (var result in Result)
    Console.WriteLine($"{result.TenMostExpensiveProducts} , {result.UnitPrice}");


var R = await Procs.UpdateProductPriceAsync(66, 1);

Console.WriteLine(R);

///Get ConnectionString
//Context.Database.GetDbConnection();
    