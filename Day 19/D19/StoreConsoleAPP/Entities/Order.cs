using StoreConsoleAPP.ComplexTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    internal class Order
    {
        public long Id { get; set; }

        [Column(TypeName ="money")]
        public decimal OrderTotal { get; set; }

        public required FullAddress ShippingAddress { get; set; }
        public FullAddress BillingAddress { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual ICollection<Item> Items { get; set; }= new HashSet<Item>();
    }
}
