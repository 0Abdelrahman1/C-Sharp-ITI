using System;
using System.Collections.Generic;
using System.Text;

namespace D10
{
    ///Publisher
    ///Open for Extension , Closed for Modification
    internal class Ball
    {
        public int ID { get; init; }

        Location location;
        public Location Location
        {
            get => location;
            set
            {
                if (value != location)
                {
                    Location Delta = value - location;
                    location = value;
                    ///4. Notify Subscribers 
                    ///Loop on ALL Subscribers in event InvocationList, Invoke (Call) Subscriber CallBackMethod
                    LocationChanged?.Invoke(Delta); ///Safe
                }
            }
        }

        public override string ToString() => $"Ball {ID} at Locaiton {location}";

        ///1.event Declaration
        //public event Action LocationChanged;
        public event Action<Location> LocationChanged;


    }
}
