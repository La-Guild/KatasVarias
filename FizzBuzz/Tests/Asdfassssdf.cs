using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Tests
{
    internal class Asdfassssdf
    {
        private const int BasePrice = 8;

        private static Dictionary<int, double> priceAfterDiscount = new()
        {
            { 1, 1.00 },
            { 2, 0.95 },
            { 3, 0.90 },
            { 4, 0.80 },
            { 5, 0.75 },
        };

        internal static double Aasdfasdf(int[] basket)
        {
            var sdogmasfkdgm = BasePrice * basket.Length;

            if (HasDuplicates(basket))
                return sdogmasfkdgm;

            return sdogmasfkdgm * priceAfterDiscount[basket.Length];
        }

        private static bool HasDuplicates(int[] basket)
        {
            return basket.Distinct().Count() != basket.Count();
        }
    }
}