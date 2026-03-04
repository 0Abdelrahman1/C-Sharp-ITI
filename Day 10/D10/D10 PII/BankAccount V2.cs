using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    internal class BankAccount
    {
        public required int AccountNumber { get; set; }
        public required string CustomerName { get; set; }

        protected decimal balance;
        public decimal Balance { get => balance; internal set { balance = value; } }

        public bool Credit(decimal Amount)
        {
            if (Amount > 0)
            {
                balance += Amount;
                return true;
            }
            return false;
        }

        public bool Debit(decimal Amount)
        {
            if (Amount > Balance)
                OnOverBalance(new OverBalanceEventArgs() { DiffAmount = Amount - Balance });

            else if (Amount > 0)
            {
                balance -= Amount;
                return true;

            }
            return false;
        }

        public bool Transfer (decimal Amount , BankAccount DestAccount)
        {
            if (Amount > Balance)
                OnOverBalance(new() { DiffAmount = Amount - balance });

            else if (Amount > 0)
            {
                balance -= Amount;
                DestAccount.Balance += Amount;
                return true;
            }
            return false;
        }


        #region Event
        public event EventHandler<OverBalanceEventArgs> OverBalance;
        //public event EventHandler OverBalance;

        protected virtual void OnOverBalance(OverBalanceEventArgs e)
        {
            OverBalance?.Invoke(this, e); 
            //OverBalance?.Invoke(this, new EventArgs());
        }


        #endregion

        public override string ToString() => $"Number:{AccountNumber} , Customer:{CustomerName} , Balance:{balance}";

    }
}
