using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Class1
    {
        [Fact]
        public void ASdfasdfasdf()
        {
            FizzBuzz.Of(3).Should().Be("Fizz");
            FizzBuzz.Of(5).Should().Be("Buzz");
            FizzBuzz.Of(12).Should().Be("12");
        }
    }
}
