using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Task4
{
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            {
                Console.WriteLine("1.Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.Any(s => s.Contains("ei"));
                Console.WriteLine(r.ToString());
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            {
                Console.WriteLine("2. Return a grouped a list of products only for categories that have at least one product that is out of stock.");
                var r = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0)).SelectMany(g => g);
                foreach (var i in r) Console.WriteLine(i);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            {
                Console.WriteLine("3. Return a grouped a list of products only for categories that have all of their products in stock.");
                var r = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock != 0)).SelectMany(g => g);
                foreach (var i in r) Console.WriteLine(i);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");
        }
    }
}