using Microsoft.EntityFrameworkCore;
using NorthWindConsoleAPP.Context;
using NorthWindConsoleAPP.Entities;


using NorthwindContext Context = new();

var Results = (
               //from P in Context.Products.Include(P => P.Category)/*.ThenInclude()*/ ///Eager Loading  
               //                         .Include(p => p.Supplier)  ///Eager Loading  
               from P in Context.Products  ///Lazy Loading
               where P.UnitsInStock == 0
               select P
               //select P.ProductName
               //select new { ID = P.ProductID, Name = P.ProductName }
               //select new {Name = P.ProductName , Category = P.Category.CategoryName ,
               //                 Supplier = P.Supplier.CompanyName}
              ).ToList();

//Results = Context.Products.Include(p => p.Category)
//                            .Include(P => P.Supplier)
//                            .Where(P => P.UnitsInStock == 0)
//                            .ToList();


ProcessProducts( Results  , Context);
//foreach (var P in Results)
//    Console.WriteLine(P);


static void ProcessProducts (List<Product> Prds , NorthwindContext Context)
{

    foreach (Product P in Prds)
    {
        //if (!Context.Entry(P).Reference(P => P.Category).IsLoaded)
        //    Context.Entry(P).Reference(P => P.Category).Load(); ///Extra trip to DB to Load object
        //if (Context.Entry(P).Reference(P => P.Supplier).IsLoaded == false)
        //    Context.Entry(P).Reference(P => P.Supplier).Load();///explicit Loading

        //Category C = P.Category;
        //if (Context.Entry(C).Collection(C => C.Products).IsLoaded == false)
        //        Context.Entry(C).Collection(C => C.Products).Load();

        ///Get Same Performance as Explicit Loading , Automatically 
        ///using LazyLoading Proxies 
        ///1.install package Microsoft.EntityFrameworkCore.Proxies 
        ///2. DBContext class , Configuration UseLazyLoadingProxies

        Console.WriteLine($"ProductName:{P.ProductName} , Category:{P.Category?.CategoryName ?? "NA"}" +
            $", Supplier:{P.Supplier?.CompanyName ?? "NA"}");
    }
}
