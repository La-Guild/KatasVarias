using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Tests
{
    internal class Asdfassssdf
    {
        private const int BasePrice = 8;

        internal static double Aasdfasdf(int[] basket)
        {
            var sdogmasfkdgm = BasePrice * basket.Length;

            if (HasDuplicates(basket))
                return sdogmasfkdgm;

            return sdogmasfkdgm * PriceAfterDiscountForDistinctBooks(basket.Length);
        }

        private static double PriceAfterDiscountForDistinctBooks(int howMany)
        {
            return howMany switch
            {
                1 => 1.00,
                2 => 0.95,
                3 => 0.90,
                4 => 0.80,
                5 => 0.75,
                _ => throw new ArgumentException("No hay más de cinco chaval.")
            };
        }

        private static bool HasDuplicates(int[] basket)
        {
            return basket.Distinct().Count() != basket.Count();
        }
    }
}