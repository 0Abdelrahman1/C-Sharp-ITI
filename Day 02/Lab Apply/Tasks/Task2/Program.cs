namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length >> 1; i++)
            {
                string tmp = input[i];
                input[i] = input[^(i + 1)];
                input[^(i + 1)] = tmp;
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
