using System.Numerics;
using System.Runtime.Intrinsics.Arm;

namespace Task4
{
    internal class Program
    {
        public static float PresentList(float budget, float bagVolume, int people, int Npresents, float[] presentVolume, float[] presentPrice)
        {
            float ans = 0;
            List<List<float>> pi = new();
            for (int msk = 0; msk < 1 << Npresents; ++msk)
            {
                float cost = 0, taken = 0, volume = 0;
                List<List<float>> tmp = new();
                for (int b = 0; b < Npresents; ++b)
                    if ((msk >> b & 1) == 1)
                    {
                        cost += presentPrice[b];
                        taken++;
                        volume += presentVolume[b];                                  
                    }
                if (volume <= bagVolume && taken % people == 0 && cost <= budget)
                    ans = Math.Max(ans, cost);
            }
            return ans;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sample Test Case Output:");
            Console.WriteLine(PresentList(183.23f, 64.11f, 7, 12,
                new float[]
                {
                    4.53f , 9.11f , 4.53f , 6.00f , 1.04f , 0.87f , 2.57f , 19.45f , 65.59f , 14.14f , 16.66f , 13.53f
                },
                new float[]
                {
                    12.23f, 45.03f, 12.23f, 32.93f, 6.99f, 0.46f, 7.34f, 65.98f, 152.13f, 7.23f, 10.00f, 25.25f
                }).ToString("C2"));
            Console.WriteLine("----------------------------------------------------------------------------------------------------");

            
            float budget = float.Parse(Console.ReadLine());
            float bagVolume = float.Parse(Console.ReadLine());
            int people = Convert.ToInt32(Console.ReadLine());
            int Npresents = Convert.ToInt32(Console.ReadLine());
            float[] presentVolume = new float[Npresents], presentPrice = new float[Npresents];
            string[] input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
                presentVolume[i] = float.Parse(input[i]);
            input = Console.ReadLine().Split(' ');
            for (int i = 0; i < input.Length; i++)
                presentPrice[i] = float.Parse(input[i]);

            Console.WriteLine("Maximum Money Spend is: ");
            Console.WriteLine(PresentList(budget, bagVolume, people, Npresents, presentVolume, presentPrice).ToString("C2"));
        }
    }
}
