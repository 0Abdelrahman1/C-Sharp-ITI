using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace D15.Entities
{
    [Table("Topics")]
    public class Subject
    {
        [Key] //PH , Identity
        public int SID { get; set; }
        [StringLength(100)]
        public required string SubjectName { get; set; }
        [NotMapped]
        public DateTime TimeStamp { get; } = DateTime.Now;

        public virtual ICollection<Teacher> Teachers { get; set; } = new HashSet<Teacher>();
    }
}
