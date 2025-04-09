
using System;
using System.Data.Common;
using System.Threading.Tasks;
using System.Transactions;
using System.Data.SqlClient;
using Day04Benchmark;
using BenchmarkDotNet.Running;



namespace Day04Benchmark
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Measure the performance of the StringManipulation methods

            var summary = BenchmarkRunner.Run<StringManipulation>();
        }
    }
}