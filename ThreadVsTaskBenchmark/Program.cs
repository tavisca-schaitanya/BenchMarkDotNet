using BenchmarkDotNet.Running;
using System;

namespace ThreadVsTaskBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<ThreadVsTask>();
            Console.ReadKey();
        }
    }
}
