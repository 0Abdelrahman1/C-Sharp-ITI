// See https://aka.ms/new-console-template for more information

using D15.Context;
using D15.Entities;
using Microsoft.EntityFrameworkCore;

using SchoolContext Context = new();

Context.Database.EnsureDeleted(); ///Drop DB every Time
///ONLY in early phases of Development 

Context.Database.EnsureCreated();
///Create Database "SD46SchoolDB" if doesNot Exists , 

Context.Subjects.Add(new() { SubjectName = "C#" });


#region Insert
//Teacher T = new() { FullName="Ahmed Ali" , Salary=50_000 , Address = "B148 Smart Village" };

//Context.Teachers.Add(T); ///Local Copy

//Teacher T02 = new() { FullName = "Sara Ali", Address = "Cairo Uni Creativa", Age = 30, Salary = 90_000 };
//Context.Add(T02);

#endregion

#region Select , Update
//var Result = Context.Teachers.First(T => T.Salary < 80_000);

//Console.WriteLine(Context.Entry(Result).State); ///UnChanged

//Result.Salary = 80_000;

//Console.WriteLine(Context.Entry(Result).State); ///Modified

////Result = from T in Context.Teachers
////         where T.Salary < 80_000
////         select T;

////foreach (var T in Result)
////    Console.WriteLine(T);

////for (int i = 0; i < Result.Count; i++)
////    Result[i].Salary = 80_000;  ///update in Local Copy 
#endregion

#region Select , Delete
//var T01 = (from T in Context.Teachers
//           where T.Salary >= 80_000
//           select T).FirstOrDefault();

//Context.Teachers.Remove(T01);
////Context.Remove(T01);

//var T02 = Context.Teachers.FirstOrDefault(T => T.Age >= 25);

//Context.Entry(T02).State = EntityState.Deleted; 
#endregion

int R = Context.SaveChanges();
///Commit Changes to DataBase

//Console.WriteLine(Context.Entry(Result).State); ///UnChanged

Console.WriteLine($"{R} Rows Affected");

//Console.WriteLine(T02);

#region IDisposable Pattern
//try
//{
//var Result = from T in Context.Teachers
//             where T.Salary > 10000
//             select T;
//}
//finally
//{

//    Context.Dispose();
//}

#endregion
