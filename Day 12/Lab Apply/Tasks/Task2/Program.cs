namespace Task2
{
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Uses Count to get the number of odd numbers in the array
            {
                Console.WriteLine("1. Uses Count to get the number of odd numbers in the array");
                Console.WriteLine("int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var r = Arr.Count(x => x % 2 == 1);
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 2. Return a list of customers and how many orders each has.
            {
                Console.WriteLine("2. Return a list of customers and how many orders each has.");
                var r = CustomerList.Select(c => new { CID = c.CustomerID, Count = c.Orders.Count()});
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 3. Return a list of categories and how many products each has
            {
                Console.WriteLine("3. Return a list of categories and how many products each has");
                var r = ProductList.CountBy(p => p.Category);
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 4. Get the total of the numbers in an array.
            {
                Console.WriteLine("4. Get the total of the numbers in an array.");
                Console.WriteLine("int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var r = Arr.Sum();
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            {
                Console.WriteLine("5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.Sum(s => s.Length);
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 6. Get the total units in stock for each product category.
            {
                Console.WriteLine("6. Get the total units in stock for each product category.");
                var r = ProductList.AggregateBy(p => p.Category, 0l, (acc, p) => acc + p.UnitsInStock);
                //var r = ProductList.GroupBy(p => p.Category).Select(g => new { category = g.Key, sum = g.Sum(p => p.UnitsInStock) });
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            {
                Console.WriteLine("7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.Min(s => s.Length);
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 8. Get the cheapest price among each category's products
            {
                Console.WriteLine("8. Get the cheapest price among each category's products");
                var r = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, Min = g.Min(p => p.UnitPrice) });
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 9. Get the products with the cheapest price in each category (Use Let)
            {
                Console.WriteLine("9. Get the products with the cheapest price in each category (Use Let)");
                var r = from p in ProductList
                        group p by p.Category into pc
                        let mnc = pc.Min(p => p.UnitPrice)
                        from pcc in pc
                        where pcc.UnitPrice == mnc
                        select pcc;

                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            {
                Console.WriteLine("10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.Max(s => s.Length);
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 11. Get the most expensive price among each category's products.
            {
                Console.WriteLine("11. Get the most expensive price among each category's products.");
                var r = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, HighestPrice = g.Max(p => p.UnitPrice) });
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 12. Get the products with the most expensive price in each category.
            {
                Console.WriteLine("12. Get the products with the most expensive price in each category.");
                var r = ProductList
                    .GroupBy(p => p.Category)
                    .Select(g => new { Category = g.Key, HighestPriceProducts = g.Where(p => p.UnitPrice == g.Max(pp => pp.UnitPrice))
                                                                                .ToList()});
                foreach (var group in r)
                    foreach (var prod in group.HighestPriceProducts)
                        Console.WriteLine($"\t{group.Category}::{prod}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            {
                Console.WriteLine("13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.Average(s => s.Length);
                Console.WriteLine(r);
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 14. Get the average price of each category's products.
            {
                Console.WriteLine("14. Get the average price of each category's products.");
                var r = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

        }
    }
}
