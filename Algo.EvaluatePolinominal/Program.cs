using System;

namespace Algo.EvaluatePolinominal
{
    /*
     * B.
To evaluate the polynomial: y = a_n * x^n + a_n-1 * x^(n-1) + ... + a_1 * x + a_0
the following code uses 2n multiplications. Give a faster function:
y = a[0]
xi = 1
for i = [1, n]
   xi = x * xi
   y = y + a[i]*xi B.
To evaluate the polynomial: y = a_n * x^n + a_n-1 * x^(n-1) + ... + a_1 * x + a_0
the following code uses 2n multiplications. Give a faster function:
y = a[0]
xi = 1
for i = [1, n]
   xi = x * xi
   y = y + a[i]*xi 
     */
    class Program
    {
        static void EvaluatePolinominal(int x, int[] arr)
        {
            int xi = 1;
            int y = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {

            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
