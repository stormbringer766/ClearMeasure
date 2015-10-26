using fizbuz;

namespace FizzBuzz.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizz = new FizzBuzzInput(3, "Fizz");
            var buzz = new FizzBuzzInput(5, "Buzz");
            var fizzBuzz = new FizzBuzz(fizz, buzz);

            var processor = new FizzBuzzProcessor(1, 100, fizzBuzz, new FizzBuzzConsole());
            processor.Run();
        }
    }
}
