using System;
using System.Collections.Generic;
using System.Text;

namespace D04_PII
{
    internal struct Employee
    {
        public int ID;
        
        string FullName;
        public string GetName () { return FullName; }
        internal void SetName (string name) { FullName = name.Length <= 50 ? name : name.Substring(0, 50); }
        
        decimal salary;

        public decimal Salary
        {
            get
            { return salary; }
            internal set
            { salary = value >= 8000 ? value : 8000; }
        }

        public decimal Taxes
        { get { return 0.15M * salary; } }


        public Employee(int _ID , string _Name , decimal _salary)
        {
            ID = _ID ;
            FullName = _Name ;
            salary = _salary ;
        }

        public override string ToString()
        {
            return $"ID:{ID} , Name:{FullName} , Salary:{salary}";
        }
    }
}
