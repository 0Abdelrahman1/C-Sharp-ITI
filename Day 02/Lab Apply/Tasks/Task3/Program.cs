using System.Diagnostics;
namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int ans = 0;
                for (int i = 1; i < 1e8; i++)
                {
                    string x = i.ToString();
                    for (int j = 0; j < x.Length; j++)
                        ans += x[j] == '1' ? 1 : 0;
                }
                Console.WriteLine($"# of '1's in range: {ans}");
                sw.Stop();
                Console.WriteLine($"Time taken for case 1: {sw.ElapsedMilliseconds}ms");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int ans = 0;
                for (int i = 1; i < 1e8; i++)
                {
                    int x = i;
                    while (x > 0)
                    {
                        ans += (x % 10 == 1 ? 1 : 0);
                        x /= 10;
                    }
                }
                Console.WriteLine($"# of '1's in range: {ans}");
                sw.Stop();
                Console.WriteLine($"Time taken for case 2: {sw.ElapsedMilliseconds}ms");
            }
            Console.WriteLine("------------------------------------------------------------------------------");
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                int ans = 0;
                int[] dp = new int[9];
                dp[1] = 1;
                for (int i = 2, p10 = 10; i < 9; i++, p10 *= 10)
                    dp[i] = 10 * dp[i - 1] + p10;
                ans = dp[8];
                Console.WriteLine($"# of '1's in range: {ans}");
                sw.Stop();
                Console.WriteLine($"Time taken for case 3: {sw.ElapsedMilliseconds}ms");
            }
        }
    }
}
