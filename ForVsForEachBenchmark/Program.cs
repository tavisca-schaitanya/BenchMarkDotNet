using BenchmarkDotNet.Running;
using System;

namespace ForVsForEachBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ForVsForEach>();
            Console.ReadKey();
        }
    }
}
