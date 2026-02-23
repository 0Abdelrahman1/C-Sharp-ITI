using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    internal class Person
    {
        public string PID { get; set; }

        public string FName { get; set; }

        public string LName { get; set;  }

        public decimal AnnualSalary { get; set; }

        public static explicit operator Person (Employee E)
        {
            var Names =  E.Name.Split(' ');
            return new Person()
            {
                PID = E.ID.ToString(),
                FName = Names.Length > 0 ? Names[0] : "NA",
                LName = Names.Length > 1 ? Names[1] : "NA",
                AnnualSalary = E.Salary * 12

            };
        }
    }
}
