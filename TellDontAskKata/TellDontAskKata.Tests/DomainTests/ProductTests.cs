using FluentAssertions;
using TellDontAskKata.Main.Domain;
using Xunit;

namespace TellDontAskKata.Tests.DomainTests
{
    public class ProductTests
    {

        [Fact]
        public void TestName()
        {
            var sut = new Product()
            {
                Price = 5m,
                Category = new Category()
                {
                    TaxPercentage = 50,
                }
            };

            sut.UnitaryTax.Should().Be(2.50m);
        }

        [Fact]
        public void Tiritiritiriiiiitiritiriii()
        {
            var sut = new Product()
            {
                Price = 5m,
                Category = new Category()
                {
                    TaxPercentage = 50,
                }
            };

            sut.UnitaryTaxedAmount.Should().Be(7.50m);
        }
    }
}
