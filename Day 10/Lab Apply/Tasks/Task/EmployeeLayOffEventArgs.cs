using System;
using System.Collections.Generic;
using System.Text;

namespace Task
{
    internal class EmployeeLayOffEventArgs : EventArgs
    {
        public LayOffCause Cause { get; set; }
    }
}
