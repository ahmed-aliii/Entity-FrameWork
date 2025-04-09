using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day04Benchmark
{
    public class StringManipulation
    {
        [Benchmark]
        public void UseStringWithConcat()
        {
            string str = "";
            for (int i = 0; i < 10_000; i++)
            {
                str = str + ", " + i;
            }
        }

        [Benchmark]
        public void UseStringWithStringBuilder()
        {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 10_000; i++)
            {
                str.Append(", " + i);
            }
        }
    }
}
