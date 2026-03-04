using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class Employee
    {
        public event EventHandler<EmployeeLayOffEventArgs> EmployeeLayOff;
        protected virtual void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            EmployeeLayOff?.Invoke(this, e);
        }

        public int EmployeeID { get; set; }

        public DateTime BirthDate
        {
            get;
            set 
            {
                //if (IsOlderThan60(value)) throw new Exception("U can't Make an Employee with Age More than 60 years");
                field = value;
            }
        }
        int vacation;
        public int VacationStock
        {
            get {  return vacation; }
            set
            {
                //if (value < 0) throw new Exception("U can't initialize Vacation Stock with negative value");
                vacation = value;
            }
        }
        public static bool IsOlderThan60(DateTime BirthDate) => (DateTime.Now - BirthDate).TotalDays / 365.25 > 60;
        public virtual bool RequestVacation(DateTime From, DateTime To)
        {
            if (From > To) return false;
            vacation -= (To - From).Days;
            if (VacationStock < 0)
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.VacationLimitExceeded });
                return false;
            }
            return true;
        }

        public virtual void EndOfYearOperation()
        {
            if (IsOlderThan60(BirthDate))
                OnEmployeeLayOff(new() { Cause = LayOffCause.AgeLimitExceeded });
        }
    }
}
