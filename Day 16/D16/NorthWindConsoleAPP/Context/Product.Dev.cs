using NorthWindConsoleAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindConsoleAPP.Entities
{
    public partial class Product
    {
        public override string ToString()
            => $"ID:{ProductID} , Name:{ProductName} ,Price:{UnitPrice} , Stock:{UnitsInStock}," +
            $"Category:{Category?.CategoryName ?? "NA"} ,Supplier:{Supplier?.CompanyName ?? "NA"}";
    }
}
