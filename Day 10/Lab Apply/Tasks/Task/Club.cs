using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Club
    {
        public int ClubID { get; set; }
        public string ClubName { get; set; }
        List<Employee> Members = new List<Employee>();
        public void AddMember(Employee E)
        {
            ///Try Register for EmployeeLayOff Event Here 
            //if (E == null || E.VacationStock < 0) return;
            Members.Add(E);
            E.EmployeeLayOff += RemoveMember;            
        }
        ///CallBackMethod 
        public void RemoveMember(object sender, EmployeeLayOffEventArgs e)
        {
            ///Employee Will not be removed from the Club if Age>60 
            ///Employee will be removed from Club if Vacation Stock < 0
            if (sender is not Employee employee || !Members.Contains(employee)) return;
            bool remove = employee is SalesPerson && e.Cause == LayOffCause.TargetNotReached || e.Cause == LayOffCause.VacationLimitExceeded;
            if (remove)
            {
                Members.Remove(employee);
                employee.EmployeeLayOff -= RemoveMember;
                Console.WriteLine($"\tBye Bye Emp#{employee.EmployeeID} From Club#{ClubID} Club Name:{ClubName}\n\tBecause: {e.Cause}  :(\n");
            }
        }
    }
}
