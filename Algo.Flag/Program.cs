using System;

namespace Algo.Flag
{
    public enum Flag
    {
        DEFAULT_ZERO = 0b_0000_0000
        , F1 = 0b_0000_0001
        , F2 = 0b_0000_0010
        , F3 = 0b_0000_0100
    }

    public class FlagHolder
    {
        byte _descriptor = 0b_0000_0000;

        public FlagHolder(byte descriptor = 0b_0000_0000)
        {
            _descriptor = descriptor;
        }

        public void SetFlag(Flag flag)
        {
            _descriptor |= (byte)flag;
        }

        public bool HasFlag(Flag flag)
        {
            return (_descriptor & (byte)flag) == (byte)flag;
        }

        public void RemoveFlag(Flag flag)
        {
            _descriptor ^= (byte)flag;
        }

        public void Print()
        {
            Console.WriteLine(Convert.ToString(_descriptor, toBase: 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var holder = new FlagHolder();
                holder.Print();

                holder.SetFlag(Flag.F1);
                holder.Print();

                holder.SetFlag(Flag.F2);
                holder.Print();

                holder.SetFlag(Flag.F3);
                holder.Print();

                holder.RemoveFlag(Flag.F2);
                holder.Print();

                Console.WriteLine($"HasFlag F1: {holder.HasFlag(Flag.F1)}");
                Console.WriteLine($"HasFlag F2: {holder.HasFlag(Flag.F2)}");
                Console.WriteLine($"HasFlag F3: {holder.HasFlag(Flag.F3)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
