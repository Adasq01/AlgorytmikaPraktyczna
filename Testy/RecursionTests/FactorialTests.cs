using System;
using NUnit.Framework;
using Rekurencja;

namespace Testy.RecursionTests
{
    public class FactorialTests
    {
        // znane wartości silni.
        private static readonly int[,] FactorialTable = 
        {
            {0, 1},
            {1, 1},
            {2, 2},
            {3, 6},
            {4, 24},
            {5, 120},
            {6, 720},
            {7, 5040},
            {8, 40320},
            {9, 362880},
            {10, 3628800}
        };

        [Test]
        public void RecursionFactorialTest()
        {
            for (int i = 0; i < FactorialTable.Length / 2; i++)
            {
                Assert.AreEqual(FactorialTable[i, 1], RecursionFactorial.Factorial(FactorialTable[i, 0]));
            }
        }

        [Test]
        public void LoopFactorialTest()
        {
            for (int i = 0; i < FactorialTable.Length / 2; i++)
            {
                Assert.AreEqual(FactorialTable[i, 1], LoopFactorial.Factorial(FactorialTable[i, 0]));
            }
        }
    }
}