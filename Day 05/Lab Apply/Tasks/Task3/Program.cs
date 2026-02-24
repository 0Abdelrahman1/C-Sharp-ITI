namespace Task3
{
    internal class Program
    {
        internal static class Math
        {
            public static double Add(double a, double b) { return a + b; }
            public static double Subtract(double a, double b) { return a - b; }
            public static double Multiply(double a, double b) { return a * b; }
            public static double Divide(double a, double b) { return a / b; }
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Add(1, 2));
            Console.WriteLine(Math.Subtract(1, 2));
            Console.WriteLine(Math.Multiply(1, 2));
            Console.WriteLine(Math.Divide(1, 2));
        }
    }
}
