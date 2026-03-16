using HospitalConsoleAPP.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalConsoleAPP.Context
{
    public class HospitalContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer
            ("Data Source=.;Initial Catalog=SD46HospitalDB;Integrated Security=true;Encrypt=false;");

        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

    }
}
