using System;
using NUnit.Framework;
using StrukturyDanych;
using StrukturyDanych.Exceptions;

namespace Testy.DataStructuresTests
{
    public class StackTests
    {
        [Test]
        public void InitializeNewStackDoesNotThrowTest()
        {
            Assert.DoesNotThrow(() =>
            {
                var stack = new Stack<int>(0);
                var stack2 = new Stack<string>(0);
                var stack3 = new Stack<DateTime>(0);
                var stack4 = new Stack<object>(0);
            });
        }

        [Test]
        public void MaxStackPushThrowsExceptionTest()
        {
            Assert.Throws<StackMaxiumSizeException>(() =>
            {
                var stack = new Stack<int>(0);
                stack.Push(1);
            });
        }

        [Test]
        public void EmptyStackPopThrowsExceptionTest()
        {
            Assert.Throws<StackIsEmptyException>(() =>
            {
                var stack = new Stack<int>(0);
                stack.Pop();
            });
        }

        [Test]
        public void StackLastInFirstOutTest()
        {
            var stack = new Stack<int>(3);

            var intArray = new int[] {1, 2, 3};

            // Wrzuca pokolei elementy z tablicy int do stosu.
            foreach (var el in intArray)
            {
                stack.Push(el);
            }


            // Dla ka¿dego elementu wybieraj¹c od koñca tablicy intArray, pobranie ze stosu powinno byæ równe.
            for (var i = intArray.Length - 1; i >= 0; i--)
            {
                Assert.AreEqual(i + 1, stack.CurrentSize);
                Assert.AreEqual(intArray[i], stack.Pop());
            }
        }
    }
}