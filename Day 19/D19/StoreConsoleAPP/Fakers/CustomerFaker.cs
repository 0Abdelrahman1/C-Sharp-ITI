using Bogus;
using StoreConsoleAPP.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreConsoleAPP.Fakers
{
    internal class CustomerFaker:Faker<Customer>
    {
        public CustomerFaker()
        {
            RuleFor(C => C.FullName, F => F.Name.FullName());
            RuleFor(C => C.Address, Faker => new FullAddressFaker());
            RuleFor(C => C.LastVisit, F => F.Date.Recent());

            //RuleFor(C => C.Address.City , Faker=> Faker.Address.City());
        }
    }
}
