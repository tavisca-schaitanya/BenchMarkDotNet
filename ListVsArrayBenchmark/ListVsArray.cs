using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace ListVsArrayBenchmark
{
    public class ListVsArray
    {
        [Benchmark]
        public void ArrayLoop()
        {
            int[] arr = new int[10000];
            for(int index = 0; index < 10000; index++)
            {
                arr[index] = index;
            }
        }


        [Benchmark]
        public void ListLoop()
        {
            List<int> list = new List<int>();
            for (int index = 0; index < 10000; index++)
            {
                list.Add(index);
            }
        }
    }
}
