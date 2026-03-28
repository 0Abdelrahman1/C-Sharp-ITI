using System;
using System.Linq;
using System.Security.Cryptography;
using BenchmarkDotNet.Attributes;
using Business_Logic_Layer.EntityManagers;
using EFCoreProject.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VSDiagnostics;

namespace BenchmarkForADOvsEFvsDapper
{
    // For more information on the VS BenchmarkDotNet Diagnosers see https://learn.microsoft.com/visualstudio/profiling/profiling-with-benchmark-dotnet
    [CPUUsageDiagnoser]
    public class Benchmarks
    {
        private SHA256 sha256 = SHA256.Create();
        private byte[] data;

        [GlobalSetup]
        public void Setup()
        {
            data = new byte[10000];
            new Random(42).NextBytes(data);
        }

        [Benchmark]
        public void GetAllTitlesEF()
        {
            var t = pubsContext.Context.Titles.ToList();
        }

        [Benchmark]
        public void GetAllTitlesADO()
        {
            var t = TitleManager.SelectAllTitles();
        }

        [Benchmark]
        public void GetAllTitlesDapper()
        {
            var t = DapperProject.TitleManager.GetALL();
        }

    }
}
