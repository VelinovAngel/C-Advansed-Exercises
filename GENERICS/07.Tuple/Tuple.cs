﻿
namespace _07.Tuple
{
    public class Tuple<TFirst, TSecond>
    {
        public Tuple(TFirst first, TSecond second)
        {
            this.First = first;
            this.Second = second;
        }

        public TFirst First { get; set; }

        public TSecond Second { get; set; }

        public override string ToString()
        {
            return $"{First} -> {Second}";
        }
    }
}
