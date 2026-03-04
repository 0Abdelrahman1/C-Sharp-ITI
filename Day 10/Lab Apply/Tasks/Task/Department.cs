using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff = new List<Employee>();
        public void AddStaff(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here
            //if (E == null || Employee.IsOlderThan60(E.BirthDate) || E.VacationStock < 0) return;
            
            Staff.Add(E);
            E.EmployeeLayOff += RemoveStaff;
        }
        ///CallBackMethod 
        public void RemoveStaff(object sender, EmployeeLayOffEventArgs e)
        {
            if (sender is not Employee employee || !Staff.Contains(employee)) return;
            bool remove = employee is SalesPerson && e.Cause == LayOffCause.TargetNotReached ||
                        employee is BoardMember && e.Cause == LayOffCause.Resigned ||
                        e.Cause == LayOffCause.AgeLimitExceeded || e.Cause == LayOffCause.VacationLimitExceeded;
            if (remove)
            {
                Staff.Remove(employee);
                employee.EmployeeLayOff -= RemoveStaff;
                Console.WriteLine($"\tBye Bye Emp#{employee.EmployeeID} From Dept#{DeptID} Dept Name:{DeptName}\n\tBecause: {e.Cause}  :(\n");
            }
        }
    }
}
