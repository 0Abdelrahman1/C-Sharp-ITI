namespace Task2
{
    internal class Program
    {
        internal class Math
        {
            public double Add(double a, double b) { return a + b; }
            public double Subtract(double a, double b) { return a - b; }
            public double Multiply(double a, double b) {return a * b; }
            public double Divide(double a, double b) { return a / b; }
        }
        static void Main(string[] args)
        {
            Math m = new Math();
            Console.WriteLine(m.Add(1, 2));
            Console.WriteLine(m.Subtract(1, 2));
            Console.WriteLine(m.Multiply(1, 2));
            Console.WriteLine(m.Divide(1, 2));
        }
    }
}
