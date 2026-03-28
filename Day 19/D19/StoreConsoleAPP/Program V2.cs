using StoreConsoleAPP.ComplexTypes;
using StoreConsoleAPP.Context;
using StoreConsoleAPP.Entities;
using StoreConsoleAPP.Fakers;
using System;
using System.Collections.Generic;
using System.Text;
using Bogus;

namespace StoreConsoleAPP
{
    internal class Program_V2
    {
        public static void Main ()
        {
            using StoreContext Context = new StoreContext ();

            //FullAddress address = new() { ApNumber = 4, FloorNumber = 10, City = "Giza", FirstLine = "B148 Smart Village", Country = "EQ" };

            //Context.Items.Add(new() { ITemName = "Product 1", Price = 20 });
            //Context.Items.Add(new() { ITemName = "Product 2", Price = 30 });

            //Customer customer = new Customer()
            //{
            //     FullName = "Ahmed Ali",
            //      Address = address,
            //       LastVisit = DateTime.Now
            //};

            //Context.Add(customer);

            ////Context.People.OfType<Customer>()

            //Order order = new()
            //{ ShippingAddress = address, BillingAddress = address, Customer = customer, Items = Context.Items.Local.ToList(), OrderTotal = 500 };

            //Context.Add(order);

           

            var Customers = new CustomerFaker().Generate(100);

            Context.AddRange(Customers);

            Console.WriteLine(
                Context.SaveChanges()
                );

        }
    }
}
