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
    }
}