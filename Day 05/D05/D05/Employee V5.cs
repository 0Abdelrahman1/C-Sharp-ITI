
using System;
using System.Collections.Generic;
using System.Text;

namespace D05
{
    struct Employee
    {
        public int ID { get; internal init { field = value; } }
        public required string Name { get; internal set; }
        public decimal Salary { get; internal set { field = value >= 8000 ? value : 8000; } }

        public int EmpLvl { get; } = 4;


        public Employee(int _id, string _name, decimal _salary)
        {
            ID = _id;
            Name = _name;
            Salary = _salary;
        }

        public override string ToString()
        {
            return $"id:{ID} , name:{Name} , salary:{Salary}";
        }
    }
}