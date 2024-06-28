using FluentAssertions;
using TellDontAskKata.Main.Domain;
using Xunit;

namespace TellDontAskKata.Tests.DomainTests
{
    public class OrderTests
    {
        [Fact]
        public void MyTestMethod()
        {
            var sut = new Order();
            OrderItem item = new OrderItem();

            sut.Add(item);

            sut.Items.Should().NotBeEmpty();
        }
    }
}
