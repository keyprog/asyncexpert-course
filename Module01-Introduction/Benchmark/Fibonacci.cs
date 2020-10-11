using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace Dotnetos.AsyncExpert.Homework.Module01.Benchmark
{
    [DisassemblyDiagnoser(exportCombinedDisassemblyReport: true)]
    [MemoryDiagnoser()]
    public class FibonacciCalc
    {
        // HOMEWORK:
        // 1. Write implementations for RecursiveWithMemoization and Iterative solutions
        // 2. Add MemoryDiagnoser to the benchmark
        // 3. Run with release configuration and compare results
        // 4. Open disassembler report and compare machine code
        // 
        // You can use the discussion panel to compare your results with other students

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Data))]
        public ulong Recursive(ulong n)
        {
            if (n == 1 || n == 2) return 1;
            return Recursive(n - 2) + Recursive(n - 1);
        }
        

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoization(ulong n)
        {
            if (n == 0)
                return 0;            

            var fibCache = new ulong[n + 1];
            fibCache[1] = 1;
            fibCache[2] = 1;
            return RecursiveWithMemoizationInternal(n, fibCache);
        }

        private ulong RecursiveWithMemoizationInternal(ulong n, ulong[] fibCache)
        {
            ulong val = fibCache[n];
            if (val != 0)
                return val;
            
            fibCache[n] = val = RecursiveWithMemoizationInternal(n - 2, fibCache) + RecursiveWithMemoizationInternal(n - 1, fibCache);
            return val;            
        }

        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong RecursiveWithMemoizationWithStackAlloc(ulong n)
        {   
            Span<ulong> fibCache = stackalloc ulong[(int)n + 1];
            fibCache[1] = 1;
            fibCache[2] = 1;
            return RecursiveWithMemoizationInternalWithStackAlloc((int)n, fibCache);
        }

        private ulong RecursiveWithMemoizationInternalWithStackAlloc(int n, Span<ulong> fibCache)
        {
            ulong val = fibCache[n];
            if (val != 0)
                return val;
            
            fibCache[n] = val = RecursiveWithMemoizationInternalWithStackAlloc(n - 2, fibCache) + RecursiveWithMemoizationInternalWithStackAlloc(n - 1, fibCache);
            return val;            
        }
        
        [Benchmark]
        [ArgumentsSource(nameof(Data))]
        public ulong Iterative(ulong n)
        {
            if (n > Int64.MaxValue - 1)
                throw new ArgumentException($"Max n value is {Int64.MaxValue - 1}");

            if (n == 0)
                return 0;
            
            ulong[] fibCache = new ulong[n + 1];            
            fibCache[1] = 1;
            fibCache[2] = 1;

            for(ulong i = 3ul; i <= n; ++i)
            {
                fibCache[i] = fibCache[i-2] + fibCache[i-1];
            }

            return fibCache[n];
            
        }

        public IEnumerable<ulong> Data()
        {
            yield return 15;
            yield return 35;
        }
    }
}
