using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace StringVsStringBuilderBenchmark
{
    public class StringVsStringBuilder
    {
        
        [Benchmark]
        public void StringAppend()
        {
            string s1 = "";

            for (int i = 0; i < 10; i++)
                s1 += i;
        }


        [Benchmark]
        public void StringBuilderAppend()
        {
            StringBuilder s2 = new StringBuilder("");

            for (int i = 0; i < 10; i++)
                s2.Append(i);
        }
    }
}
