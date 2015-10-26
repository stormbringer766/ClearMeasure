using fizbuz;

namespace FizzBuzz.Console
{
    public class FizzBuzzConsole : IFizzBuzzOutput
    {
        public void WriteLine(string value)
        {
            System.Console.WriteLine(value);
        }
    }
}