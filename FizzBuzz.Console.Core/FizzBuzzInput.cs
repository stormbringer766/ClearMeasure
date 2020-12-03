using System;

namespace FizzBuzz.Console
{
    public class FizzBuzzInput
    {
        private readonly int _divisor;
        private readonly string _display;

        public FizzBuzzInput(int divisor, string display)
        {
            if (divisor == 0)
                throw new ArgumentOutOfRangeException(nameof(divisor));
            if (String.IsNullOrWhiteSpace(display))
                throw new ArgumentNullException(nameof(display));

            _divisor = divisor;
            _display = display;
        }

        public bool IsMatch(int number)
        {
            return number%_divisor == 0;
        }

        public int Divisor => _divisor;

        public string Display => _display;
    }
}
