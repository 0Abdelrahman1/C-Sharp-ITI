using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new() { Cause = LayOffCause.Resigned });
        }
        protected override void OnEmployeeLayOff(EmployeeLayOffEventArgs e)
        {
            if (e.Cause == LayOffCause.Resigned) base.OnEmployeeLayOff(e);
        }
        public override void EndOfYearOperation() { }
        public override bool RequestVacation(DateTime From, DateTime To) => From <= To;

    }
}
