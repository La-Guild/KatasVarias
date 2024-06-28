using FluentAssertions;
using TellDontAskKata.Main.Domain;
using Xunit;

namespace TellDontAskKata.Tests.DomainTests
{
    public class ItemTests
    {
        [Fact]
        public void TestName()
        {
            Product product = new Product()
            {
                Price = 5m,
                Category = new Category()
                {
                    TaxPercentage = 50,
                }
            };

            var sut = OrderItem.From(product, quantity: 2);

            sut.Quantity.Should().Be(2);
            sut.Tax.Should().Be(5.00m);
            sut.TaxedAmount.Should().Be(15.00m);
        }
    }
}
