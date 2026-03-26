using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagementSystem.Entities.LoginManager
{
    public class Frontend
    {
        [Column("user_name")]
        [Key]
        [MaxLength(50)]        
        public string UserName { get; set; }

        [Column("pass_word")]
        [Required]
        [MaxLength(50)]
        public string PassWord { get; set; }
    }
}
