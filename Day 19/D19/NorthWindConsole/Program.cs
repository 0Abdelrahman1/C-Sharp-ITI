using Microsoft.EntityFrameworkCore;
using NorthWindConsole.Context;

namespace NorthWindConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using NorthwindContext Context = new();

            //Context.Products
            //    .Where( P=> P.UnitPrice < 50)
            //    //.ExecuteUpdate()
            //    .ExecuteUpdate( U => U.SetProperty(P => P.UnitPrice , P=> P.UnitPrice + 2)); ///Execute Directly on DB

            var Prd = Context.Products.FirstOrDefault(P => P.UnitPrice < 10);

            Context.Products.Remove(Prd);

            Console.WriteLine(Context.SaveChanges()); //return Zero

        }
    }
}
