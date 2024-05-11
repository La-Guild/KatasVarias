using System.Linq;
using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Class2
    {
        // Objetivos: 
        // - Completar el requisito
        // - Evaluar cómo nos ha afectado el orden de tests
        // - Chilling
        // - Ver que es Public vs Publish API.

        // 4 libros 3 distintos dto de 10% en los 3 distintos + 8€ del repetido.

        [Fact]
        public void A_single_book_cost_8()
        {
            PotterShop.CashOut(new[] { 1 }).Should().Be(8);
        }

        [Fact]
        public void Two_distinct_books_have_5percentage_discount()
        {
            const double BasePriceAfterDiscountOf5 = 0.95;

            PotterShop.CashOut(new[] { 1, 2 }).Should()
                .Be((8 * 2) * BasePriceAfterDiscountOf5);
        }

        [Fact]
        public void Duplicate_books_have_no_discount()
        {
            PotterShop.CashOut(new[] { 1, 1 }).Should().Be(8 * 2);
        }

        [Fact]
        public void Three_distinct_books_have_10percentage_discount()
        {
            const double BasePriceAfterDiscountOf10 = 0.90;

            PotterShop.CashOut(new[] { 1, 2, 3 }).Should()
                .Be((8 * 3) * BasePriceAfterDiscountOf10);
        }

        [Fact]
        public void Four_distinct_books_have_20percentage_discount()
        {
            const double BasePriceAfterDiscountOf20 = 0.80;

            PotterShop.CashOut(new[] { 1, 2, 3, 4 }).Should()
                .Be((8 * 4) * BasePriceAfterDiscountOf20);
        }

        [Fact]
        public void Five_distinct_books_have_25percentage_discount()
        {
            const double BasePriceAfterDiscountOf25 = 0.75;

            PotterShop.CashOut(new[] { 1, 2, 3, 4, 5 }).Should()
                .Be((8 * 5) * BasePriceAfterDiscountOf25);
        }

        [Fact]
        public void Four_books_with_three_distinct_applies_discount_for_the_three_plus_normal_price_for_duplicate()
        {
            PotterShop.CashOut(new[] { 1, 2, 3, 3 }).Should().Be(29.60);
        }

        [Fact]
        public void DFGsdfgsdfh()
        {
            PotterShop.HowManyDuplicates(new[] { 1, 3, 3 }).Should().Be(1);
        }
    }
}