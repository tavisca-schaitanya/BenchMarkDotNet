using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForVsForEachBenchmark
{
    public class ForVsForEach
    {
        List<int> source = new List<int>();
        List<int> destination1 = new List<int>();
        List<int> destination2 = new List<int>();

        public ForVsForEach()
        {
            for (int index = 0; index < 10000; index++)
                source.Add(index);
        }


        [Benchmark]
        public void ForLoop()
        {
            for (int index = 0; index < source.Count; index++)
            {
                destination1.Add(source[index]);
            }
        }


        [Benchmark]
        public void ForEachLoop()
        {
            foreach (var element in source)
            {
                destination2.Add(element);
            }
        }

    }
}
