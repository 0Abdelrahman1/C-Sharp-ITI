namespace Task3
{
    using D11_Lab;
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Sort a list of products by name
            {
                Console.WriteLine("1. Sort a list of products by name");
                var Result = ProductList.OrderBy(p => p.ProductName);
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            {
                Console.WriteLine("2. Uses a custom comparer to do a case-insensitive sort of the words in an array.");
                Console.WriteLine("string[] Arr = { \"aPPLE\", \"AbAcUs\", \"bRaNcH\", \"BlUeBeRrY\", \"ClOvEr\", \"cHeRry\" };");
                string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                var Result = Arr.Order(new InsensitiveSortOfStrings());
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 3. Sort a list of products by units in stock from highest to lowest.
            {
                Console.WriteLine("3. Sort a list of products by units in stock from highest to lowest.");
                var Result = from p in ProductList
                             orderby p.UnitsInStock descending
                             select p;
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            {
                Console.WriteLine("4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.");
                Console.WriteLine("string[] Arr = { \"zero\", \"one\", \"two\", \"three\", \"four\", \"five\", \"six\", \"seven\", \"eight\", \"nine\" };");
                string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                var Result = from x in Arr
                             orderby x.Length, x
                             select x;
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            {
                Console.WriteLine("5. Sort first by word length and then by a case-insensitive sort of the words in an array.");
                Console.WriteLine("string[] words = { \"aPPLE\", \"AbAcUs\", \"bRaNcH\", \"BlUeBeRrY\", \"ClOvEr\", \"cHeRry\" };");
                string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                var Result = words.OrderBy(w => w.Length).ThenBy(w => w, new InsensitiveSortOfStrings());
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            {
                Console.WriteLine("6. Sort a list of products, first by category, and then by unit price, from highest to lowest.");
                var Result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            {
                Console.WriteLine("7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.");
                Console.WriteLine("string[] Arr = { \"aPPLE\", \"AbAcUs\", \"bRaNcH\", \"BlUeBeRrY\", \"ClOvEr\", \"cHeRry\" };");
                string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                var Result = Arr.OrderBy(w => w.Length).ThenByDescending(w => w, new InsensitiveSortOfStrings());
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            {
                Console.WriteLine("8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.");
                Console.WriteLine("string[] Arr = { \"zero\", \"one\", \"two\", \"three\", \"four\", \"five\", \"six\", \"seven\", \"eight\", \"nine\" };");
                string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
                var Result = Arr.Where(w => w?[1] == 'i').Reverse();
                foreach (var unit in Result)
                    Console.WriteLine($"\t{unit}");
            }
            #endregion

            Console.WriteLine("\n********************************************************************************************************\n");
        }
    }
    internal class InsensitiveSortOfStrings : Comparer<string>
    {
        public override int Compare(string? x, string? y) => x?.ToLower()?.CompareTo(y?.ToLower()??"")??0;
    }
}
