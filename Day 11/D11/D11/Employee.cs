using System;
using System.Collections.Generic;
using System.Text;

namespace D11
{
    ///Immutable Type
    internal class Employee
    {
        public required int ID { get; init; }
        public required string Name { get; init; }
        public required decimal Salary { get; init; }

        public required Department Department { get; init; }

        public override string ToString()
            => $"ID:{ID} Name:{Name} Salary:{Salary} Dept:{Department}";

        public override int GetHashCode() => HashCode.Combine(ID, Name, Salary);

        public override bool Equals(object? obj)
        {
            if ((obj is Employee Right) && (obj != null) && (obj.GetType() == this.GetType()))
            {
                if (Object.ReferenceEquals(this, Right)) return true;
                return ID == Right.ID && Salary == Right.Salary && Name == Right.Name;
            }
            return false;

        }
    }

    class Department : IComparable<Department>
    {
        public int ID { get; init; }
        public string Name { get; init; }
        public DateTime OpenDate { get; init; }

        public int CompareTo(Department? other)
        {
            if (other == null) return 1;
            return Name.CompareTo(other.Name);
        }

        public override string ToString() => $"{Name} Created At {OpenDate.ToShortDateString()}";
    }

    class DepartmentCreationDateComparer : IComparer<Department>
    {
        public int Compare(Department? x, Department? y)
        {
            return x?.OpenDate.CompareTo(y.OpenDate) ?? -1;
        }
    }
}
