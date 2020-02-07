using System.Linq;

namespace SortowanieDanych
{
    public static class LinqSorter
    {
        public static int[] LinqSort(this int[] array, SortDirection sortDirection = SortDirection.Ascending)
        {
            array = sortDirection == SortDirection.Ascending ? array.OrderBy(x => x).ToArray() : array.OrderByDescending(x => x).ToArray();
            return array;
        }
    }
}
