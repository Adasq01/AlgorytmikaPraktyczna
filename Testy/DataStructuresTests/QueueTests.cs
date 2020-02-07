using System;
using NUnit.Framework;
using StrukturyDanych;
using StrukturyDanych.Exceptions;

namespace Testy.DataStructuresTests
{
    public class QueueTests
    {
        [Test]
        public void InitializeNewQueueDoesNotThrowTest()
        {
            Assert.DoesNotThrow(() =>
            {
                var queue = new Queue<int>(0);
                var queue2 = new Queue<string>(0);
                var queue3 = new Queue<DateTime>(0);
                var queue4 = new Queue<object>(0);
            });
        }

        [Test]
        public void MaxQueuePushThrowsExceptionTest()
        {
            Assert.Throws<QueueMaxiumSizeException>(() =>
            {
                var queue = new Queue<int>(0);
                queue.Push(1);
            });
        }

        [Test]
        public void EmptyQueuePopThrowsExceptionTest()
        {
            Assert.Throws<QueueIsEmptyException>(() =>
            {
                var queue = new Queue<int>(0);
                queue.Pop();
            });
        }

        [Test]
        public void QueueFirstInFirstOutTests()
        {
            var queue = new Queue<int>(3);

            var intArray = new int[] {1, 2, 3};

            // Wrzuca pokolei elementy z tablicy int do kolejki.
            foreach (var el in intArray)
            {
                queue.Push(el);
            }

            // Dla ka¿dego elementu wybieraj¹c od pocz¹tku tablicy intArray, pobranie z kolejki powinno byæ równe.
            for (var i = 0; i < intArray.Length; i++)
            {
                Assert.AreEqual(intArray.Length - i, queue.CurrentSize);
                Assert.AreEqual(intArray[i], queue.Pop());
            }
        }
    }
}