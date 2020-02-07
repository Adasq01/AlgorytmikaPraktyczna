namespace SortowanieDanych
{
    public static class MergeSorter
    {
        public static int[] MergeSort(this int[] array, SortDirection sortDirection = SortDirection.Ascending)
        {
            return array.Sort(0, array.Length - 1, sortDirection);
        }

        static int[] Sort(this int[] array, int left, int right, SortDirection direction)
        {
            var helperArray = new int[array.Length];

            if (left >= right) return array;
            
            //podziel sortowana tablice na pol
            array.Sort(left, (left + right) / 2, direction);
            array.Sort((left + right) / 2 + 1, right, direction);
            //scal posortowane tablice
            array.Merge(helperArray, left, right, direction);
            return array;
        }

        static void Merge(this int[] array, int[] helperArray, int left, int right, SortDirection direction)
        {
            //Skopiuj wartosci do tablicy pomocniczej
            for (var i = left; i <= right; i++)
            {
                helperArray[i] = array[i];
            }

            //Scalaj tablice
            var p = left;
            var q = (left + right) / 2 + 1;
            var r = left;
            while (p <= (left + right) / 2 && q <= right)
            {
                if (direction == SortDirection.Descending 
                    ? helperArray[p] > helperArray[q] 
                    : helperArray[p] < helperArray[q])
                {
                    array[r] = helperArray[p];
                    r++;
                    p++;
                }
                else
                {
                    array[r] = helperArray[q];
                    r++;
                    q++;
                }
            }

            //Przepisz koncowke
            while (p <= (left + right) / 2)
            {
                array[r] = helperArray[p];
                r++;
                p++;
            }
        }

    }
}
