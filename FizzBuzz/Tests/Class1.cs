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
            FizzBuzz.Of(9).Should().Be("Fizz");
            FizzBuzz.Of(5).Should().Be("Buzz");
            FizzBuzz.Of(20).Should().Be("Buzz");
            FizzBuzz.Of(1).Should().Be("1");
        }
    }
}
