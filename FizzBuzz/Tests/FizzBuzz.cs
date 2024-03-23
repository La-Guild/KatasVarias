namespace FizzBuzz.Tests
{
    internal class FizzBuzz
    {
        internal static string Of(int value)
        {
            if (value == 3)
                return "Fizz";

            if (value == 5)
                return "Buzz";

            return value.ToString();
        }
    }
}