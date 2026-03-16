using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HospitalConsoleAPP.Entities
{
    public class Doctor
    {
        [Key]
        public int DocID { get; set;  }
        
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }

        [Column(TypeName ="Money")]
        public decimal Salary { get; set;  }
        
        [Range(20,99)]
        public byte Age { get; set; }

        [NotMapped]
        public DateTime CreatedOn { get; } = DateTime.Now;

        public virtual Department Department { get; set; }

    }
}
