using System;

namespace JL.Test.Package
{
    public static class StringExtensions
    {
        public static void Repeat(this string x, int times)
        {
            if (times <= 0)
                throw new ArgumentOutOfRangeException(nameof(times), "Argument must be greater than 0");

            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(x);
            }
        }
    }
}
