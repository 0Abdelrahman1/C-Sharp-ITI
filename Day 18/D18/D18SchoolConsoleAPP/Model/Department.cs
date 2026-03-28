using System;
using System.Collections.Generic;
using System.Text;

namespace D18SchoolConsoleAPP.Model
{
    public class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Location { get; set;  }
        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();

    }
}
