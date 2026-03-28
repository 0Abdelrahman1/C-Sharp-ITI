using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;
using System;
using System.Security.Cryptography;

namespace BenchmarkADOvsEFvsDaper
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
        public int GetCountUsingString()
        {
            int Counter = 0;
            for( int i=0; i < 10_000; i++)
                foreach (char Ch in i.ToString())
                    if (Ch == '1') Counter++;
            return Counter;
        }
        [Benchmark]
        public int GetCountUsingStringConcat()
        {
            int Counter = 0;
            String Str = "";
            for (int i = 0; i < 10_000; i++)
                Str += i.ToString();
            
            foreach (Char Ch in Str)
                if (Ch == '1') Counter++;

            return Counter;
        }

    }
}
