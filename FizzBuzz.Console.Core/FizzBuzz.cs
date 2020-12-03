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
            if (fizz == null)
                throw new ArgumentNullException("fizz");
            if (buzz == null)
                throw new ArgumentNullException("buzz");

            _fizz = fizz;
            _buzz = buzz;
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