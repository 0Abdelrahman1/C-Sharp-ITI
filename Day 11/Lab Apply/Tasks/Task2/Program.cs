namespace Task2
{
    using D11_Lab;
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get first Product out of Stock 
            {
                Console.WriteLine("1. Get first Product out of Stock");
                var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
                Console.WriteLine("\t" + (Result?.ToString() ?? "NA"));
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            {
                Console.WriteLine("2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.");
                var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
                Console.WriteLine("\t" + (Result?.ToString() ?? "NA"));
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 3. Retrieve the second number greater than 5 
            {
                Console.WriteLine("3. Retrieve the second number greater than 5 ");
                Console.WriteLine("int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int?[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var Result = Arr.Where(x => x > 5).ElementAtOrDefault(1);
                Console.WriteLine("\t" + (Result?.ToString() ?? "NA"));
            }
            #endregion


        }
    }
}
