using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalConsoleAPP.Entities
{
    [Table("Specializations")]
    public class Department
    {
        public int Id { get; set; }

        [StringLength(25,MinimumLength =3)]
        public string Name { get; set; }

        public virtual ICollection<Doctor>  Doctors { get; set; } = new HashSet<Doctor>();

    }
}
