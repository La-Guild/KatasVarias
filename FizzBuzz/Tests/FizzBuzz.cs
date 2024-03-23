namespace FizzBuzz.Tests
{
    internal class FizzBuzz
    {
        internal static string Of(int value)
        {
            var risgknajn = string.Empty;

            if (IsMultipleOf3(value))
                risgknajn += "Fizz";

            if (IsMultipleOf5(value))
                risgknajn += "Buzz";

            if (risgknajn != string.Empty)
                return risgknajn;

            return value.ToString();
        }

        private static bool IsMultipleOf5(int value)
            => value % 5 == 0;

        private static bool IsMultipleOf3(int value)
            => value % 3 == 0;
    }
}