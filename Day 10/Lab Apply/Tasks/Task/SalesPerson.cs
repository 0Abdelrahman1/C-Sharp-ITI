using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {
            if (AchievedTarget < Quota)
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.TargetNotReached });
                return false;
            }
            return true;
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.TargetNotReached) base.OnEmployeeLayOff(e);
        }
        public override bool RequestVacation(DateTime From, DateTime To) => From <= To;
        public override void EndOfYearOperation() {}
    }
}
