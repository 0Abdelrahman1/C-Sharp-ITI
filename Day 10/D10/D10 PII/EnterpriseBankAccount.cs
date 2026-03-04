using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    internal class EnterpriseBankAccount:BankAccount
    {
        public string CompanyName { get; set; }

        public bool TransferSalary (decimal Salary , BankAccount DestBankAccount)
        {
            ///Derived Class , Raise Base Event
            if (Salary > balance)
                OnOverBalance(new OverBalanceEventArgs() { DiffAmount = Salary - balance }); 
            else if (Salary > 0)
            {
                this.Balance -= Salary;
                DestBankAccount.Balance += Salary;
                return true;
            }
            return false;
        }
    }
}
