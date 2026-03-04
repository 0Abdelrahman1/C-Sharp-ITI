using System.Diagnostics.Tracing;

namespace D10_PII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount BC1 = new() { AccountNumber = 101, CustomerName = "Ali Ahmed", Balance = 10_000 };
            BankAccount BC2 = new() { AccountNumber = 102, CustomerName = "Mona Sayed", Balance = 15_000 };

            CustAgent Agent01 = new CustAgent() { Name = "Agent01" };
            CustAgent Agent02 = new CustAgent() { Name = "Agent02" };

            //BC1.OverBalance += Agent01.ContactClient;
            //BC1.OverBalance += BlackList.AddToBlackList;

            //BC2.OverBalance += Agent02.ContactClient;
            //BC2.OverBalance += BlackList.AddToBlackList;

            //BC1.Debit(3000);
            //Console.WriteLine(BC1);

            //BC1.Debit(7030);
            //BC2.Debit(20_000);

            //EnterpriseBankAccount EBC = new() { AccountNumber = 301, CompanyName = "ABC", CustomerName = "Sally Samir", Balance = 5000 };

            //EBC.OverBalance += BlackList.AddToBlackList;
            //EBC.OverBalance += Agent01.ContactClient;

            //EBC.TransferSalary(10000, BC1);

            CreditCardBankAccount BCC = new() { AccountNumber = 701, CustomerName = "Mina", Balance = 3000, Limit = 10_000 };

            BCC.OverBalance += BlackList.AddToBlackList;
            BCC.OverBalance += Agent01.ContactClient;

            BCC.Debit(7000);


            Console.WriteLine(BlackList.Content);

            






        }

    }
}
