using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace D18SchoolConsoleAPP.Model
{
    abstract public class Person
    {
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }

        public bool IsEnrolled { get; set; }
    }

    public class FullTimeStudent : Person
    {
        public FullTimeStudent()=> IsEnrolled = true;
        [Range(1,12)]
        public byte Grade { get;set;  }
        public DateOnly EnrollmentDate { get; set;  }
    }

    public class WalkInStudent :Person
    {
        [StringLength(10,MinimumLength =2)]
        public string CourseCode { get; set;  }
        public WalkInStudent()=> IsEnrolled= false;
    }
}
