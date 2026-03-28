using System;
using System.Collections.Generic;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    internal class Employee:Person
    {
        public double Salary { get; set;  }

        public virtual ICollection<EmployeeCustomerTips> CustomerTips { get; set; }

    }
}
