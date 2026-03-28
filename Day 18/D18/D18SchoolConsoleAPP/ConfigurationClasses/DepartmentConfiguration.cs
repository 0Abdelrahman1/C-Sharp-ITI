using D18SchoolConsoleAPP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D18SchoolConsoleAPP.ConfigurationClasses
{
    internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> Bld)
        {
            Bld.Property(D => D.Name)
               .IsRequired()
               .HasMaxLength(50);

            Bld.Property(D => D.Location)
            .HasMaxLength(200)
            .IsUnicode();
        }
    }
}
