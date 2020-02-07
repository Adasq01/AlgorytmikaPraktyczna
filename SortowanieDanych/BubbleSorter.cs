using System;
using System.Collections.Generic;

namespace SortowanieDanych
{
    public static class BubbleSorter
    {
        public static void BubbleSort<T>(this T[] array, IComparer<T> comparer,
            SortDirection sortDirection = SortDirection.Ascending)
            where T : IComparable
        {
            var n = array.Length;

            do
            {
                for (var i = 0; i < n - 1; i++)
                {
                    if (sortDirection == SortDirection.Ascending
                        ? array[i].CompareTo(array[i + 1]) <= 0
                        : array[i].CompareTo(array[i + 1]) > 0) continue;
                    var tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;
                }

                n--;
            } while (n > 1);
        }

        /// <summary>
        /// Sortowanie bąbelkowe tablicy int 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="sortDirection"></param>
        public static int[] BubbleSort(this int[] array, SortDirection sortDirection = SortDirection.Ascending)
        {
            // 1 operacja +
            if (array.Length < 2)
                return array;

            // 1 operacja +
            var n = array.Length;

            // n-1 * (operacje wewnątrz pętli)
            do
            {
                //n-1 * (operacje wewnatrz petli)
                for (var i = 0; i < n - 1; i++)
                {
                    // 2 operacje 
                    if (sortDirection == SortDirection.Ascending
                        ? array[i] < array[i + 1]
                        : array[i] > array[i + 1]) continue;
                    //3 operacje
                    var tmp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = tmp;

                    //MAX 5 operacji
                }
                // + 1 operacja
                n--;
            } 
            while (n > 1);
            // f(n) = 1 + 1 +(n-1)*((n-1)*5+1) = 2 + 5(n-1)^2 + (n-1)
            // Złożoność obliczeniowa = O(n^2)
            return array;

        }
    }
}