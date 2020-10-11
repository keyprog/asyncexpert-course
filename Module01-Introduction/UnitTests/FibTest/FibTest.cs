using System;
using System.Threading;
using System.Diagnostics;
using NUnit.Framework;
using Dotnetos.AsyncExpert.Homework.Module01.Benchmark;

namespace Tests
{
    public class FibTest
    {
        [Test]
        [TestCase(0UL, 0UL)]
        [TestCase(1UL, 1UL)]
        [TestCase(2UL, 1UL)]
        [TestCase(3UL, 2UL)]        
        public void Test1(ulong input, ulong expected)
        {            
            Assert.AreEqual(expected, new FibonacciCalc().RecursiveWithMemoization(input));
        }

        [Test]
        public void TestRandom()
        {
            ulong input = (ulong)(new Random().Next(4, 30));
            ulong expected = new FibonacciCalc().Recursive(input);
            ulong actualRecursive = new FibonacciCalc().RecursiveWithMemoization(input);
            ulong actualIterative = new FibonacciCalc().Iterative(input);
            Assert.AreEqual(expected, actualRecursive);
            Assert.AreEqual(expected, actualIterative);
        }
    }
}