using System;

namespace FizzBuzz.Console
{
    public class FizzBuzz
    {
        private readonly FizzBuzzInput _fizz;
        private readonly FizzBuzzInput _buzz;
        private readonly int _commutative;
        private readonly string _commutativeValue;

        public FizzBuzz(FizzBuzzInput fizz, FizzBuzzInput buzz)
        {
            _fizz = fizz ?? throw new ArgumentNullException(nameof(fizz));
            _buzz = buzz ?? throw new ArgumentNullException(nameof(buzz));

            _commutative = fizz.Divisor*buzz.Divisor;
            _commutativeValue = $"{_fizz.Display}{_buzz.Display}";
        }

        public string Process(int number)
        {
            var fizbuzz = number%_commutative == 0;
            var answer = number.ToString();

            if (fizbuzz)
            {
                answer = _commutativeValue;
            }
            else if (_fizz.IsMatch(number))
            {
                answer = _fizz.Display;
            }
            else if (_buzz.IsMatch(number))
            {
                answer = _buzz.Display;
            }
            return answer;
        }
    }
}
