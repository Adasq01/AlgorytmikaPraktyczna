using NUnit.Framework;
using SortowanieDanych;

namespace Testy.SortersTests
{
    public class LinqSorterTests
    {
        [Test]
        public void LinqSortDescendingTest()
        {
            var arrayDescending = new int[]
            {
                10, 9, 8, 7, 6, 5, 4, 3, 2, 1
            };

            var arrayToSort = new int[]
            {
                9, 10, 2, 1, 4, 5, 3, 6, 8, 7
            };

            Assert.AreNotEqual(arrayDescending, arrayToSort);

            arrayToSort.QuickSort(SortDirection.Descending);

            Assert.AreEqual(arrayDescending, arrayToSort);
        }

        [Test]
        public void LinqSortAscendingTest()
        {
            var arrayAscending = new int[]
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var arrayToSort = new int[]
            {
                9, 10, 2, 1, 4, 5, 3, 6, 8, 7
            };

            Assert.AreNotEqual(arrayAscending, arrayToSort);

            arrayToSort.QuickSort();

            Assert.AreEqual(arrayAscending, arrayToSort);
        }
    }
}
