using System;
using System.Collections.Generic;
using System.Text;
using Bogus;
using StoreConsoleAPP.ComplexTypes;

namespace StoreConsoleAPP.Fakers
{
    internal class FullAddressFaker:Faker<FullAddress>
    {
        public FullAddressFaker()
        {
            RuleFor(A => A.City, F => {
                string City = F.Address.City();
                return City.Length > 15 ? City.Substring(0,15) : City;
                });
            RuleFor(A => A.Country, F => {
                String Country = F.Address.Country();
                return Country.Length > 20 ? Country.Substring(0,20):Country;
                });
            RuleFor(A => A.FirstLine, F => F.Address.StreetName());
            RuleFor(A => A.FloorNumber, F => F.Random.Byte(1,10));
            RuleFor(A => A.ApNumber, F => F.Random.Byte(1, 100));
            RuleFor(A => A.ZipCode, F => F.Address.ZipCode());



        }
    }
}
