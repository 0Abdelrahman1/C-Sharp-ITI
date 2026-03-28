using StoreConsoleAPP.ComplexTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StoreConsoleAPP.Entities
{
    internal abstract class Person
    {
        public int Id { get; set; }
        
        [MaxLength(100)]
        public string FullName { get; set;  }

        public FullAddress Address { get; set;  }
    }
}
