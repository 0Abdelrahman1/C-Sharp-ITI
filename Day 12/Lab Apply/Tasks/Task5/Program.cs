namespace Task5
{
    using System.Collections.Immutable;
    using System.Diagnostics.CodeAnalysis;
    using static D11_Lab.ListGenerators;
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Use group by to partition a list of numbers by their remainder when divided by 5
            {
                Console.WriteLine("1.Use group by to partition a list of numbers by their remainder when divided by 5");
                var arr = Enumerable.Range(0, 15);
                var r = arr.GroupBy(x => x % 5).Select(g => new { Remainder = g.Key, Group = g });
                foreach (var i in r)
                {
                    Console.WriteLine($"Numbers with a remainder of {i.Remainder} when divided by 5:");
                    foreach (var j in i.Group)
                        Console.WriteLine($"\t{j}");
                    Console.WriteLine();
                }
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 2.Uses group by to partition a list of words by their first letter.(Use dictionary_english.txt for Input)
            {
                Console.WriteLine("2.Uses group by to partition a list of words by their first letter.(Use dictionary_english.txt for Input)");
                var arr = File.ReadAllLines("../../../../../Assignment Files/dictionary_english.txt").ToList();
                var r = arr.GroupBy(s => s[0]);
                foreach (var i in r) Console.WriteLine($"{i.Key}::{i.Count()}");
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");

            #region 3. Consider this Array as an Input (Use Group By with a custom comparer that matches words that are consists of the same Characters Together Result)
            {
                Console.WriteLine("3. Consider this Array as an Input (Use Group By with a custom comparer that matches words that are consists of the same Characters Together Result)");
                Console.WriteLine("string[] Arr = { \"from\", \"salt\", \"earn\", \"last\", \"near\", \"form\" };");
                string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
                var r = Arr.GroupBy(s => s, new StringEqualityComparer());
                foreach (var i in r)
                {
                    Console.WriteLine($"..");
                    foreach (var j in i)
                        Console.WriteLine($"{j}");
                }
            }
            #endregion

            Console.WriteLine("\n---------------------------------------------------------------------------------\n");
        }
    }
    public class StringEqualityComparer : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            var lx = x.ToCharArray();
            var ly = y.ToCharArray();
            lx.Sort();
            ly.Sort();
            return lx.SequenceEqual(ly);
        }

        public int GetHashCode(string obj)
        {
            var l = obj.ToCharArray();
            l.Sort();
            return new String(l).GetHashCode();
        }
    }
}


//LINQ - Grouping Operators

//1.Use group by to partition a list of numbers by their remainder when divided by 5
//Output: 
//Numbers with a remainder of 0 when divided by 5:
//0
//5
//10
//Numbers with a remainder of 1 when divided by 5:
//1
//6
//11
//Numbers with a remainder of 2 when divided by 5:
//7
//2
//12
//Numbers with a remainder of 3 when divided by 5:
//3
//8
//13
//Numbers with a remainder of 4 when divided by 5:
//4
//9
//14

//2.Uses group by to partition a list of words by their first letter.(Use dictionary_english.txt for Input)
//3. Consider this Array as an Input (Use Group By with a custom comparer that matches words that are consists of the same Characters Together Result)
//string[] Arr = { "from   ", " salt", " earn ", "  last   ", " near ", " form  " };

//...
//from 
//form 
//...
//salt
//last 
//...
//earn 
//near

