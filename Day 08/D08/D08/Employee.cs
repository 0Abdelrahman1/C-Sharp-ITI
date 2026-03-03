using System;
using System.Collections.Generic;
using System.Text;

namespace D08
{
    internal class Employee:IComparable<Employee>
    {
        public int ID { get; set;  }
        public string Name { get; set; }
        public decimal Salary { get; set;  }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;

            return Name.CompareTo(other.Name);
        }

        public override string ToString()
        {
            return $"ID:{ID} , Name:{Name}, Salary:{Salary}";
            
        }
    }
}
