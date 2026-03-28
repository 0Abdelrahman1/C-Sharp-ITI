using System;
using System.Collections.Generic;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    ///Link Table
    internal class EmployeeCustomerTips
    {
        public int EmployeeID { get; set; }
        public int CustomerID { get; set;  }

        public virtual Employee Employee { get; set; }
        public virtual Customer Customer { get; set; }
        public DateTime Date { get; set;  }
        public double TipAmount { get; set; }
    }
}
