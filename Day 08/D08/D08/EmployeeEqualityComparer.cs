using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace D08
{
    internal class EmployeeEqualityComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            if (x != null && y != null)
            {
                if (x.GetType() != y.GetType()) return false;
                if ( object.ReferenceEquals(x,y)) return true;
                return x.ID == y.ID && x.Salary == y.Salary && x.Name == y.Name;
            }
            return false;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return HashCode.Combine(obj.ID, obj.Name, obj.Salary);
        }
    }
}
