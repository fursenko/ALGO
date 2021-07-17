using System;

namespace Algo.BitMover
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = 14;
            //for (int i = 0; i <= 8; i++)
            //{
            //    Console.WriteLine($"(byte)(1 << {i}) : {(byte)(1 << i)} : {Convert.ToString((byte)(1 << i), 2)}");
            //}

            //Console.WriteLine(Convert.ToString(Convert.ToInt64($"{long.MaxValue}") * long.MaxValue, 2));
            var vl = 12;
            Console.WriteLine(Convert.ToString(vl, 2));

            for (int i = 0; i < 8; i++)
            {
                Console.Write($"{Convert.ToString(vl >> i, 2)} {Convert.ToString(vl >> i, 10)} {Convert.ToString(vl >> i, 2)}");
            }

        }
    }
}
