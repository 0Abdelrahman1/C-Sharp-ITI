using D18SchoolConsoleAPP.ConfigurationClasses;
using D18SchoolConsoleAPP.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace D18SchoolConsoleAPP.Context
{
    internal class SchoolContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=D18SchoolDB;Integrated Security=true;Encrypt=false");
    
        public virtual DbSet<Teacher> Teachers { get; set; }
        public virtual DbSet<Department> Departments { get; set; }

        //public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<WalkInStudent> WalkInStudents { get; set; }
        public virtual DbSet<FullTimeStudent> FullTimeStudents { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Fluent API Old Style
            //modelBuilder.Entity<Teacher>().ToTable("SchoolWorkers")
            //                                .Ignore(T => T.CreatedOn)
            //                                .HasKey(T => T.TID);

            //modelBuilder.Entity<Teacher>().Property(T => T.FName)
            //                                .HasMaxLength(100)
            //                                .IsRequired(true);

            //modelBuilder.Entity<Teacher>().Property(T => T.LName)
            //                                .HasMaxLength(100)
            //                                .IsRequired(true);

            //modelBuilder.Entity<Teacher>().Property(T => T.Salary)
            //                                .HasColumnName("MonthlySalary")
            //                                .HasColumnType("money");

            //modelBuilder.Entity<Teacher>().Property(T => T.Age)
            //                                .HasDefaultValue(21);

            //modelBuilder.Entity<Teacher>().Property(T => T.Address)
            //                                .HasMaxLength(200)
            //                                .IsUnicode(true);
            #endregion

            #region 3. Fluent API

            ///Newer Style for Fluent API
            //modelBuilder.Entity<Teacher>(Builder =>
            //    {
            //        Builder.ToTable("SchoolWorkers")
            //                                 .Ignore(T => T.CreatedOn)
            //                                 .HasKey(T => T.TID);

            //        Builder.Property(T => T.FName)
            //                                .HasMaxLength(100)
            //                                .IsRequired(true);

            //        Builder.Property(T => T.LName)
            //                                .HasMaxLength(100)
            //                                .IsRequired(true);

            //        Builder.Property(T => T.Salary)
            //                                .HasColumnName("MonthlySalary")
            //                                .HasColumnType("money");

            //        Builder.Property(T => T.Age)
            //                                        .HasDefaultValue(21);

            //        Builder.Property(T => T.Address)
            //                                        .HasMaxLength(200)
            //                                        .IsUnicode(true);
            //        ///Optional as RelationShip follows Convinsion
            //        Builder.HasOne(T => T.Department)
            //                .WithMany(D => D.Teachers)
            //                .HasForeignKey("DepartmentID")
            //                .IsRequired()
            //                .OnDelete(DeleteBehavior.Cascade);
            //    });

            //modelBuilder.Entity<Department>(Bld =>
            //{
            //    Bld.Property(D => D.Name)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //    Bld.Property(D => D.Location)
            //    .HasMaxLength(200)
            //    .IsUnicode();

            //});

            #endregion

            //4.Configuration Classes
            modelBuilder.ApplyConfiguration<Teacher>(new TeacherConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());

            ///Must - if only One DBSet per Inheritance 
            //modelBuilder.Entity<WalkInStudent>().HasBaseType<Person>();
            //modelBuilder.Entity<FullTimeStudent>().HasBaseType<Person>();

            ///TpCOncreteType
            modelBuilder.Entity<Person>().UseTpcMappingStrategy(); /// 2 Tables for 1 Abstract class , 2 Concrete Class
            //modelBuilder.Entity<Person>().UseTptMappingStrategy(); ///Table Per Type 3 Tables , 3 Concrete Classes

            ///Custom Discriminator
            //modelBuilder.Entity<Person>().HasDiscriminator(P => P.IsEnrolled)
            //                        .HasValue<FullTimeStudent>(true)
            //                        .HasValue<WalkInStudent>(false);

            base.OnModelCreating(modelBuilder);
        }
    
    }
}
