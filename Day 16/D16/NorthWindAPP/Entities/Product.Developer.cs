using System;
using System.Collections.Generic;
using System.Text;

namespace NorthWindAPP.Entities
{
    public partial class Product
    {
        public override string ToString()
            => $"ID:{ProductId} , Name:{ProductName} ,Price:{UnitPrice} , Stock:{UnitsInStock}" +
            $"Category:{Category?.CategoryName??"NA"} ,Supplier:{Supplier?.CompanyName??"NA"}";
    }
}
