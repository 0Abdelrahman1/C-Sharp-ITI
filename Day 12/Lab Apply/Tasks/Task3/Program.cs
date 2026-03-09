namespace Task3
{
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get the first 3 orders from customers in Washington
            {
                Console.WriteLine("1. Get the first 3 orders from customers in Washington");
                var r = CustomerList.Where(c => c.Region == "WA").Select(c => c.Orders.Take(0..3));
                foreach (var i in r)
                {
                    foreach (var o in i)
                        Console.WriteLine($"\t{o}");
                    Console.WriteLine("-------------------");
                }
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 2. Get all but the first 2 orders from customers in Washington.
            {
                Console.WriteLine("2. Get all but the first 2 orders from customers in Washington.");
                var r = CustomerList.Where(c => c.Region == "WA").Select(c => c.Orders.Skip(2));
                foreach (var i in r)
                {
                    foreach (var o in i)
                        Console.WriteLine($"\t{o}");
                    Console.WriteLine("-------------------");
                }
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            {
                Console.WriteLine("3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.");
                Console.WriteLine("int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var r = numbers.TakeWhile((x, i) => x >= i);
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            {
                Console.WriteLine("4.Get the elements of the array starting from the first element divisible by 3.");
                Console.WriteLine("int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var r = numbers.SkipWhile(x => x % 3 != 0);
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 5.Get the elements of the array starting from the first element less than its position.
            {
                Console.WriteLine("5.Get the elements of the array starting from the first element less than its position.");
                Console.WriteLine("int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };");
                int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                var r = numbers.SkipWhile((x, i) => x >= i);
                foreach (var i in r) Console.WriteLine($"\t{i}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

        }
    }
}


