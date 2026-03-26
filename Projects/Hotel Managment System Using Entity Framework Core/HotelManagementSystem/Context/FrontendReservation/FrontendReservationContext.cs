using HotelManagementSystem.Entities.FrontendReservation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HotelManagementSystem.Context.FrontendReservation
{
    public class FrontendReservationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
            => optionsBuilder
            .UseSqlServer(ConfigurationManager.ConnectionStrings[nameof(FrontendReservation)].ConnectionString)
            .UseLazyLoadingProxies();

        public virtual DbSet<Reservation> Reservations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.Entity<Reservation>().Property(R => R.Id).UseIdentityColumn(1011, 1);
    }
}
