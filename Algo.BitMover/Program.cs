using System;

namespace Algo.BitMover
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 8; i++)
            {
                Console.WriteLine($"(byte)(1 << {i}) : {(int)(1 << i)}");
            }
        }
    }
}
