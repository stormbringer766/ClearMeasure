using System;

namespace FizzBuzz.Console
{
    public class FizzBuzzProcessor
    {
        private readonly int _start;
        private readonly int _end;
        private readonly FizzBuzz _fizzBuzz;
        private readonly IFizzBuzzOutput _output;

        public FizzBuzzProcessor(int start, int end, FizzBuzz fizzBuzz, IFizzBuzzOutput output)
        {
            if (end < start)
                throw new ArgumentOutOfRangeException("end");
            if (fizzBuzz == null)
                throw new ArgumentNullException("fizzBuzz");
            if (output == null)
                throw new ArgumentNullException("output");

            _start = start;
            _end = end;
            _fizzBuzz = fizzBuzz;
            _output = output;
        }

        public void Run()
        {
            for (int i = _start; i <= _end; i++)
            {
                _output.WriteLine(_fizzBuzz.Process(i));
            }
        }
    }
}