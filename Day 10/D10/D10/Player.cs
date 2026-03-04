using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace D10
{
    ///Subscriber
    internal class Player
    {
        public required string Name { get; set; }
        public required string Team { get; set; }

        ///2.Declare CallBack Method Matching event Delegate Signature
        //public void Run() => Console.WriteLine($"Player {Name} is Running .....");

        public void Run(Location D) => Console.WriteLine($"Player {Name} is Running with Delta {D}.....");


        public override string ToString() => $"Player:{Name} , Team {Team}";
    }
}
