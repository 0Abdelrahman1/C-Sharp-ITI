using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StoreConsoleAPP.ComplexTypes
{
    [ComplexType] ///will not be mapped directly to table , will not have a DBSet property in DBContext class
    internal class FullAddress
    {
        ///Has No Key , Keyless
        public byte ApNumber { get; set;  }
        public byte FloorNumber { get; set; }
        [MaxLength(100)]
        public required string FirstLine { get; set;  }
        [MaxLength(100)]
        public string? SecondLine { get; set;  }
        [MaxLength(10)]
        public string? ZipCode { get; set;  }
        [MaxLength(15)]
        public required string City { get; set; }
        [MaxLength(20)]
        public string? Country { get; set; }
    }
}
