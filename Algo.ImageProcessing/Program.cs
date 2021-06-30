using System;
using System.Diagnostics;

namespace Algo.ImageProcessing
{
    class Program
    {
        const int N = 4096;
        static byte[,] _image = new byte[N, N];
        static long _count = 0;

        static void InitImage(bool isDark = false)
        {
            _image = new byte[N, N];
            var random = new Random();
            int shift = (isDark) ? 0 : (N / 2) + 1;
            
            for (int i = 0; i < N; i++)
                for (int j = 0; j < N - shift; j++)
                    _image[i, j] = (byte)random.Next(128, 255);
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

        public static bool isDark_OptimizedPlus()
        {
            _count = 0;
            int r = N - 1; 
            int c = r;
            for (int i = 0; i < N / 2; ++i, --r)
            {
                for (int j = 0; j < N / 2; ++j, --c)
                {
                    _count += Convert.ToInt32(_image[i, j] >= 128);
                    _count += Convert.ToInt32(_image[r, c] >= 128);
                }

                c = N - 1;
            }
            return _count > ((N * N) / 2);

        }


        static void Main(string[] args)
        {
            InitImage(true);
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine(isDark_OptimizedPlus());
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
