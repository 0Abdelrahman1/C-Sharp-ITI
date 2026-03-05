namespace Task4
{
    using D11_Lab;
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Return a sequence of just the names of a list of products.
            {
                Console.WriteLine("1. Return a sequence of just the names of a list of products.");
                var Result = ProductList.Select(p => p.ProductName);
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            {
                Console.WriteLine("2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).");
                Console.WriteLine("string[] words = { \"aPPLE\", \"BlUeBeRrY\", \"cHeRry\" };");
                string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
                var Result = from w in words
                             select new { lowerVersion = w.ToLower(), upperVersion = w.ToUpper() };
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            {
                Console.WriteLine("3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.");
                var Result = ProductList.Select(p => new { ProductName = p.ProductName , Price = p.UnitPrice }) ;
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 4. Determine if the value of ints in an array match their position in the array.
            {
                Console.WriteLine("4. Determine if the value of ints in an array match their position in the array.");
                Console.WriteLine("    int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var Result = Arr.Select((x, i) => x == i).ToList();
                Console.WriteLine($"\tNumber:In-place?");
                for (int i = 0; i < Arr.Length; i++)
                    Console.WriteLine($"\t{Arr[i]}: {Result[i]}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            {
                Console.WriteLine("5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.");
                Console.WriteLine("int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };");
                Console.WriteLine("int[] numbersB = { 1, 3, 5, 7, 8 };");
                int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                int[] numbersB = { 1, 3, 5, 7, 8 };
                var Result = numbersA.Select(a => new { first = a, second = numbersB.Where(b => a < b) });
                Console.WriteLine($"\tPairs where a < b:");
                foreach (var subResult in Result)
                    foreach (var b in subResult.second)
                        Console.WriteLine($"\t{subResult.first} is less than {b}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 6. Select all orders where the order total is less than 500.00.
            {
                Console.WriteLine("6. Select all orders where the order total is less than 500.00.");
                var Result = CustomerList.Select(c => c.Orders.Where(o => o.Total < 500.00m));
                foreach (var ords in Result)
                    foreach (var o in ords)
                    Console.WriteLine($"\t{o}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 7. Select all orders where the order was made in 1998 or later.
            {
                Console.WriteLine("7. Select all orders where the order was made in 1998 or later.");
                var Result = CustomerList.Select(c => c.Orders.Where(o => o.OrderDate.Year >= 1998));
                foreach (var ords in Result)
                    foreach (var o in ords)
                    Console.WriteLine($"\t{o}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");



        }
    }
}
