using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    
    enum Category:byte { Food , Beverage , Stationary , Other}

    internal class Item
    {
        public int Id { get; set; }
        [MaxLength(40)]
        public required string ITemName { get;set;  }
        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        public Category ItemCategory { get; set;  }

        public virtual ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
