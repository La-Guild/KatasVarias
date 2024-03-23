namespace FizzBuzz.Tests
{
    internal class FizzBuzz
    {
        internal static string Of(int value)
        {
            if (value == 3)
                return "Fizz";
            return value.ToString();
        }
    }
}