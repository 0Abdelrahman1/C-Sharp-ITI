using Microsoft.EntityFrameworkCore;
using StoreConsoleAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreConsoleAPP.Context
{
    internal class StoreContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SD46StoreDB;Integrated Security=true;Encrypt=false");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<EmployeeCustomerTips>().HasKey(ET => new { ET.EmployeeID, ET.CustomerID });

            ///Complex Type
            modelBuilder.Entity<Person>().ComplexProperty(P => P.Address);
            ///One To Many RelationShip
            modelBuilder.Entity<Customer>().HasMany(C => C.Orders).WithOne(O => O.Customer);

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public  virtual DbSet<Item> Items { get; set; }
    }
}
