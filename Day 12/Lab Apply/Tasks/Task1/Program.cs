namespace Task1
{
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Find the unique Category names from Product List
            {
                Console.WriteLine("1. Find the unique Category names from Product List");
                var r = ProductList.Select(p => p.Category).Distinct();
                foreach (var i in r)
                    Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 2. Produce a Sequence containing the unique first letter from both product and customer names.
            {
                Console.WriteLine("2. Produce a Sequence containing the unique first letter from both product and customer names.");
                var r = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CompanyName[0]));
                foreach (var i in r)
                    Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 3. Create one sequence that contains the common first letter from both product and customer names.
            {
                Console.WriteLine("3. Create one sequence that contains the common first letter from both product and customer names.");
                var r = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CompanyName[0]));
                foreach (var i in r)
                    Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            {
                Console.WriteLine("4. Create one sequence that contains the first letters of product names that are not also first letters of customer names.");
                var r = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CompanyName[0]));
                foreach (var i in r)
                    Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates
            {
                Console.WriteLine("5. Create one sequence that contains the last Three Characters in each names of all customers and products, including any duplicates");
                var r = ProductList.Select(p => p.ProductName[^3..]).Concat(CustomerList.Select(c => c.CompanyName[^3..]));
                foreach (var i in r)
                    Console.WriteLine($"\t{i}");
            }
            #endregion
        }
    }
}
