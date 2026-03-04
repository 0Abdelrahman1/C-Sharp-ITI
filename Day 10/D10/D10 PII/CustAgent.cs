using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    internal class CustAgent
    {
        public string Name { get; set; }

        ///CallBackMethod
        internal void ContactClient (object sender , EventArgs e)
        {
            if ((sender is BankAccount BC) && (BC != null))
                Console.WriteLine($"Agent {Name} Contacting Customer {BC.CustomerName}");
        }
    }
}
