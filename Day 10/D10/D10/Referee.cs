using System;
using System.Collections.Generic;
using System.Text;

namespace D10
{
    //Subsc.
    internal class Referee
    {
        public string Name { get; set;  }

        public override string ToString() => Name;

        ///CallBackMethod 
        //internal void Look() => Console.WriteLine($"Refree {Name} is Looking at the Ball");
        internal void Look(Location D) => Console.WriteLine($"Refree {Name} is Looking at the Ball");

    }
}
