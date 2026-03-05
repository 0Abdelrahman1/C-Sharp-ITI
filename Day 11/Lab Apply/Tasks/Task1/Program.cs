namespace Task1
{
    using D11_Lab;
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Find all products that are out of stock.
            {
                Console.WriteLine("1. Find all products that are out of stock.");
                var Result = ProductList.Where(p => p.UnitsInStock == 0);
                foreach (var Unit in Result)
                    Console.WriteLine("\t" + Unit);
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            {
                Console.WriteLine("2. Find all products that are in stock and cost more than 3.00 per unit.");
                var Result = from p in ProductList
                             where p.UnitPrice > 3 && p.UnitsInStock > 0
                             select p;
                foreach (var Unit in Result)
                    Console.WriteLine("\t" + Unit);
            } 
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 3. Returns digits whose name is shorter than their value.
            {
                Console.WriteLine("3. Returns digits whose name is shorter than their value.");
                string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                var Result = Arr.Where((s, i) => s.Length < i);
                foreach (var num in Result)
                    Console.WriteLine("\t" + num);
            } 
            #endregion
        }
    }
}
