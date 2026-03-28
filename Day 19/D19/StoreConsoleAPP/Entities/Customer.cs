using System;
using System.Collections.Generic;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    internal class Customer:Person
    {
        public DateTime LastVisit { get; set; }

        public virtual List<Order> Orders { get; set; } = new();
        public virtual ICollection<EmployeeCustomerTips> CustomerTips { get; set; }

    }
}
