using HospitalConsoleAPP.Context;
using HospitalConsoleAPP.Entities;
using Microsoft.EntityFrameworkCore;


using HospitalContext Context = new();

Context.Database.Migrate(); //Apply latest migration as PMC Command Update-Database

Context.Departments.AddRange([new() { Name = "ICU" }, new() { Name = "Hr" }]);

Console.WriteLine(Context.SaveChanges());
