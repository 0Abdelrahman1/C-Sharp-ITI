using D18SchoolConsoleAPP;
using D18SchoolConsoleAPP.Context;
using D18SchoolConsoleAPP.Model;
using Microsoft.EntityFrameworkCore;

using SchoolContext Context = new();

Context.Database.Migrate();

//Context.Departments.Add(new() { Name = "Math", Location = "First Floor" });
//Context.Departments.Add(new() { Name = "English", Location = "Second Floor" });

//Context.Teachers.Add(new()
//{
//    FName = "Ahmed",
//    LName = "Ali",
//    Salary = 8000,
//    Address = "B148 SmartVillage"
//                              ,
//    Department = Context.Departments.Local.First()
//});
#region Inheritance TPH - Insert

//FullTimeStudent S01 = new FullTimeStudent()
//{ Name = "Sally Samir", Grade = 4, EnrollmentDate = new(2023, 7, 1) };

//WalkInStudent S02 = new WalkInStudent() { Name = "Mariam Khaled", CourseCode = "EN101" };

//Context.Add(S01);
//Context.Add(S02); 
#endregion

//Console.WriteLine(Context.FullTimeStudents.FirstOrDefault()?.Name??"NA");

///Only One DBSet
//Console.WriteLine(Context.People.OfType<FullTimeStudent>().FirstOrDefault()?.Name ?? "NA");



int R = Context.SaveChanges();

Console.WriteLine($"{R} Rows affected");