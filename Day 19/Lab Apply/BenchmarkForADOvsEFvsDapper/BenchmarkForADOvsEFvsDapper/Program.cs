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
            pubsContext.Instance.Publishers.Load();
            var NewTitles = new TitleFaker(pubsContext.Instance).Generate(10000);
            try
            {
                pubsContext.Instance.AddRange(NewTitles);
                pubsContext.Instance.SaveChanges();
                pubsContext.Instance.Titles.Local.Clear();
                var _ = BenchmarkRunner.Run(typeof(Program).Assembly);

            }
            finally
            {
                foreach (var item in NewTitles)
                    pubsContext.Instance.Remove(item);
                pubsContext.Instance.SaveChanges();
                pubsContext.Instance.Dispose();
            }
        }
    }
}
