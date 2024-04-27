using System.Linq;

namespace FizzBuzz.Tests
{
    internal class Asdfassssdf
    {
        private const int BasePrice = 8;

        internal static double Aasdfasdf(int[] basket)
        {
            if (HasDuplicates(basket))
                return basket.Length * BasePrice;

            if (basket.Length == 2)
                return ApplyDiscountOf5(BasePrice * 2);

            if (basket.Length == 3)
                return ApplyDiscountOf10(BasePrice * 3);

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