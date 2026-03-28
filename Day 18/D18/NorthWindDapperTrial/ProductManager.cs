using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;

namespace NorthWindDapperTrial
{
    public class ProductManager : IManager<Product>
    {
        DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false");

        public bool Add(Product item)
        {
            try
            {
                return CN.Execute("""
                    INSERT INTO Products
                    (ProductName, SupplierID, CategoryID, QuantityPerUnit, UnitPrice, UnitsInStock, UnitsOnOrder, ReorderLevel, Discontinued)
                    VALUES (@ProductName,@SupplierID,@CategoryID,@QuantityPerUnit,@UnitPrice,@UnitsInStock,@UnitsOnOrder,@ReorderLevel,@Discontinued)
                    """, item) > 0;
            }
            catch
            {
                return false;
            }
            
        }

        public bool Delete(long ID)
            => CN.Execute("DeleteProductByID",
                new { ProductID = ID }, commandType: CommandType.StoredProcedure)> 0;

        public List<Product> GetALL()
            => CN.Query<Product>("Select * from Products").AsList();

        public Product GetByID(long ID)
            => CN.QueryFirstOrDefault<Product>("Select * from Products where ProductID = @ProductID",
                new { ProductID = ID }) ?? new Product();

        public bool Update(Product item)
            => CN.Execute("[PrdUpdateCommand]", item, commandType: CommandType.StoredProcedure) > 0;
    }
}
