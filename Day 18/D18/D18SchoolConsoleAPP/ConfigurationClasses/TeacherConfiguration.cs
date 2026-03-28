using D18SchoolConsoleAPP.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace D18SchoolConsoleAPP.ConfigurationClasses
{
    internal class TeacherConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> Builder)
        {
            Builder.ToTable("SchoolWorkers")
                                            .Ignore(T => T.CreatedOn)
                                            .HasKey(T => T.TID);

            //Builder.Property(T => T.FName)
            //                        .HasMaxLength(100)
            //                        .IsRequired(true);

            //Builder.Property(T => T.LName)
            //                        .HasMaxLength(100)
            //                        .IsRequired(true);

            Builder.Property(T => T.FullName)
                .HasMaxLength(150);

            Builder.Property(T => T.Salary)
                                    .HasColumnName("MonthlySalary")
                                    .HasColumnType("money");

            Builder.Property(T => T.Age)
                                            .HasDefaultValue(21);

            Builder.Property(T => T.Address)
                                            .HasMaxLength(200)
                                            .IsUnicode(true);
            ///Optional as RelationShip follows Convinsion
            Builder.HasOne(T => T.Department)
                    .WithMany(D => D.Teachers)
                    .HasForeignKey("DepartmentID")
                    .IsRequired()
                    .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
