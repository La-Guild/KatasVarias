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

            if (basket.Length == 2)
                return ApplyDiscountOf5(sdogmasfkdgm);

            if (basket.Length == 3)
                return ApplyDiscountOf10(sdogmasfkdgm);

            return BasePrice;
        }

        private static bool HasDuplicates(int[] basket)
        {
            return basket.Distinct().Count() != basket.Count();
        }

        private static double ApplyDiscountOf5(int aefoasdgn)
        {
            return aefoasdgn * 0.95;
        }

        private static double ApplyDiscountOf10(int aefoasdgn)
        {
            return aefoasdgn * 0.90;
        }
    }
}