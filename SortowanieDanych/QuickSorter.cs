using System.Runtime.CompilerServices;

namespace SortowanieDanych
{
    public static class QuickSorter
    {
        public static void QuickSort(this int[] array, SortDirection sortDirection = SortDirection.Ascending)
        {
            array.Sort(0, array.Length - 1, sortDirection);
        }

        static void Sort(this int[] array, int left, int right, SortDirection direction)
        {
            var i = left;
            var j = right;
            //wartość środkowa
            var pivot = array[(left + right) / 2];
            
            while (i < j)
            {
                while (direction == SortDirection.Ascending
                    ? array[i] < pivot
                    : array[i] > pivot) i++;
                while (direction == SortDirection.Ascending
                    ? array[j] > pivot
                    : array[j] < pivot) j--;
                if (i > j) continue;
                var tmp = array[i];
                array[i++] = array[j]; 
                array[j--] = tmp;
            }

            if (left < j) Sort(array, left, j, direction);
            if (i < right) Sort(array, i, right, direction);
        }
    }
}