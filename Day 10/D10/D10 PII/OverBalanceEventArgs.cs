using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    internal class OverBalanceEventArgs:EventArgs
    {
        public decimal DiffAmount { get; set;  }
        public DateTime TimeStamp { get; } = DateTime.Now;
    }
}
