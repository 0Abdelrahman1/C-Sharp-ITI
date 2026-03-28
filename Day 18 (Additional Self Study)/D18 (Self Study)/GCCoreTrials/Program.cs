namespace GCCoreTrials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using TempFile T1 = new TempFile();

            T1.DoSomeFileWork();

            //T1.Dispose();
            //T1 = null;


            Console.WriteLine("Continue Program");

            GC.Collect();

            string Str = Console.ReadLine();

            Console.WriteLine(Str.ToLower());
        }
    }
}
