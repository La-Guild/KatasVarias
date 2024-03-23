using FluentAssertions;
using Xunit;

namespace FizzBuzz.Tests
{
    public class Class1
    {
        [Fact]
        public void NotMultipleOf3or5_ReturnNumber()
        {
            FizzBuzz.Of(1).Should().Be("1");
        }

        [Fact]
        public void MultipleOf3_ShouldReturnFizz()
        {
            FizzBuzz.Of(3).Should().Be("Fizz");
            FizzBuzz.Of(9).Should().Be("Fizz");
        }

        [Fact]
        public void MultipleOf5_ShouldReturnBuzz()
        {
            FizzBuzz.Of(5).Should().Be("Buzz");
            FizzBuzz.Of(20).Should().Be("Buzz");
        }
    }
}
