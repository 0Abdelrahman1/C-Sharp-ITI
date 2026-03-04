using System;
using System.Collections.Generic;
using System.Text;

namespace D10_PII
{
    internal class CreditCardBankAccount:BankAccount
    {
        public decimal Limit { get; set; }

        protected override void OnOverBalance(OverBalanceEventArgs e)
        {
            if (e.DiffAmount > Limit)
                base.OnOverBalance(e);
        }
    }
}
