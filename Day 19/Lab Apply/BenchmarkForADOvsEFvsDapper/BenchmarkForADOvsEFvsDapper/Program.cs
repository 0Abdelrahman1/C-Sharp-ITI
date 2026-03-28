using BenchmarkDotNet.Running;
using BenchmarkForADOvsEFvsDapper.Fakers;
using EFCoreProject.Context;
using Microsoft.EntityFrameworkCore;

namespace BenchmarkForADOvsEFvsDapper
{
    public class Program
    {
        static void Main(string[] args)
        {
            pubsContext.Context.Publishers.Load();
            var NewTitles = new TitleFaker(pubsContext.Context).Generate(10);
            try
            {
                pubsContext.Context.AddRange(NewTitles);
                pubsContext.Context.SaveChanges();
                pubsContext.Context.Titles.Local.Clear();
                var _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            }
            finally
            {
                foreach (var item in NewTitles)
                    pubsContext.Context.Remove(item);
                pubsContext.Context.SaveChanges();
                pubsContext.Context.Dispose();
            }
        }
    }
}
