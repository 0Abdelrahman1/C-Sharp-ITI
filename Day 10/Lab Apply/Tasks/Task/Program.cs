namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new() { EmployeeID = 1, BirthDate = new DateTime(1900, 1, 1), VacationStock = -1 };
            SalesPerson salesPerson = new() { EmployeeID = 2, BirthDate = new DateTime(1950, 1, 1), VacationStock=-2, AchievedTarget=10_000 };
            BoardMember boardMember = new() { EmployeeID = 3, BirthDate = new DateTime(1925, 1, 1), VacationStock=-3};

            Club club = new() { ClubID = 1, ClubName = "A" };

            Department department = new() { DeptID = 100, DeptName = "D100" };

            club.AddMember(employee);
            club.AddMember(boardMember);
            club.AddMember(salesPerson);

            department.AddStaff(employee);
            department.AddStaff(boardMember);
            department.AddStaff(salesPerson);

            employee.EndOfYearOperation();
            employee.RequestVacation(DateTime.Now, new DateTime(2030, 1, 1));
            
            salesPerson.RequestVacation(DateTime.Now, new DateTime(2030, 1, 1));
            salesPerson.EndOfYearOperation();
            salesPerson.CheckTarget(100_000);
            
            boardMember.RequestVacation(DateTime.Now, new DateTime(2030, 1, 1));
            boardMember.EndOfYearOperation();
            boardMember.Resign();

            

        }
    }
}
