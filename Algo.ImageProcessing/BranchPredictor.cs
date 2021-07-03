using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Algo.ImageProcessing
{
    public class BranchPredictor
    {
        byte[] _history = new byte[256];
        byte[] _hash = new byte[256];

        void InitHash()
        {
            for (int i = 128; i < 256; i++)
                _hash[i] = 1;
        }

        void InitHistory()
        {
            for (int i = 1; i < 256; ++i)
            {
                var k = i;
                for (int j = 0; j < 8; j++)
                {
                    _history[i] += Convert.ToByte(((k & (byte)(1 << j)) != 0));
                }
            }
        }

        public BranchPredictor()
        {
            InitHash();
            InitHistory();
        }

        public int Count(byte[,] arr, int n)
        {
            var count = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 7; j < n; j += 8)
                {
                    byte vl = 0;
                    for (int k = 7; k >= 0 ; --k)
                    {
                        byte bit = _hash[arr[i, j - k]];
                        vl = (byte)(vl | bit << k);
                    }

                    count += _history[vl];
                }
            }

            return count;
        }
    }
}
