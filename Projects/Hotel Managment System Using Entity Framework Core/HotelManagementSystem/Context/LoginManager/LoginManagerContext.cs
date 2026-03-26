using HotelManagementSystem.Entities.FrontendReservation;
using HotelManagementSystem.Entities.LoginManager;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HotelManagementSystem.Context.LoginManager
{
    public class LoginManagerContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
            .UseSqlServer(ConfigurationManager.ConnectionStrings[nameof(LoginManager)].ConnectionString)
            .UseLazyLoadingProxies();

        public virtual DbSet<Frontend> Frontends { get; set; }
        public virtual DbSet<Kitchen> Kitchens { get; set; }
    }
}
