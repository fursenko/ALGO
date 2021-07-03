using System;
using System.Collections;
using System.Collections.Generic;

namespace Algo.BranchPredictor
{
    class Program
    {
        static byte[] _history = new byte[255];
        static byte[] _hash = new byte[255];

        static void InitHash() 
        {
            for (int i = 128; i < 256; i++)
                _hash[i] = 1;
        }

        static void InitHistory() 
        {
            for (byte i = 1; i <= 255; i++)
            {
                var bits = new BitArray(i);

                for (int j = 0; j < bits.Length; j++)
                    _history[i] += Convert.ToByte(bits[j]);
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
