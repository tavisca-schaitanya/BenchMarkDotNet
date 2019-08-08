using BenchmarkDotNet.Running;
using System;

namespace StringVsStringBuilderBenchmark
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run<StringVsStringBuilder>();
            Console.ReadKey();
        }
    }
}
