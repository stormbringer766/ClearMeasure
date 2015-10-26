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
                throw new ArgumentOutOfRangeException("divisor");
            if (String.IsNullOrWhiteSpace(display))
                throw new ArgumentNullException("display");

            _divisor = divisor;
            _display = display;
        }

        public int Divisor
        {
            get { return _divisor; }
        }

        public string Display
        {
            get { return _display; }
        }
    }
}