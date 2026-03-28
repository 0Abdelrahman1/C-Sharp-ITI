using Bogus;
using Business_Logic_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
namespace BenchmarkForADOvsEFvsDapper.Fakers
{
    using EFCoreProject.Context;
    using EFCoreProject.Entities;
    using System.Linq;

    public class TitleFaker : Faker<Title>
    {
        public TitleFaker(pubsContext Context)
        {
            RuleFor(T => T.TitleId, F => F.UniqueIndex.ToString("D6"));
            RuleFor(T => T.Title1, F =>
            {
                var name = F.Name.FullName();
                return name.Length > 80 ? name[0..80] : name;
            });
            RuleFor(T => T.Type, F =>
            {
                var word = F.Lorem.Word();
                return word.Length > 12 ? word[0..12] : word;
            });
            RuleFor(T => T.PubId, F => F.PickRandom(Context.Publishers.Select(P => P.PubId).ToList()));
            RuleFor(T => T.Price, F => F.Random.Decimal(0.0m, 99.99m));
            RuleFor(T => T.Advance, F => F.Random.Decimal(0.0m, 20000.99m));
            RuleFor(T => T.Royalty, F => F.Random.Int(0, 25));
            RuleFor(T => T.YtdSales, F => F.Random.Int(0, 20000));
            RuleFor(T => T.Notes, F =>
            {
                var paragraph = F.Lorem.Paragraph(1);
                return paragraph.Length > 200 ? paragraph[0..200] : paragraph;
            });
            RuleFor(T => T.Pubdate, F => F.Date.Between(new DateTime(1900, 1, 1), new DateTime(2000, 1, 1)));
            RuleFor(T => T.Pub, (F, T) => Context.Publishers.FirstOrDefault(P => P.PubId == T.PubId));
        }
    }
}
