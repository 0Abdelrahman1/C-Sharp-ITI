using System.Security.Cryptography;

namespace Task4
{
    internal class Program
    {
        public enum Type { Ethernet, Token_Ring };
        public class NIC
        {
            NIC() { }
            public static NIC singleton { get; set; } = new NIC();
            public string Manufacture { get; set; }
            public string MACAddress { get; set; }
            public Type Type { get; set; }

        }

        static void Main(string[] args)
        {
            //NIC nic = new NIC(); //invalid
            NIC p1 = NIC.singleton;
            NIC p2 = NIC.singleton;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
        }
    }
}
