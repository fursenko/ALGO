using System;

namespace Algo.BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Find(new int[] { 1, 1, 1, 1, 2, 2, 2, 2, 6, 6, 6, 7, 7, 7, 7, 88 }, 6));
            Console.WriteLine(Find(new int[] { 1, 1, 1, 1, 1, 1, 1, 1, 6, 6, 6, 6, 6 }, 6));
        }

        static int FindFirst(int[] arr, int target)
        {
            int start = -1;
            int end = arr.Length;
            int mid = 0;

            while (end - start > 1)
            {
                mid = (end + start) / 2;
                if (arr[mid] == target)
                {
                    end = mid;
                    continue;
                }

                start = mid;
            }

            return end;
        }

        static int Find(int[] arr, int target)
        {
            int start = -1;
            int end = arr.Length;
            int mid = 0;

            while (end - start > 1)
            {
                mid = (start + end) / 2;
                if (arr[mid] >= target) end = mid;
                else start = mid;
            }

            return end;
        }
    }
}
