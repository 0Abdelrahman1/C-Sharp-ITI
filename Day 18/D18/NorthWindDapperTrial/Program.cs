using Microsoft.Data.SqlClient;
using System.Data.Common;
using Dapper;
using NorthWindDapperTrial;

//DbConnection CN = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True;Encrypt=false");

ProductManager manager = new();

////var Prds = manager.GetALL();

////foreach (var item in Prds)
////    Console.WriteLine(item.ProductName);

//Product Prd = manager.GetByID(5);

//Prd.UnitPrice += 30;

//bool Flag = manager.Update(Prd);
//Console.WriteLine(Flag);


//Product P = new Product()
//{
//    ProductName = "DapperPrd",
//    UnitPrice = 20,
//    CategoryId = 3,
//    Discontinued = false,
//    QuantityPerUnit = "1",
//    ReorderLevel = 30,
//    SupplierId = 1,
//    UnitsInStock = 100,
//    UnitsOnOrder = 1
//};
//Console.WriteLine(  
//manager.Add(P));

//Console.WriteLine(manager.Delete(3082));
