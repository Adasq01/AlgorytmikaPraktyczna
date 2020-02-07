using NUnit.Framework;
using SortowanieDanych;

namespace Testy.SortersTests
{
    public class MergeSorterTests
    {
        [Test]
        public void MergeSortDescendingTest()
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

            arrayToSort.MergeSort(SortDirection.Descending);

            Assert.AreEqual(arrayDescending, arrayToSort);
        }

        [Test]
        public void MergeSortAscendingTest()
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

            arrayToSort.MergeSort();

            Assert.AreEqual(arrayAscending, arrayToSort);
        }
    }
}
