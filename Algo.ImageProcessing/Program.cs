using System;
using System.Diagnostics;

namespace Algo.ImageProcessing
{
    class Program
    {
        const int N = 4096;
        static byte[,] _image = new byte[N, N];
        static long _count = 0;
        static int[] _hash = new int[256];
            
        //static BranchPredictor _branchPredictor;

        static void InitImage(bool isDark = false)
        {
            _image = new byte[N, N];
            var random = new Random();
            int shift = (isDark) ? 1 : (N / 2) + 1;
            
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N - shift; j++)
                    _image[i, j] = (byte)random.Next(128, 255);

            for (int i = 128; i <= 255; i++)
                _hash[i] = 1;
        }

        public static bool isDark()
        {
            _count = 0;
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    if (_image[j, i] >= 128)
                        _count++;
            
            return _count > ((N * N) / 2);
        }

        public static bool isDark_Optimized()
        {
            _count = 0;
            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                    if (_image[i, j] >= 128)
                        _count++;
            
            return _count > ((N * N) / 2);
        }

        public static bool isDark_BranchPredictor()
        {
            _count = 0;
            var hash = new int[256];
            
            for (int i = 128; i <= 255; i++)
                hash[i] = 1;

            for (int i = 0; i < N; ++i)
                for (int j = 0; j < N; ++j)
                        _count += hash[_image[i, j]];

            return _count > ((N * N) / 2);
        }


        static void Main(string[] args)
        {
            InitImage(true);
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(isDark_BranchPredictor());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            //Console.WriteLine($"isDark: {isDark()} _count: {_count}");
            //Console.WriteLine($"isDark_Optimized: {isDark_Optimized()} _count: {_count}");
            //Console.WriteLine($"isDark_BranchPredictor: {isDark_BranchPredictor()} _count: {_count}");
        }
    }
}
