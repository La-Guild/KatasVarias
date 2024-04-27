using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Class2
    {
        // 3 libros distintos dto de 10%
        // 4 libros distintos dto de 20%
        // 5 libros distintos dto de 25%
        // 4 libros 3 distintos dto de 10% en los 3 distintos + 8€ del repetido.

        [Fact]
        public void A_single_book_cost_8()
        {
            Asdfassssdf.Aasdfasdf(new[] { 1 }).Should().Be(8);
        }

        [Fact]
        public void Two_distinct_books_have_5percentage_discount()
        {
            const double BasePriceAfterDiscountOf5 = 0.95;

            Asdfassssdf.Aasdfasdf(new[] { 1, 2 }).Should()
                .Be((8 * 2) * BasePriceAfterDiscountOf5);
        }

        [Fact]
        public void Duplicate_books_have_no_discount()
        {
            Asdfassssdf.Aasdfasdf(new[] { 1, 1 }).Should().Be(8 * 2);
        }
    }
}
