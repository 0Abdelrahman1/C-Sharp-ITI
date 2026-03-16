using System;
using System.Collections.Generic;
using System.Text;

namespace D15.Entities
{
    ///Mapping
    ///1.EF Convinsion
    ///2.Data Annotations
    ///3.Fluent API
    ///4.Configuration Class

    public class Teacher //Table: Teachers
    {
        public int Id { get; set; } //PK , Identity
        public required string FullName { get; set;  } //Not Null
        public int? Age { get; set; } // NULL
        public decimal Salary { get; set; } ///Not Null
        public string Address { get; set;  } //NULL

        public override string ToString()
            => $"ID:{Id} , Name:{FullName} , Age:{Age} , Salary:{Salary} , Address:{Address}";

        public virtual Subject Subject { get; set; }
    }
}
