namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sz = Convert.ToInt32(Console.ReadLine()), ans = 0;
            int[] a = new int[sz];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < sz; i++)
            {
                a[i] = Convert.ToInt32(input[i]);
                for (int j = 0; j < i; j++)
                    if (a[j] == a[i])
                    {
                        ans = Math.Max(i - j - 1, ans);
                        break;
                    }
            }
            Console.WriteLine(ans);
        }
    }
}
