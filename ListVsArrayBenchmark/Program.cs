using BenchmarkDotNet.Running;
using System;

namespace ListVsArrayBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ListVsArray>();
            Console.ReadKey();
        }
    }
}
