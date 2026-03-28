using System;
using System.Collections.Generic;
using System.Text;

namespace D18SchoolConsoleAPP.Model
{
    //POCO Class
    //Plain Old CLR Object
    public class Teacher
    {
        public int TID { get; set;  }
        //public string FName { get; set; }
        //public string LName { get; set; }

        public string FullName { get; set; }
        public string Address { get; set;  }
        public decimal Salary { get;set;  }
        public int Age { get; set; }
        public DateTime CreatedOn { get; } = DateTime.Now;

        public virtual Department  Department { get; set; }

    }
}
