//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace D10_PII
//{
//    internal class BankAccount
//    {
//        public required int AccountNumber { get; set;  }
//        public required string CustomerName { get; set; }

//        decimal balance;
//        public decimal Balance { get => balance; init { balance = value; } }

//        public bool Credit (decimal Amount)
//        {
//            if ( Amount > 0)
//            {
//                balance += Amount;
//                return true;
//            }
//            return false;
//        }

//        public bool Debit (decimal Amount)
//        {
//            if (Amount > Balance)
//                OnOverBalance();

//            else if ((Amount <= balance) && (Amount > 0))
//            {
//                balance -= Amount;
//                return true;

//            }
//            return false;
//        }

//        #region Event
//        public event EventHandler OverBalance;

//        protected virtual void OnOverBalance()
//        {
//            OverBalance?.Invoke(this , EventArgs.Empty); ///No Additional Event Args sent to Subsc.
//            //OverBalance?.Invoke(this, new EventArgs());
//        }


//        #endregion

//        public override string ToString() => $"Number:{AccountNumber} , Customer:{CustomerName} , Balance:{balance}";

//    }
//}
