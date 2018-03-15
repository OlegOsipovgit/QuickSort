using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    public class QuickSorting
    {
        public static int[] Sorting(int[] arr, long first, long last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            long i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Sorting(arr, first, j);
            if (i < last) Sorting(arr, i, last);
            return arr;
        }
    }
}



  
