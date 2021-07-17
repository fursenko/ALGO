using System;

namespace Algo.Sorting
{
    class Program
    {
        static int[] SelectionSort(int[] arr)
        {
            var n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                var min_i = i;

                for (int j = i + 1; j < n; j++)
                    if (arr[j] < arr[min_i])
                        min_i = j;

                var t = arr[i];
                arr[i] = arr[min_i];
                arr[min_i] = t;
            }

            return arr;
        }

        static int[] MergeSort(int[] arr_a, int[] arr_b)
        {
            var result = new int[arr_a.Length + arr_b.Length];

            int ai = 0;
            int bi = 0;
            for (int i = 0; i < result.Length; i++)
            {
                if (arr_a[ai] < arr_b[bi])
                {
                    result[i] = arr_a[ai];
                    if (ai < arr_a.Length - 1) ai++;
                }
                else
                {
                    result[i] = arr_b[bi];
                    if (bi < arr_b.Length - 1) bi++;
                }
            }

            return result;
        }
        // 1 3 5 7
        // 1 2 4 5 6 7
        static void Main(string[] args)
        {
            var arr = SelectionSort(new int[] { 564, 69887, 321, 5, -69, 8, 0 });
            
            foreach (var item in arr)
                Console.Write($"{item} ");
        }
    }
}
